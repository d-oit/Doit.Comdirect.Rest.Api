namespace SettingManager
{
    /// <summary>
    /// static class SettingsHelpers
    ///  </summary>
    public static class SettingsHelpers
    {
        /// <summary>
        /// Updates or adds a new app setting in the 'appsettings.json' file.
        /// </summary>
        /// <typeparam name="T">The type of the value to be set.</typeparam>
        /// <param name="sectionPathKey">The section path and key in the format "section1:section2:key". 
        /// This will navigate through the JSON object to find the correct section.</param>
        /// <param name="value">The new value to be set for the specified key.</param>
        public static void AddOrUpdateAppSetting<T>(string sectionPathKey, T value)
        {
            try
            {
                var filePath = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
                string json = File.ReadAllText(filePath);
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

                SetValueRecursively(sectionPathKey, jsonObj, value);

                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filePath, output);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing app settings | {0}", ex.Message);
            }
        }

        /// <summary>
        /// Recursively sets a value in a JSON object based on a given section path and key.
        /// </summary>
        /// <typeparam name="T">The type of the value to be set.</typeparam>
        /// <param name="sectionPathKey">The section path and key in the format "section1:section2:key". 
        /// This will navigate through the JSON object to find the correct section.</param>
        /// <param name="jsonObj">The JSON object to be updated.</param>
        /// <param name="value">The new value to be set for the specified key.</param>
        private static void SetValueRecursively<T>(string sectionPathKey, dynamic jsonObj, T value)
        {
            // split the string at the first ':' character
            var remainingSections = sectionPathKey.Split(":", 2);

            var currentSection = remainingSections[0];
            if (remainingSections.Length > 1)
            {
                // continue with the process, moving down the tree
                var nextSection = remainingSections[1];
                SetValueRecursively(nextSection, jsonObj[currentSection], value);
            }
            else
            {
                // we've got to the end of the tree, set the value
                jsonObj[currentSection] = value;
            }
        }
    }
}