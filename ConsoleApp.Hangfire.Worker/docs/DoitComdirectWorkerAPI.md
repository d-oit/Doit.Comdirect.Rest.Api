<a name='assembly'></a>
# ConsoleApp.Hangfire.Worker

## Contents

- [ComdirectApiHostedService](#T-ConsoleSample-ComdirectApiHostedService 'ConsoleSample.ComdirectApiHostedService')
  - [#ctor(backgroundJobs,recurringJobs,logger,configuration)](#M-ConsoleSample-ComdirectApiHostedService-#ctor-Hangfire-IBackgroundJobClient,Hangfire-IRecurringJobManager,Microsoft-Extensions-Logging-ILogger{ConsoleSample-ComdirectApiHostedService},Microsoft-Extensions-Configuration-IConfiguration- 'ConsoleSample.ComdirectApiHostedService.#ctor(Hangfire.IBackgroundJobClient,Hangfire.IRecurringJobManager,Microsoft.Extensions.Logging.ILogger{ConsoleSample.ComdirectApiHostedService},Microsoft.Extensions.Configuration.IConfiguration)')
  - [AuthFlow(authClient,token)](#M-ConsoleSample-ComdirectApiHostedService-AuthFlow-Comdirect-Rest-Api-AuthClient,Comdirect-Rest-Api-ComdirectOAuthToken- 'ConsoleSample.ComdirectApiHostedService.AuthFlow(Comdirect.Rest.Api.AuthClient,Comdirect.Rest.Api.ComdirectOAuthToken)')
  - [CheckReuseTan()](#M-ConsoleSample-ComdirectApiHostedService-CheckReuseTan-Microsoft-Extensions-Configuration-IConfiguration- 'ConsoleSample.ComdirectApiHostedService.CheckReuseTan(Microsoft.Extensions.Configuration.IConfiguration)')
  - [ComdirectSession()](#M-ConsoleSample-ComdirectApiHostedService-ComdirectSession 'ConsoleSample.ComdirectApiHostedService.ComdirectSession')
  - [ExecuteAsync(stoppingToken)](#M-ConsoleSample-ComdirectApiHostedService-ExecuteAsync-System-Threading-CancellationToken- 'ConsoleSample.ComdirectApiHostedService.ExecuteAsync(System.Threading.CancellationToken)')
  - [GetComdirecAccountBalances(client)](#M-ConsoleSample-ComdirectApiHostedService-GetComdirecAccountBalances-Comdirect-Rest-Api-AuthClient- 'ConsoleSample.ComdirectApiHostedService.GetComdirecAccountBalances(Comdirect.Rest.Api.AuthClient)')
  - [RefreshTan(authClient)](#M-ConsoleSample-ComdirectApiHostedService-RefreshTan-Comdirect-Rest-Api-AuthClient- 'ConsoleSample.ComdirectApiHostedService.RefreshTan(Comdirect.Rest.Api.AuthClient)')
  - [SaveSessionApplication(authClient,token)](#M-ConsoleSample-ComdirectApiHostedService-SaveSessionApplication-Comdirect-Rest-Api-AuthClient,Comdirect-Rest-Api-ComdirectOAuthToken- 'ConsoleSample.ComdirectApiHostedService.SaveSessionApplication(Comdirect.Rest.Api.AuthClient,Comdirect.Rest.Api.ComdirectOAuthToken)')
  - [StartAsync(cancellationToken)](#M-ConsoleSample-ComdirectApiHostedService-StartAsync-System-Threading-CancellationToken- 'ConsoleSample.ComdirectApiHostedService.StartAsync(System.Threading.CancellationToken)')
  - [StopAsync(cancellationToken)](#M-ConsoleSample-ComdirectApiHostedService-StopAsync-System-Threading-CancellationToken- 'ConsoleSample.ComdirectApiHostedService.StopAsync(System.Threading.CancellationToken)')
- [SettingsHelpers](#T-ConsoleApp-Hangfire-Worker-Helper-SettingsHelpers 'ConsoleApp.Hangfire.Worker.Helper.SettingsHelpers')
  - [AddOrUpdateAppSetting\`\`1(sectionPathKey,value)](#M-ConsoleApp-Hangfire-Worker-Helper-SettingsHelpers-AddOrUpdateAppSetting``1-System-String,``0- 'ConsoleApp.Hangfire.Worker.Helper.SettingsHelpers.AddOrUpdateAppSetting``1(System.String,``0)')
  - [SetValueRecursively\`\`1(sectionPathKey,jsonObj,value)](#M-ConsoleApp-Hangfire-Worker-Helper-SettingsHelpers-SetValueRecursively``1-System-String,System-Object,``0- 'ConsoleApp.Hangfire.Worker.Helper.SettingsHelpers.SetValueRecursively``1(System.String,System.Object,``0)')
- [Startup](#T-ConsoleSample-Startup 'ConsoleSample.Startup')
  - [Configure(app,env)](#M-ConsoleSample-Startup-Configure-Microsoft-AspNetCore-Builder-IApplicationBuilder,Microsoft-AspNetCore-Hosting-IWebHostEnvironment- 'ConsoleSample.Startup.Configure(Microsoft.AspNetCore.Builder.IApplicationBuilder,Microsoft.AspNetCore.Hosting.IWebHostEnvironment)')
  - [ConfigureServices(services)](#M-ConsoleSample-Startup-ConfigureServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'ConsoleSample.Startup.ConfigureServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')

<a name='T-ConsoleSample-ComdirectApiHostedService'></a>
## ComdirectApiHostedService `type`

##### Namespace

ConsoleSample

<a name='M-ConsoleSample-ComdirectApiHostedService-#ctor-Hangfire-IBackgroundJobClient,Hangfire-IRecurringJobManager,Microsoft-Extensions-Logging-ILogger{ConsoleSample-ComdirectApiHostedService},Microsoft-Extensions-Configuration-IConfiguration-'></a>
### #ctor(backgroundJobs,recurringJobs,logger,configuration) `constructor`

##### Summary

Initializes a new instance of the [ComdirectApiHostedService](#T-ConsoleSample-ComdirectApiHostedService 'ConsoleSample.ComdirectApiHostedService') class.
This class is responsible for managing the background service that interacts with the Comdirect API.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| backgroundJobs | [Hangfire.IBackgroundJobClient](#T-Hangfire-IBackgroundJobClient 'Hangfire.IBackgroundJobClient') | An instance of [IBackgroundJobClient](#T-Hangfire-IBackgroundJobClient 'Hangfire.IBackgroundJobClient') for managing background jobs. |
| recurringJobs | [Hangfire.IRecurringJobManager](#T-Hangfire-IRecurringJobManager 'Hangfire.IRecurringJobManager') | An instance of [IRecurringJobManager](#T-Hangfire-IRecurringJobManager 'Hangfire.IRecurringJobManager') for managing recurring jobs. |
| logger | [Microsoft.Extensions.Logging.ILogger{ConsoleSample.ComdirectApiHostedService}](#T-Microsoft-Extensions-Logging-ILogger{ConsoleSample-ComdirectApiHostedService} 'Microsoft.Extensions.Logging.ILogger{ConsoleSample.ComdirectApiHostedService}') | An instance of [ILogger\`1](#T-Microsoft-Extensions-Logging-ILogger`1 'Microsoft.Extensions.Logging.ILogger`1') for logging messages. |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | An instance of [IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') for accessing application settings. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when any of the required parameters are null. |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when the ComdirectCredentials configuration is missing in appsettings.json. |

<a name='M-ConsoleSample-ComdirectApiHostedService-AuthFlow-Comdirect-Rest-Api-AuthClient,Comdirect-Rest-Api-ComdirectOAuthToken-'></a>
### AuthFlow(authClient,token) `method`

##### Summary

Performs the secondary authentication flow for the Comdirect API. This method is responsible for obtaining a
valid access token and refresh token, and then saving the session details for future use.

##### Returns

An asynchronous Task that completes when the secondary authentication flow is completed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| authClient | [Comdirect.Rest.Api.AuthClient](#T-Comdirect-Rest-Api-AuthClient 'Comdirect.Rest.Api.AuthClient') | An instance of the AuthClient class, which provides methods for interacting with the Comdirect
authentication API. |
| token | [Comdirect.Rest.Api.ComdirectOAuthToken](#T-Comdirect-Rest-Api-ComdirectOAuthToken 'Comdirect.Rest.Api.ComdirectOAuthToken') | The ComdirectOAuthToken object containing the access token obtained during the initial authentication flow. |

<a name='M-ConsoleSample-ComdirectApiHostedService-CheckReuseTan-Microsoft-Extensions-Configuration-IConfiguration-'></a>
### CheckReuseTan() `method`

##### Summary

Checks if the saved TAN (Transaction Authentication Number) can be reused based on the session validity.

##### Returns

Returns true if the saved TAN can be reused, false otherwise.

##### Parameters

This method has no parameters.

<a name='M-ConsoleSample-ComdirectApiHostedService-ComdirectSession'></a>
### ComdirectSession() `method`

##### Summary

Initializes a new instance of the [AuthClient](#T-Comdirect-Rest-Api-AuthClient 'Comdirect.Rest.Api.AuthClient') class for interacting with the Comdirect
authentication API. This method handles the authentication flow, including obtaining a valid access token
and refresh token. If a saved TAN can be reused, it will be used to refresh the session. Otherwise, the user
will be prompted to enter a TAN.

##### Returns

An asynchronous Task that returns an instance of the [AuthClient](#T-Comdirect-Rest-Api-AuthClient 'Comdirect.Rest.Api.AuthClient') class, representing the
authenticated client.

##### Parameters

This method has no parameters.

<a name='M-ConsoleSample-ComdirectApiHostedService-ExecuteAsync-System-Threading-CancellationToken-'></a>
### ExecuteAsync(stoppingToken) `method`

##### Summary

This method is responsible for executing the main logic of the ComdirectApiHostedService. It continuously
retrieves account balances from the Comdirect API, logs the elapsed time, and waits for a specified delay
before the next run.

##### Returns

An asynchronous Task that completes when the execution is stopped or an exception is thrown.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stoppingToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A CancellationToken that indicates when the execution should be stopped. |

<a name='M-ConsoleSample-ComdirectApiHostedService-GetComdirecAccountBalances-Comdirect-Rest-Api-AuthClient-'></a>
### GetComdirecAccountBalances(client) `method`

##### Summary

Retrieves and displays the account balances for all Comdirect banking accounts.

##### Returns

An asynchronous Task that completes when the account balances have been retrieved and displayed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [Comdirect.Rest.Api.AuthClient](#T-Comdirect-Rest-Api-AuthClient 'Comdirect.Rest.Api.AuthClient') | An instance of the AuthClient class for interacting with the Comdirect authentication API. |

<a name='M-ConsoleSample-ComdirectApiHostedService-RefreshTan-Comdirect-Rest-Api-AuthClient-'></a>
### RefreshTan(authClient) `method`

##### Summary

Refreshes the TAN (Transaction Authentication Number) session using the saved values.

##### Returns

An asynchronous Task that completes when the TAN session refresh is completed. If the refresh token flow
fails, an exception is thrown.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| authClient | [Comdirect.Rest.Api.AuthClient](#T-Comdirect-Rest-Api-AuthClient 'Comdirect.Rest.Api.AuthClient') | An instance of the AuthClient class for interacting with the Comdirect authentication API. |

<a name='M-ConsoleSample-ComdirectApiHostedService-SaveSessionApplication-Comdirect-Rest-Api-AuthClient,Comdirect-Rest-Api-ComdirectOAuthToken-'></a>
### SaveSessionApplication(authClient,token) `method`

##### Summary

Saves the session details for future use by updating the application's settings.

```json
"ComdirectSavedSession": { "SessionId": null, "RequestId": null, "RefreshToken": null,
"LastSessionDateTime": null, "ExpiresInSeconds": null }
```

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| authClient | [Comdirect.Rest.Api.AuthClient](#T-Comdirect-Rest-Api-AuthClient 'Comdirect.Rest.Api.AuthClient') | An instance of the AuthClient class, which provides methods for interacting with the Comdirect
authentication API. |
| token | [Comdirect.Rest.Api.ComdirectOAuthToken](#T-Comdirect-Rest-Api-ComdirectOAuthToken 'Comdirect.Rest.Api.ComdirectOAuthToken') | The ComdirectOAuthToken object containing the access token obtained during the initial authentication flow. |

<a name='M-ConsoleSample-ComdirectApiHostedService-StartAsync-System-Threading-CancellationToken-'></a>
### StartAsync(cancellationToken) `method`

##### Summary

This method is responsible for starting the background service. It logs a message indicating that the
service is starting, initializes the Comdirect API client, and then calls the base implementation of
StartAsync.

##### Returns

An asynchronous Task that completes when the service has been started. If an exception occurs during the
initialization of the Comdirect API client, the exception is logged and rethrown.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A CancellationToken that indicates when the execution should be stopped. |

<a name='M-ConsoleSample-ComdirectApiHostedService-StopAsync-System-Threading-CancellationToken-'></a>
### StopAsync(cancellationToken) `method`

##### Summary

This method is responsible for stopping the background service. It logs a message indicating that the
service is stopping and then calls the base implementation of StopAsync.

##### Returns

An asynchronous Task that completes when the service has been stopped.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A CancellationToken that indicates when the execution should be stopped. |

<a name='T-ConsoleApp-Hangfire-Worker-Helper-SettingsHelpers'></a>
## SettingsHelpers `type`

##### Namespace

ConsoleApp.Hangfire.Worker.Helper

##### Summary

static class SettingsHelpers

<a name='M-ConsoleApp-Hangfire-Worker-Helper-SettingsHelpers-AddOrUpdateAppSetting``1-System-String,``0-'></a>
### AddOrUpdateAppSetting\`\`1(sectionPathKey,value) `method`

##### Summary

Updates or adds a new app setting in the 'appsettings.json' file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sectionPathKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The section path and key in the format "section1:section2:key". 
This will navigate through the JSON object to find the correct section. |
| value | [\`\`0](#T-``0 '``0') | The new value to be set for the specified key. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the value to be set. |

<a name='M-ConsoleApp-Hangfire-Worker-Helper-SettingsHelpers-SetValueRecursively``1-System-String,System-Object,``0-'></a>
### SetValueRecursively\`\`1(sectionPathKey,jsonObj,value) `method`

##### Summary

Recursively sets a value in a JSON object based on a given section path and key.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sectionPathKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The section path and key in the format "section1:section2:key". 
This will navigate through the JSON object to find the correct section. |
| jsonObj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The JSON object to be updated. |
| value | [\`\`0](#T-``0 '``0') | The new value to be set for the specified key. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the value to be set. |

<a name='T-ConsoleSample-Startup'></a>
## Startup `type`

##### Namespace

ConsoleSample

<a name='M-ConsoleSample-Startup-Configure-Microsoft-AspNetCore-Builder-IApplicationBuilder,Microsoft-AspNetCore-Hosting-IWebHostEnvironment-'></a>
### Configure(app,env) `method`

##### Summary

Configures the application and its request processing pipeline.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder') | The application builder. |
| env | [Microsoft.AspNetCore.Hosting.IWebHostEnvironment](#T-Microsoft-AspNetCore-Hosting-IWebHostEnvironment 'Microsoft.AspNetCore.Hosting.IWebHostEnvironment') | The web host environment. |

<a name='M-ConsoleSample-Startup-ConfigureServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### ConfigureServices(services) `method`

##### Summary

Configures the services for the application.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | The collection of services to configure. |
