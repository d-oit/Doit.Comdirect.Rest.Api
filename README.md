[![Build and Test .NET 8 release branch](https://github.com/d-oit/Doit.Comdirect.Rest.Api/actions/workflows/dotnetBuildRelease.yml/badge.svg?branch=release)](https://github.com/d-oit/Doit.Comdirect.Rest.Api/actions/workflows/dotnetBuildRelease.yml)

# Doit.Comdirect.Rest.Api
C# .NET Rest API for comdirect

Get your oAuth client credentials before you start:
https://kunde.comdirect.de/itx/oauth/privatkunden?execution=e3s1

## Requirements

1. Download the latest swagger json from https://kunde.comdirect.de/cms/media/comdirect_rest_api_swagger.json
2. Change the comdirect type "cd_secondary" to  "password
    ```json
    "CdSecondary": {
      "type": "oauth2",
      "tokenUrl": "https://api.comdirect.de/oauth/token",
      "flow": "cd_secondary", >>  **"flow": "password"**,
      ```
3. Install the Visual Studio extension to generate the C# Client: https://github.com/unchase/Unchase.OpenAPI.Connectedservice      
4. Generate the client [![comdirect-unchase-openapi.png](https://i.postimg.cc/bvjFpBWf/comdirect-unchase-openapi.png)](https://postimg.cc/75mNNmqK)
5. Manage user secrets for the project with your comdirect credentials. Define in the appsettings.json 
```json
{
  "ComdirectCredentials": {
    "ClientId": null,
    "ClientSecret": null,
    "Pin": null,
    "Username": null
  }
}
```

## Test the flow

Start the Console project
https://github.com/do-it-ger/Comdirect.Rest.Api/blob/master/Console.ComdirectApi/Program.cs

Active the login with the comdirect photoTan App https://kunde.comdirect.de/cms/sicherheit-pin-tan.html#mobiletan 

**Use api carefully!**

**comdirect API doc:**

> 2.3 Anlage Validierung einer Session-TAN
> POST URL-Präfix/session/clients/{clientId}/v1/sessions/{sessionId}/validate
> Beschreibung: Für das nun bekannte Session-Objekt wird in diesem Schritt eine TAN-Challenge
> angefordert.

> [!CAUTION]

> Das Abrufen von **fünf** TAN-Challenges ohne zwischenzeitliche Entwertung einer korrekten TAN führt zur 
> **Sperrung des Onlinebanking-Zugangs**

## Links

* Web site & Documentation: https://www.comdirect.de/cms/kontakt-zugaenge-api.html

## License

[MIT](LICENSE).
