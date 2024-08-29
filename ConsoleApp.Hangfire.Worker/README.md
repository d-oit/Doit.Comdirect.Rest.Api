# ConsoleApp.Hangfire.Worker

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
5. Manage user secrets for the project with your comdirect credentials. Define in the appsettings.json / secrets.json file:
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
6. After a successful authentication the credentials saved in the **appsettings.json** file:
```json
 "ComdirectSavedSession": {
    "SessionId": null,
    "RequestId": null,
    "RefreshToken": null,
    "LastSessionDateTime": null,
    "ExpiresInSeconds": null
  }
``` 

### Hangfire

The sample use [Hangfire.InMemory](https://github.com/HangfireIO/Hangfire.InMemory) for testing only. 
Use a persistent storage like SQL Server or Redis for production.

### Logging

**Serilog**

The sample use **Serilog** to log messages configured in the **appsettings.json**

### Read this before start the application

**Use api carefully!**

#### comdirect API doc 

> 2.3 Anlage Validierung einer Session-TAN
> POST URL-Präfix/session/clients/{clientId}/v1/sessions/{sessionId}/validate
> Beschreibung: Für das nun bekannte Session-Objekt wird in diesem Schritt eine TAN-Challenge
> angefordert.

> [!CAUTION]
> Das Abrufen von **fünf** TAN-Challenges ohne zwischenzeitliche Entwertung einer korrekten TAN führt zur 
> **Sperrung des Onlinebanking-Zugangs**

## Links

- [comdirect API](https://www.comdirect.de/cms/kontakt-zugaenge-api.html)
- [Issues](https://github.com/d-oit/Doit.Comdirect.Rest.Api/issues)
- [Discussion](https://github.com/d-oit/Doit.Comdirect.Rest.Api/discussions)
- [API Documentation](https://github.com/d-oit/Doit.Comdirect.Rest.Api/blob/master/ConsoleApp.Hangfire.Worker/docs/DoitComdirectWorkerAPI.md)

## License

[MIT](LICENSE).
