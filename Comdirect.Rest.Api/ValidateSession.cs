namespace Comdirect.Rest.Api
{
    /// <summary>
    /// Represents a validated session with additional information.
    /// </summary>
    public class ValidateSession
    {
        /// <summary>
        /// Unique identifier of the session.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Type of the session.
        /// </summary>
        public string typ { get; set; }

        /// <summary>
        /// Array of available types for the session.
        /// </summary>
        public string[] availableTypes { get; set; }

        /// <summary>
        /// Link associated with the session.
        /// </summary>
        public Link link { get; set; }
    }

    /// <summary>
    /// Represents a hypermedia link.
    /// </summary>
    public class Link
    {
        /// <summary>
        /// The target URI of the link.
        /// </summary>
        public string href { get; set; }

        /// <summary>
        /// The relationship of the link to the context.
        /// </summary>
        public string rel { get; set; }

        /// <summary>
        /// The HTTP method to use when following the link.
        /// </summary>
        public string method { get; set; }
    }

}