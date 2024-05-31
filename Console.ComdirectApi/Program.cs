using Comdirect.Auth.CSharp;
using Comdirect.Rest.Api;
using Comdirect.Rest.Api.Comdirect;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp.ComdirectApi
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await MainAsync(args);
        }

        static async Task MainAsync(string[] args)
        {
            Console.WriteLine("Comdirect Rest Api!");

            // Config ComdirectCredentials appSecret before you start (see appsettings.json in the rest api project)
            // Get the OAuth ClientCredentials in your comdirect Account: Verwaltung > Entwicklerzugang
            // https://kunde.comdirect.de/itx/oauth/privatkunden?execution=e4s1
            // dotnet user-secrets set ComdirectCredentials:ClientId <your client secret>
            // dotnet user-secrets set ComdirectCredentials:ClientSecret <your client secret>
            // dotnet user-secrets set ComdirectCredentials:Pin <your pin>
            // dotnet user-secrets set ComdirectCredentials:Username <your username>
            var configuration = new ConfigurationBuilder()
              .AddUserSecrets<Program>()
              .Build();

            var section = configuration.GetSection("ComdirectCredentials");
            var comdirectCredentials = section.Get<ComdirectCredentials>();

            var httpClient = new HttpClient();
            var authClient = new AuthClient(httpClient, comdirectCredentials);
            var token = await authClient.GetTokenAsync();
            var session = await authClient.GetSessionStatusAsync(token.access_token);
            var validateSessionStatus = await authClient.PostValidateSessionStatusAsync(token.access_token, session.Identifier);
            Console.WriteLine("Active Tan with the comdirect app. Press any key if finished");
            Console.ReadKey();
            try
            {
                if (await authClient.ActivateSessionTanAsync(token.access_token, session.Identifier, validateSessionStatus.id))
                {
                    Console.WriteLine("login ok - get banking balances");

                    var validComdirectToken = await authClient.PostSecondaryFlowAsync(token.access_token);
                    var comdirectClient = new ComdirectClient(httpClient);
                    // Get AccountBalances from all comdirect banking accounts 
                    ListResourceAccountBalance balance = await comdirectClient.BankingClientsV2AccountsBalancesAsync("", null);
                    if (balance!= null)
                    {
                        if (balance.Values!= null)
                        {
                            foreach (var item in balance.Values)
                            {
                                Console.WriteLine($"{item.Account.AccountDisplayId} ({item.Account.AccountType.Text}) - Balance: {item.Balance.Value}");
                                var transactions = await comdirectClient.BankingV1AccountsTransactionsAsync(item.AccountId, TransactionState.BOTH, TransactionDirection.CREDIT_AND_DEBIT, null, null);
                                if (transactions!= null)
                                {
                                    foreach (var itemTransaction in transactions.Values)
                                    {
                                        Console.WriteLine($"Date: {itemTransaction.BookingDate}, Amount: {itemTransaction.Amount.Value}, HolderName: {itemTransaction?.Remitter?.HolderName}, Info: {itemTransaction?.RemittanceInfo}");
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No active tan session! Exit program");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        } 
    }
}           