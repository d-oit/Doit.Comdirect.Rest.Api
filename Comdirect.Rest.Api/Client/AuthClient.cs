using Comdirect.Auth.CSharp;
using Comdirect.Rest.Api.Comdirect;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Comdirect.Rest.Api
{
    public class AuthClient : ComdirectClient
    {
        public string SessionId { get; set; } = Guid.NewGuid().ToString("N").ToLower(); 
        public string RequestId { get; set; } = GenerateDigits(9);

        public HttpClient _httpClient;
        private readonly ComdirectCredentials _comdirectCredentials;

        public AuthClient(HttpClient httpClient, ComdirectCredentials comdirectCredentials) : base(httpClient)
        {
            _httpClient = httpClient;
            this._comdirectCredentials = comdirectCredentials;
        }

        public ValidateSession GetTokenAndValidateSession()
        {
            var token = GetToken();
            var session = GetSessionStatus(token.access_token);
            var validateSessionStatus = PostValidateSessionStatus(token.access_token, session.Identifier);
            return validateSessionStatus;
        }
        
        public void SetRequestSessionInfo(RestRequest request)
        {
            string serializedHttpRequestInfo = GetHttpRequestInfoValue();
            request.AddHeader("x-http-request-info", serializedHttpRequestInfo);
        }

        private string GetHttpRequestInfoValue()
        {
            var httpRequestInfo = new { clientRequestId = new { sessionId = SessionId, requestId = RequestId } };
            var serializedHttpRequestInfo = JsonConvert.SerializeObject(httpRequestInfo);
            return serializedHttpRequestInfo;
        }

        public ComdirectOAuthToken GetToken()
        {
            var client = new RestClient("https://api.comdirect.de/oauth/token");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");
            request.AddParameter("client_id", _comdirectCredentials.ClientId);
            request.AddParameter("client_secret", _comdirectCredentials.ClientSecret);
            request.AddParameter("grant_type", "password");
            request.AddParameter("username", _comdirectCredentials.Username);
            request.AddParameter("password", _comdirectCredentials.Pin);
            IRestResponse response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new ApplicationException("Could not get token - check client id/secrets configuration! Status Code: " + response.StatusCode);
            }

            return JsonConvert.DeserializeObject<ComdirectOAuthToken>(response.Content);
        }

        public Session GetSessionStatus(string accessToken)
        {
            var client = new RestClient($"{BaseUrl}/session/clients/user/v1/sessions");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", $"Bearer {accessToken}");
            SetRequestSessionInfo(request);
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new ApplicationException("Could not generate token! Status Code: " + response.StatusCode);
            }

            var sessionsResults = JsonConvert.DeserializeObject<List<Session>>(response.Content);
            return sessionsResults[0];
        }

        public ValidateSession PostValidateSessionStatus(string accessToken, string sessionUUID)
        {
            var client = new RestClient($"{BaseUrl}/session/clients/user/v1/sessions/{sessionUUID}/validate");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", $"Bearer {accessToken}");
            SetRequestSessionInfo(request);
            request.AddHeader("Content-Type", "application/json");
            SetBody(sessionUUID, request);
            IRestResponse response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.Created)
            {
                throw new ApplicationException("Post validate session failed!");
            }

            var responseAuthHeader = response.Headers.FirstOrDefault(x => x.Name == "x-once-authentication-info");
            if (responseAuthHeader.Value != null)
            {
                var comdirectValidateSessionResponse = JsonConvert.DeserializeObject<ValidateSession>(responseAuthHeader.Value.ToString());
                return comdirectValidateSessionResponse;
            }

            throw new ApplicationException("Post validate session failed!");
        }

        private static void SetBody(string sessionUUID, RestRequest request)
        {
            var parameter = "{\r\n        \"identifier\": \"" + sessionUUID + "\",\r\n        \"sessionTanActive\": true,\r\n        \"activated2FA\": true\r\n}";

            request.AddParameter("application/json", parameter, ParameterType.RequestBody);
        }

        public bool ActivateSessionTan(string accessToken, string sessionUUID, string challangeId)
        {
            var client = new RestClient($"{BaseUrl}/session/clients/user/v1/sessions/{sessionUUID}");
            client.Timeout = -1;
            var request = new RestRequest(Method.PATCH);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", $"Bearer {accessToken}");
            SetRequestSessionInfo(request);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("x-once-authentication-info", "{\"id\": " + challangeId + "}");
            request.AddHeader("x-once-authentication", "000000");
            SetBody(sessionUUID, request);
            IRestResponse response = client.Execute(request);
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            return false;
        }

        public ComdirectOAuthToken PostSecondaryFlow(string accessToken)
        {
            var client = new RestClient("https://api.comdirect.de/oauth/token");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");
            request.AddParameter("client_id", _comdirectCredentials.ClientId);
            request.AddParameter("client_secret", _comdirectCredentials.ClientSecret);
            request.AddParameter("grant_type", "cd_secondary");
            request.AddParameter("token", accessToken);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new ApplicationException("Could not get token - check client id/secrets configuration! Status Code: " + response.StatusCode);
            }

            var token = JsonConvert.DeserializeObject<ComdirectOAuthToken>(response.Content);

            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(token.token_type, token.access_token);
            _httpClient.DefaultRequestHeaders.Add("x-http-request-info", GetHttpRequestInfoValue());
            return token;
        }

        public bool RevokeToken(string accessToken)
        {
            var client = new RestClient("https://api.comdirect.de/oauth/revoke");
            client.Timeout = -1;
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", $"Bearer {accessToken}");
            request.AddParameter("application/x-www-form-urlencoded", "", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            if(response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return true;
            }
            return false;
        }

        private static string GenerateDigits(int length)
        {
            var rndDigits = new System.Text.StringBuilder().Insert(0, "0123456789", length).ToString().ToCharArray();
            return string.Join("", rndDigits.OrderBy(o => Guid.NewGuid()).Take(length));
        }
    }
}
