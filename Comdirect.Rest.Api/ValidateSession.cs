namespace Comdirect.Rest.Api
{
    public class ValidateSession
    {
        public string id { get; set; }
        public string typ { get; set; }
        public string[] availableTypes { get; set; }
        public Link link { get; set; }
    }

    public class Link
    {
        public string href { get; set; }
        public string rel { get; set; }
        public string method { get; set; }
        public Type type { get; set; }
    }

    public class Type
    {
        public string mimeType { get; set; }
        public string charset { get; set; }
    }

}
