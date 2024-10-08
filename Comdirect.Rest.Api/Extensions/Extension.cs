﻿namespace Comdirect.CSharp
{
    public static class Extension
    {
        /// <summary>
        /// Converts the specified object to its equivalent string representation using the provided culture information.
        /// </summary>
        /// <param name="value">The object to convert.</param>
        /// <param name="cultureInfo">The culture information to use for formatting the value.</param>
        /// <returns>
        /// The string representation of the value. If the value is null, the method returns null.
        /// If the value is an enum, the method returns the enum member's name or the value specified by the EnumMemberAttribute.
        /// If the value is a boolean, the method returns the lowercase string representation of the value.
        /// If the value is a byte array, the method returns the Base64 string representation of the value.
        /// If the value is an array, the method returns a comma-separated string representation of the array elements.
        /// For other types, the method returns the string representation of the value using the provided culture information.
        /// </returns>
        public static string ConvertToString(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value == null)
            {
                return null;
            }

            if (value is System.Enum)
            {
                var name = System.Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field != null)
                    {
                        var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
                            as System.Runtime.Serialization.EnumMemberAttribute;
                        if (attribute != null)
                        {
                            return attribute.Value != null ? attribute.Value : name;
                        }
                    }

                    return System.Convert.ToString(System.Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                }
            }
            else if (value is bool)
            {
                return System.Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
            }
            else if (value is byte[])
            {
                return System.Convert.ToBase64String((byte[])value);
            }
            else if (value.GetType().IsArray)
            {
                var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
                return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
            }

            var result = System.Convert.ToString(value, cultureInfo);
            return (result is null) ? string.Empty : result;
        }
    }
}