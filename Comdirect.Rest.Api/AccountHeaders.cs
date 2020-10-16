using Newtonsoft.Json;

namespace Comdirect.Rest.Api
{
    public class AccountHeaders
    {
        public AccountHeaders(string sessionId, string requestId, string accessToken)
        {
            var httpRequestInfo = new { clientRequestId = new { sessionId = sessionId, requestId = requestId } };
            var serializedHttpRequestInfo = JsonConvert.SerializeObject(httpRequestInfo);

            RequestInfo = serializedHttpRequestInfo;

            Authorization = accessToken;
        }

        public string Accept { get; set; } = "application/json";
        public string Authorization { get; set; }

        [JsonProperty("x-http-request-info")]
        public string RequestInfo { get; set; } // {"clientRequestId":{"sessionId":"{{session_id}}","requestId":"{{request_id}}"}};

        [JsonProperty("Content-Type")]
        public string ContentType { get; set; } = "application/json";
    }
}