using Comdirect.Auth.CSharp;
using Comdirect.Rest.Api;
using Microsoft.Extensions.Configuration;
using Moq;
using System.Net;

namespace TestProject
{
    public class UnitTestAuthClient
    {
        private ComdirectCredentials ComdirectCredentials;

        public UnitTestAuthClient()
        {
            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<UnitTestAuthClient>()
                .Build();

            // get credentials from user.secrets -> see appsettings.json Comdirect.Rest.Api.csproj
            var section = configuration.GetSection("ComdirectCredentials");
            ComdirectCredentials = section.Get<ComdirectCredentials>();
        }


        /// This method is used to get the status of a session based on the provided access token.
        /// </summary>
        /// <param name="accessToken">The access token to authenticate the request.</param>
        /// <returns>A Task that represents the asynchronous operation. The task result is the session status.</returns>
        /// <exception cref="ApplicationException">Thrown when the HTTP response status code is not OK or the sessions list is empty or null.</exception>
        [Fact]
        public async Task GetSessionStatusAsync()
        {
            // Arrange
            // Mocking HttpClient for unit testing
            var mockHttpClient = new Mock<HttpClient>();

            // Creating AuthClient object with mocked HttpClient and ComdirectCredentials
            var authClient = new AuthClient(mockHttpClient.Object, ComdirectCredentials);

            var token = await authClient.GetTokenAsync();
            var accessToken = token.access_token;

            // Mocking HTTP response with InternalServerError status code
            var httpResponseMessage = new HttpResponseMessage(HttpStatusCode.InternalServerError);

            // Setting up the mock HttpClient to return the mocked HTTP response
            mockHttpClient.Setup(
                httpClient => httpClient.SendAsync(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()))
               .ReturnsAsync(httpResponseMessage);

            // Act and Assert
            var session = await authClient.GetSessionStatusAsync(accessToken);
            Assert.NotNull(session);
        }
    }
}