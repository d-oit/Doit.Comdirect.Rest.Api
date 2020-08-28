using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectComdirectRestApi
{
    [TestClass]
    public class UnitTestComdirectApi
    {
        [TestMethod]
        public void TestMethodToken()
        {
            var getTokenResponse = GetToken();
            var getSessionStatusResponse = GetSessionStatus(getTokenResponse.AccessToken);
            var validateSessionResponse = await ValidateSession(getTokenResponse.AccessToken, getSessionStatusResponse.Identifier);
        }
    }
}
