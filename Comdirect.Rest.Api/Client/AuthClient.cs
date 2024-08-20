using Comdirect.Auth.CSharp;
using Comdirect.Rest.Api.Comdirect;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Comdirect.Rest.Api
{
    /// <summary>
    /// The auth client.
    /// </summary>
    public class AuthClient : ComdirectClient
    {
        private ComdirectCredentials _comdirectCredentials;

        public HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// Gets or sets the request id.
        /// </summary>
        public string RequestId { get; set; } = GenerateDigits(9);

        /// <summary>
        /// Gets or sets the session id.
        /// </summary>
        public string SessionId { get; set; } = Guid.NewGuid().ToString("N").ToLower();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthClient"/> class.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance to be used for making HTTP requests.</param>
        /// <param name="comdirectCredentials">The ComdirectCredentials object containing the client id, client secret, username, and pin.</param>
        public AuthClient(HttpClient httpClient, ComdirectCredentials comdirectCredentials) : base(httpClient)
        {
            // Assign the provided HttpClient instance to the _httpClient field
            _httpClient = httpClient;

            // Assign the provided ComdirectCredentials instance to the _comdirectCredentials field
            _comdirectCredentials = comdirectCredentials;
        }

        /// <summary>
        /// Activates the session tan async.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        /// <param name="sessionUUID">The session u u i d.</param>
        /// <param name="challengeId">The challenge id.</param>
        /// <returns>A Task.</returns>
        public async Task<bool> ActivateSessionTanAsync(string accessToken, string sessionUUID, string challengeId)
        {
            var client = new RestClient($"{BaseUrl}/session/clients/user/v1/sessions/{sessionUUID}");
            var request = new RestRequest();
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", $"Bearer {accessToken}");
            SetRequestSessionInfo(request);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("x-once-authentication-info", "{\"id\": " + challengeId + "}");
            request.AddHeader("x-once-authentication", "000000");
            SetBody(sessionUUID, request);
            var response = await client.ExecuteAsync(request, Method.Patch);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieves the user's session status asynchronously.
        /// </summary>
        /// <param name="accessToken">The access token to authenticate the request.</param>
        /// <returns>A Task that represents the asynchronous operation. The task result is the Session object representing the user's session status.</returns>
        /// <exception cref="ApplicationException">Thrown when the request to the Comdirect API fails or when the status code is not OK.</exception>
        public async Task<Session> GetSessionStatusAsync(string accessToken)
        {
            // Initialize a new RestClient with the base URL for session management
            var client = new RestClient($"{BaseUrl}/session/clients/user/v1/sessions");

            // Create a new RestRequest
            var request = new RestRequest();

            // Add headers to the request
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", $"Bearer {accessToken}");
            SetRequestSessionInfo(request);
            request.AddHeader("Content-Type", "application/json");

            // Execute the request asynchronously
            var response = await client.ExecuteAsync(request, Method.Get);

            // Check the response status code
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                // If the status code is not OK, throw an exception
                throw new ApplicationException("Could not generate token! Status Code: " + response.StatusCode);
            }

            // Deserialize the response content into a list of Session objects
            var sessionsResults = JsonConvert.DeserializeObject<List<Session>>(response.Content);

            // Return the first session (assuming there is at least one session)
            return sessionsResults[0];
        }

        /// <summary>
        /// This method retrieves an access token and validates the user's session.
        /// </summary>
        /// <returns>A Task that represents the asynchronous operation. The task result is the ValidateSessionAsync object.</returns>
        public async Task<ValidateSession> GetTokenAndValidateSessionAsync()
        {
            // Retrieve an access token
            var token = await GetTokenAsync();

            // Retrieve the user's session status
            var session = await GetSessionStatusAsync(token.access_token);

            // Validate the user's session
            var validateSessionStatus = await PostValidateSessionStatusAsync(token.access_token, session.Identifier);

            // Return the validation result
            return validateSessionStatus;
        }

        /// <summary>
        /// Gets the token async.
        /// </summary>
        /// <returns>A Task.</returns>
        /// <summary>
        /// Gets the token async.
        /// This method is used to retrieve an access token from the Comdirect API.
        /// </summary>
        /// <returns>A Task that represents the asynchronous operation. The task result is the ComdirectOAuthToken object.</returns>
        /// <exception cref="ApplicationException">Thrown when the request to the Comdirect API fails or when the client id/secrets are not valid.</exception>
        public async Task<ComdirectOAuthToken> GetTokenAsync()
        {
            // Initialize a new RestClient with the base URL for token generation
            var client = new RestClient("https://api.comdirect.de/oauth/token");

            // Create a new RestRequest
            var request = new RestRequest();

            // Add headers to the request
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");

            // Add parameters to the request
            request.AddParameter("client_id", _comdirectCredentials.ClientId);
            request.AddParameter("client_secret", _comdirectCredentials.ClientSecret);
            request.AddParameter("grant_type", "password");
            request.AddParameter("username", _comdirectCredentials.Username);
            request.AddParameter("password", _comdirectCredentials.Pin);

            // Execute the request asynchronously
            var response = await client.ExecuteAsync(request, Method.Post);

            // Check the response status code
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                // If the status code is not OK, throw an exception
                throw new ApplicationException("Could not get token - check client id/secrets configuration! Status Code: " + response.StatusCode);
            }

            // Deserialize the response content into a ComdirectOAuthToken object
            return JsonConvert.DeserializeObject<ComdirectOAuthToken>(response.Content);
        }

        /// <summary>
        /// Posts the secondary flow async.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        /// <returns>A Task.</returns>
        public async Task<ComdirectOAuthToken> PostSecondaryFlowAsync(string accessToken)
        {
            var client = new RestClient("https://api.comdirect.de/oauth/token");
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");
            request.AddParameter("client_id", _comdirectCredentials.ClientId);
            request.AddParameter("client_secret", _comdirectCredentials.ClientSecret);
            request.AddParameter("grant_type", "cd_secondary");
            request.AddParameter("token", accessToken);
            var response = await client.ExecuteAsync(request, Method.Post);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new ApplicationException("Could not get token - check client id/secrets configuration! Status Code: " + response.StatusCode);
            }

            var token = JsonConvert.DeserializeObject<ComdirectOAuthToken>(response.Content);

            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(token.token_type, token.access_token);
            _httpClient.DefaultRequestHeaders.Add("x-http-request-info", GetHttpRequestInfoValue());
            return token;
        }

        /// <summary>
        /// Posts the validate session status async.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        /// <param name="sessionUUID">The session u u i d.</param>
        /// <returns>A Task.</returns>
        public async Task<ValidateSession> PostValidateSessionStatusAsync(string accessToken, string sessionUUID)
        {
            var client = new RestClient($"{BaseUrl}/session/clients/user/v1/sessions/{sessionUUID}/validate");
            var request = new RestRequest();

            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", $"Bearer {accessToken}");
            SetRequestSessionInfo(request);
            request.AddHeader("Content-Type", "application/json");
            SetBody(sessionUUID, request);
            var response = await client.ExecuteAsync(request, Method.Post);

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

        /// <summary>
        /// Performs the refresh token flow asynchronously.
        /// This method is used to refresh an access token using a refresh token.
        /// </summary>
        /// <param name="comdirectOAuthToken">The ComdirectOAuthToken object containing the refresh token.</param>
        /// <returns>A Task that represents the asynchronous operation. The task result is a boolean value indicating whether the refresh flow was successful.</returns>
        public async Task<bool> RefreshTokenFlowAsync(ComdirectOAuthToken comdirectOAuthToken)
        {
            // Initialize a new RestClient with the base URL for token generation
            var client = new RestClient("https://api.comdirect.de");

            // Create a new RestRequest for the POST request to the token endpoint
            var request = new RestRequest("/oauth/token", Method.Post);

            // Add headers to the request
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");

            // Add parameters to the request
            request.AddParameter("client_id", _comdirectCredentials.ClientId);
            request.AddParameter("client_secret", _comdirectCredentials.ClientSecret);
            request.AddParameter("grant_type", "refresh_token");
            request.AddParameter("refresh_token", comdirectOAuthToken.refresh_token);

            // Execute the request asynchronously
            RestResponse response = await client.ExecuteAsync(request);

            var result = JsonConvert.DeserializeObject<ComdirectOAuthToken>(response.Content);

            comdirectOAuthToken.refresh_token = result.refresh_token;
            comdirectOAuthToken.access_token = result.access_token;

            // Check the response status code
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // If the status code is NoContent, the refresh flow was successful
                return true;
            }

            // If the status code is not NoContent, the refresh flow failed
            return false;
        }

        /// <summary>
        /// Revokes the token async.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        /// <returns>A Task.</returns>
        public async Task<bool> RevokeTokenAsync(string accessToken)
        {
            var client = new RestClient("https://api.comdirect.de/oauth/revoke");
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", $"Bearer {accessToken}");
            request.AddParameter("application/x-www-form-urlencoded", string.Empty, ParameterType.RequestBody);
            var response = await client.ExecuteAsync(request, Method.Delete);

            if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sets the request session info.
        /// This method is used to add a custom header to the RestRequest object.
        /// The header contains session and request IDs in a serialized JSON format.
        /// </summary>
        /// <param name="request">The RestRequest object to which the header will be added.</param>
        public void SetRequestSessionInfo(RestRequest request)
        {
            // Generate the serialized JSON string containing session and request IDs
            string serializedHttpRequestInfo = GetHttpRequestInfoValue();

            // Add the custom header to the RestRequest object
            request.AddHeader("x-http-request-info", serializedHttpRequestInfo);
        }

        /// <summary>
        /// Generates the digits.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <returns>A string.</returns>
        private static string GenerateDigits(int length)
        {
            var rndDigits = new System.Text.StringBuilder().Insert(0, "0123456789", length).ToString().ToCharArray();
            return string.Join(string.Empty, rndDigits.OrderBy(o => Guid.NewGuid()).Take(length));
        }

        /// <summary>
        /// Gets the HTTP request info value.
        /// This method is used to create a JSON string that contains session and request IDs.
        /// This string is then used as a header in HTTP requests to Comdirect API.
        /// </summary>
        /// <returns>A string containing the serialized HTTP request info.</returns>
        private string GetHttpRequestInfoValue()
        {
            // Define an anonymous type to hold the session and request IDs
            var httpRequestInfo = new { clientRequestId = new { sessionId = SessionId, requestId = RequestId } };

            // Serialize the anonymous type to a JSON string
            var serializedHttpRequestInfo = JsonConvert.SerializeObject(httpRequestInfo);

            // Return the serialized JSON string
            return serializedHttpRequestInfo;
        }

        /// <summary>
        /// Sets the body.
        /// </summary>
        /// <param name="sessionUUID">The session u u i d.</param>
        /// <param name="request">The request.</param>
        private static void SetBody(string sessionUUID, RestRequest request)
        {
            var parameter = "{\r\n\"identifier\": \"" + sessionUUID + "\",\r\n\"sessionTanActive\": true,\r\n\"activated2FA\": true\r\n}";
            request.AddParameter("application/json", parameter, ParameterType.RequestBody);
        }
    }
}