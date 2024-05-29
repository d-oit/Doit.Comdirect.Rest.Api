using Comdirect.Auth.CSharp;
using Comdirect.Rest.Api;
using Microsoft.Extensions.Configuration;
using Moq;
using System;
using System.Net;

namespace TestProject
{
    public class UnitTestSession
    {
        private ComdirectCredentials ComdirectCredentials = null;
        public UnitTestSession()
        {

            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<UnitTestSession>().Build();

            var section = configuration.GetSection("ComdirectCredentials");

            ComdirectCredentials = section.Get<ComdirectCredentials>();

        }

        [Fact]
        public async Task GetSessionStatusAsync_EmptySessionsList_ThrowsException()
        {
            // Arrange
            var mockHttpClient = new Mock<HttpClient>();
            var authClient = new AuthClient(mockHttpClient.Object, ComdirectCredentials);
            var accessToken = "validAccessToken";

            // Mock the HTTP response
            var httpResponseMessage = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("[]")
            };
            mockHttpClient.Setup(httpClient => httpClient.SendAsync(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()))
               .ReturnsAsync(httpResponseMessage);

            // Act and Assert
            var exception = await Assert.ThrowsAsync<ApplicationException>(async () => await authClient.GetSessionStatusAsync(accessToken));
            Assert.Equal("Could not generate token! Status Code: OK", exception.Message);
        }

        [Fact]
        public async Task GetSessionStatusAsync_NullSessionsList_ThrowsException()
        {
            // Arrange
            var mockHttpClient = new Mock<HttpClient>();
            var authClient = new AuthClient(mockHttpClient.Object, ComdirectCredentials);
            var accessToken = "validAccessToken";

            // Mock the HTTP response
            var httpResponseMessage = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("null")
            };
            mockHttpClient.Setup(httpClient => httpClient.SendAsync(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()))
               .ReturnsAsync(httpResponseMessage);

            // Act and Assert
            var exception = await Assert.ThrowsAsync<ApplicationException>(async () => await authClient.GetSessionStatusAsync(accessToken));
            Assert.Equal("Could not generate token! Status Code: OK", exception.Message);
        }

        [Fact]
        public async Task GetSessionStatusAsync_ValidSessionsList_ReturnsFirstSession()
        {
            // Arrange
            var mockHttpClient = new Mock<HttpClient>();
            var authClient = new AuthClient(mockHttpClient.Object, ComdirectCredentials);
            var accessToken = "validAccessToken";

            // Mock the HTTP response
            var httpResponseMessage = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("[{\"identifier\": \"session1\"}, {\"identifier\": \"session2\"}]")
            };
            mockHttpClient.Setup(httpClient => httpClient.SendAsync(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()))
               .ReturnsAsync(httpResponseMessage);

            // Act
            var session = await authClient.GetSessionStatusAsync(accessToken);

            // Assert
            Assert.Equal("session1", session.Identifier);
        }

        /// <summary>
        /// This method is used to get the status of a session based on the provided access token.
        /// </summary>
        /// <param name="accessToken">The access token to authenticate the request.</param>
        /// <returns>A Task that represents the asynchronous operation. The task result is the session status.</returns>
        /// <exception cref="ApplicationException">Thrown when the HTTP response status code is not OK or the sessions list is empty or null.</exception>
        [Fact]
        public async Task GetSessionStatusAsync_InvalidStatusCode_ThrowsException()
        {
            // Arrange
            // Mocking HttpClient for unit testing
            var mockHttpClient = new Mock<HttpClient>();

            // Creating AuthClient object with mocked HttpClient and ComdirectCredentials
            var authClient = new AuthClient(mockHttpClient.Object, ComdirectCredentials);

            // Valid access token
            var accessToken = "validAccessToken";

            // Mocking HTTP response with InternalServerError status code
            var httpResponseMessage = new HttpResponseMessage(HttpStatusCode.InternalServerError);

            // Setting up the mock HttpClient to return the mocked HTTP response
            mockHttpClient.Setup(httpClient => httpClient.SendAsync(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()))
               .ReturnsAsync(httpResponseMessage);

            // Act and Assert
            // Asserting that the method throws ApplicationException with the expected error message when the HTTP response status code is not OK
            var exception = await Assert.ThrowsAsync<ApplicationException>(async () => await authClient.GetSessionStatusAsync(accessToken));
            Assert.Equal("Could not generate token! Status Code: InternalServerError", exception.Message);
        }
    }
}