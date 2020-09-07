# Comdirect.Rest.Api
C# .NET Standard Rest API for comdirect

## Requirements

1.) Download the latest swagger json from https://kunde.comdirect.de/cms/media/comdirect_rest_api_swagger.json
2.) Change the comdirect type "cd_secondary" to  "password
    "CdSecondary": {
      "type": "oauth2",
      "tokenUrl": "https://api.comdirect.de/oauth/token",
      "flow": "cd_secondary", >>  "flow": "password",
3.) Install the Visual Studio 2017/2019 extension to generate the C# Client: https://github.com/unchase/Unchase.OpenAPI.Connectedservice      
4.) Generate the client [![comdirect-unchase-openapi.png](https://i.postimg.cc/bvjFpBWf/comdirect-unchase-openapi.png)](https://postimg.cc/75mNNmqK)
5.) Manage user secrets for the project with your comdirect credentials. Define in the appsettings.json
{
  "ComdirectCredentials": {
    "ClientId": null,
    "ClientSecret": null,
    "Pin": null,
    "Username": null
  }
}

https://kunde.comdirect.de/itx/oauth/privatkunden?execution=e3s1

## Test the flow

Start the Console project
https://github.com/do-it-ger/Comdirect.Rest.Api/blob/master/Console.ComdirectApi/Program.cs

Active the login with the comdirect photoTan App https://kunde.comdirect.de/cms/sicherheit-pin-tan.html#mobiletan 
