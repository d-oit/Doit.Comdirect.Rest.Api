﻿using Comdirect.Auth.CSharp;
using Comdirect.Rest.Api;
using Comdirect.Rest.Api.Comdirect;
using Microsoft.Extensions.Configuration;
using SettingManager;
using System;
using System.IO;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ConsoleApp.ComdirectApi
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            await MainAsync(args);
        }

        static IConfigurationRoot _configurationRoot;
        static bool _isDevelopment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";
        static SecretsManager _secretsManager;
        private static async Task MainAsync(string[] args)
        {
            Console.WriteLine("Comdirect Rest Api!");

            // Config ComdirectCredentials appSecret before you start (see appsettings.json in the rest api project)
            // Get the OAuth ClientCredentials in your comdirect Account: Verwaltung > Entwicklerzugang
            // https://kunde.comdirect.de/itx/oauth/privatkunden?execution=e4s1
            // dotnet user-secrets set ComdirectCredentials:ClientId <your client secret>
            // dotnet user-secrets set ComdirectCredentials:ClientSecret <your client secret>
            // dotnet user-secrets set ComdirectCredentials:Pin <your pin>
            // dotnet user-secrets set ComdirectCredentials:Username <your username>


            // 2.3 Anlage Validierung einer Session-TAN
            // POST URL-Präfix / session / clients /{ clientId}/ v1 / sessions /{ sessionId}/ validate
            // Beschreibung: Für das nun bekannte Session - Objekt wird in diesem Schritt eine TAN-Challenge
            // angefordert.
            // Bitte beachten:
            // Das Abrufen von fünf TAN - Challenges ohne zwischenzeitliche Entwertung einer korrekten TAN führt zur
            // Sperrung des Onlinebanking - Zugangs
            _configurationRoot = new ConfigurationBuilder()
              .AddUserSecrets<Program>()
              .Build();

            _secretsManager = new SecretsManager(_configurationRoot);

            var section = _configurationRoot.GetSection("ComdirectCredentials");
            var comdirectCredentials = section.Get<ComdirectCredentials>();
            if (comdirectCredentials == null)
            {
                throw new Exception("missing ComdirectCredentials configuration in secrets.json");
            }

            var builder = new ConfigurationBuilder();
            builder.SetBasePath(AppContext.BaseDirectory)
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            var httpClient = new HttpClient();
            var authClient = new AuthClient(httpClient, comdirectCredentials);

            try
            {
                bool sessionValid = false;
                var configlastSessionDateTime = config["ComdirectSavedSession:LastSessionDateTime"];
                if (configlastSessionDateTime != null)
                {
                    DateTime lastSessionDateTime;
                    if (DateTime.TryParse(configlastSessionDateTime.ToString(), out lastSessionDateTime))
                    {
                        TimeSpan difference = DateTime.Now - lastSessionDateTime;

                        if (difference.TotalSeconds < 500)
                        {
                            sessionValid = true;
                        }
                    }
                }

                if (sessionValid)
                {
                    Console.WriteLine("Active session");
                    var sessionId = config["ComdirectSavedSession:SessionId"];
                    if (!string.IsNullOrEmpty(sessionId))
                    {
                        Console.WriteLine("Get saved values from current session");
                        var requestId = config["ComdirectSavedSession:RequestId"];
                        var refreshToken = config["ComdirectSavedSession:RefreshToken"];
                        authClient.SessionId = sessionId;
                        authClient.RequestId = requestId;
                        var token = new ComdirectOAuthToken();
                        token.refresh_token = refreshToken;
                        Console.WriteLine("Refresh token");
                        // get access token
                        if (!await authClient.RefreshTokenFlowAsync(token))
                        {
                            SettingsHelpers.AddOrUpdateAppSetting<string>("ComdirectSavedSession:SessionId", string.Empty);

                            throw new Exception("Refresh token flow failed"); throw new Exception("Refresh token flow failed"); throw new Exception("Refresh token flow failed");
                        }
                        else
                        {
                            await AuthFlow(authClient, token);
                        }
                    }
                }
                else
                {
                    var token = await authClient.GetTokenAsync();
                    var session = await authClient.GetSessionStatusAsync(token.access_token);
                    var validateSessionStatus = await authClient.PostValidateSessionStatusAsync(token.access_token, session.Identifier);
                    // You can use the following code to get banking balances and transactions for all comdirect banking accounts

                    Console.WriteLine("Active Tan with the comdirect app. Press any key if finished");
                    Console.ReadKey();
                    if (await authClient.ActivateSessionTanAsync(token.access_token, session.Identifier, validateSessionStatus.id))
                    {
                        Console.WriteLine("login ok");

                        await AuthFlow(authClient, token);
                    }
                    else
                    {
                        Console.WriteLine("No active tan session! Exit program");
                        Console.ReadKey();
                    }
                }

                await GetTransactions(httpClient);
                Console.WriteLine(" ---- End ----");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// Performs the secondary authentication flow for the Comdirect API.
        /// This method is responsible for obtaining a valid access token and refresh token,
        /// and then saving the session details for future use.
        /// </summary>
        /// <param name="authClient">An instance of the AuthClient class, which provides methods for interacting with the Comdirect authentication API.</param>
        /// <param name="token">The ComdirectOAuthToken object containing the access token obtained during the initial authentication flow.</param>
        /// <returns>An asynchronous Task that completes when the secondary authentication flow is completed.</returns>
        private static async Task AuthFlow(AuthClient authClient, ComdirectOAuthToken token)
        {
            // Perform the secondary authentication flow by calling the PostSecondaryFlowAsync method
            var validComdirectToken = await authClient.PostSecondaryFlowAsync(token.access_token);

            // Display the expiration time of the access token
            Console.WriteLine("token expires in (sec): " + validComdirectToken.expires_in);

            // Save the session details for future use
            SaveSessionApplication(authClient, token);
        }

        private static void SaveSessionApplication(AuthClient authClient, ComdirectOAuthToken token)
        {
            SettingsHelpers.AddOrUpdateAppSetting<string>("ComdirectSavedSession:SessionId", authClient.SessionId);
            SettingsHelpers.AddOrUpdateAppSetting<string>("ComdirectSavedSession:RequestId", authClient.RequestId);
            if (_isDevelopment)
            {
                SettingsHelpers.AddOrUpdateAppSetting<string>("ComdirectSavedSession:RefreshToken", token.refresh_token);
            }
            else
            {
                SettingsHelpers.AddOrUpdateAppSetting<string>("ComdirectSavedSession:RefreshToken", "refresh_token from secrets.json or env var");
                _secretsManager.UpdateSecret("ComdirectSavedSession:RefreshToken", token.refresh_token);
            }

            SettingsHelpers.AddOrUpdateAppSetting<DateTime>("ComdirectSavedSession:LastSessionDateTime", DateTime.Now);
        }

        private static async Task GetTransactions(HttpClient httpClient)
        {
            var comdirectClient = new ComdirectClient(httpClient);
            // Get AccountBalances from all comdirect banking accounts
            ListResourceAccountBalance balance = await comdirectClient.BankingClientsV2AccountsBalancesAsync(string.Empty, null);
            string lastAccountId = null;
            if (balance != null)
            {
                if (balance.Values != null)
                {
                    foreach (var item in balance.Values)
                    {
                        Console.WriteLine($"{item.Account.AccountDisplayId} ({item.Account.AccountType.Text}) - Balance: {item.Balance.Value}");
                        var transactions = await comdirectClient.BankingV1AccountsTransactionsAsync(item.AccountId, TransactionState.BOTH, TransactionDirection.CREDIT_AND_DEBIT, null, null);
                        if (transactions != null)
                        {
                            foreach (var itemTransaction in transactions.Values)
                            {
                                Console.WriteLine($"Date: {itemTransaction.BookingDate}, Amount: {itemTransaction.Amount.Value}, HolderName: {itemTransaction?.Remitter?.HolderName}, Info: {itemTransaction?.RemittanceInfo}");
                            }
                        }
                        lastAccountId = item.AccountId;
                    }
                }
            }
        }
    }
}
