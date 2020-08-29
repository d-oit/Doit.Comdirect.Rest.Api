using Comdirect.Auth.CSharp;
using Comdirect.Rest.Api;
using Comdirect.Rest.Api.Comdirect;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;

namespace ConsoleApp.ComdirectApi
{
    internal class Program
    {
        private static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("Comdirect Rest Api!");

            var configuration = new ConfigurationBuilder()
               .AddUserSecrets<ComdirectCredentials>()
               .Build();

            var section = configuration.GetSection("ComdirectCredentials");

            var comdirectCredentials = section.Get<ComdirectCredentials>();

            var httpClient = new HttpClient();
            var authClient = new AuthClient(httpClient, comdirectCredentials);
            var token = authClient.GetToken();
            var session = authClient.GetSessionStatus(token.access_token);
            var validateSessionStatus = authClient.PostValidateSessionStatus(token.access_token, session.Identifier);
            Console.WriteLine("Active Tan with the comdirect app. Press any key if finished");
            Console.ReadKey();
            try
            {
                if (authClient.ActivateSessionTan(token.access_token, session.Identifier, validateSessionStatus.id))
                {
                    Console.WriteLine("login ok - get banking balances");

                    var validComdirectToken = authClient.PostSecondaryFlow(token.access_token);
                    var comdirectClient = new ComdirectClient(httpClient);

                    ListResourceAccountBalance balance = await comdirectClient.BankingClientsV2AccountsBalancesAsync("", null);
                    if (balance != null)
                    {
                        if (balance.Values != null)
                        {
                            foreach (var item in balance.Values)
                            {
                                Console.WriteLine($"{item.Account.AccountDisplayId} ({item.Account.AccountType.Text}) - Balance: {item.Balance.Value}");
                                var transactions = await comdirectClient.BankingV1AccountsTransactionsAsync(item.AccountId, TransactionState.BOTH, TransactionDirection.CREDIT_AND_DEBIT, null, null);
                                  if(transactions != null)
                                {
                                    foreach (var itemTransaction in transactions.Values)
                                    {
                                        Console.WriteLine($"Date: { itemTransaction.BookingDate}, Amount: {itemTransaction.Amount.Value}, HolderName: {itemTransaction?.Remitter?.HolderName}, Info: {itemTransaction?.RemittanceInfo}");
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