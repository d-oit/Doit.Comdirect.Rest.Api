using Comdirect.Auth.CSharp;
using Comdirect.Rest.Api;
using Hangfire;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Diagnostics;


namespace ConsoleSample
{
    public class ComdirectApiHostedService : BackgroundService
    {
        private readonly IBackgroundJobClient _backgroundJobs;
        private readonly ILogger<ComdirectApiHostedService> _logger;
        private readonly IConfiguration _configuration;
        private readonly ComdirectCredentials? _comdirectCredentials;
        readonly IRecurringJobManager _recurringJobs;
        AuthClient? client;

        public ComdirectApiHostedService(
            IBackgroundJobClient backgroundJobs,
            IRecurringJobManager recurringJobs,
            ILogger<ComdirectApiHostedService> logger,
            IConfiguration configuration)
        {
            _recurringJobs = recurringJobs;
            _backgroundJobs = backgroundJobs ?? throw new ArgumentNullException(nameof(backgroundJobs));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));

            var section = configuration.GetSection("ComdirectCredentials") ?? throw new Exception("missing ComdirectCredentials configuration in appsettings.json");
            _comdirectCredentials = section.Get<ComdirectCredentials>();

        }

        public override async Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Starting");
            try
            {
                client = await ComdirectSession();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "No active tan session! Exit program");
                throw;
            }

            await base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Stop");
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                var delayNextRunMinutes = 6;
                while (!stoppingToken.IsCancellationRequested)
                {
                    var sw = Stopwatch.StartNew();
                    await GetComdirecAccountBalances(client);

                    _logger.LogInformation($"Enqueued in {sw.Elapsed}");
                    Console.WriteLine($"Wait for {delayNextRunMinutes} minutes");
                    await Task.Delay(TimeSpan.FromMinutes(delayNextRunMinutes), stoppingToken);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in {nameof(ComdirectApiHostedService)} message: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthClient"/> class for interacting with the Comdirect authentication API.
        /// This method handles the authentication flow, including obtaining a valid access token and refresh token.
        /// If a saved TAN can be reused, it will be used to refresh the session. Otherwise, the user will be prompted to enter a TAN.
        /// </summary>
        /// <returns>
        /// An asynchronous Task that returns an instance of the <see cref="AuthClient"/> class, representing the authenticated client.
        /// </returns>
        public async Task<AuthClient> ComdirectSession()
        {
            var httpClient = new HttpClient();
            var authClient = new AuthClient(httpClient, _comdirectCredentials);

            // Check if a saved TAN can be reused
            if (CheckReuseTan(_configuration))
            {
                // Refresh the session using the saved TAN
                await RefreshTan(authClient);
            }
            else
            {
                // Perform the initial authentication flow to obtain a valid access token
                var token = await authClient.GetTokenAsync();

                // Get the session status
                var session = await authClient.GetSessionStatusAsync(token.access_token);

                // Validate the session status
                var validateSessionStatus = await authClient.PostValidateSessionStatusAsync(token.access_token, session.Identifier);

                // Prompt the user to enter a TAN
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Active Tan with the comdirect app. Press any key if finished");
                Console.ResetColor();
                Console.ReadKey();

                // Activate the session using the entered TAN
                if (await authClient.ActivateSessionTanAsync(token.access_token, session.Identifier, validateSessionStatus.id))
                {
                    // Display a success message
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("login ok");
                    Console.ResetColor();

                    // Perform the secondary authentication flow
                    await AuthFlow(authClient, token);
                }
                else
                {
                    var ex = new Exception("No active tan session! Exit program");
                    // Log an error message and throw an exception if the TAN is not activated
                    _logger.LogError(ex.Message);
                    throw ex;
                }
            }

            // Return the authenticated client
            return authClient;
        }

        /// <summary>
        /// Refreshes the TAN (Transaction Authentication Number) session using the saved values.
        /// </summary>
        /// <param name="authClient">An instance of the AuthClient class for interacting with the Comdirect authentication API.</param>
        /// <returns>
        /// An asynchronous Task that completes when the TAN session refresh is completed.
        /// If the refresh token flow fails, an exception is thrown.
        /// </returns>
        private async Task RefreshTan(AuthClient authClient)
        {
            _logger.LogDebug($"{nameof(RefreshTan)}");
            var sessionId = _configuration["ComdirectSavedSession:SessionId"];
            if (!string.IsNullOrEmpty(sessionId))
            {
                Console.WriteLine("Get saved values from current session");
                var requestId = _configuration["ComdirectSavedSession:RequestId"];
                var refreshToken = _configuration["ComdirectSavedSession:RefreshToken"];
                authClient.SessionId = sessionId;
                authClient.RequestId = requestId;
                var token = new ComdirectOAuthToken();
                token.refresh_token = refreshToken;
                Console.WriteLine("Refresh token");
                try
                {
                    if (!await authClient.RefreshTokenFlowAsync(token))
                    {
                        SettingsHelpers.AddOrUpdateAppSetting<string>("ComdirectSavedSession:SessionId", string.Empty);
                        var ex = new Exception("Refresh token flow failed");
                        _logger.LogError(ex.Message);
                        throw ex;
                    }
                    else
                    {
                        await AuthFlow(authClient, token);
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, ex.Message);
                    throw;
                }
            }
        }

        /// <summary>
        /// Retrieves and displays the account balances for all Comdirect banking accounts.
        /// </summary>
        /// <param name="client">An instance of the AuthClient class for interacting with the Comdirect authentication API.</param>
        /// <returns>
        /// An asynchronous Task that completes when the account balances have been retrieved and displayed.
        /// </returns>
        public async Task GetComdirecAccountBalances(AuthClient client)
        {
            _logger.LogDebug(nameof(GetComdirecAccountBalances));

            // Check if the saved TAN can be reused
            if (!CheckReuseTan(_configuration))
            {
                _logger.LogDebug("RefreshTan");
                // Refresh the TAN session if the saved values are not valid
                await RefreshTan(client);
            }

            // Get AccountBalances from all comdirect banking accounts
            var balances = await client.BankingClientsV2AccountsBalancesAsync(string.Empty, null);

            // Add your code to display the account balances and transactions    
            foreach (var balance in balances.Values)
            {
                Console.WriteLine($"Account: {balance.Account.AccountDisplayId} - {balance.Account.AccountType.Text}, Balance (EUR): {balance.BalanceEUR.Value}");
            }

            _logger.LogDebug($"End -  {nameof(GetComdirecAccountBalances)} - ");
        }

        /// <summary>
        /// Checks if the saved TAN (Transaction Authentication Number) can be reused based on the session validity.
        /// </summary>
        /// <returns>
        /// Returns true if the saved TAN can be reused, false otherwise.
        /// </returns>
        private bool CheckReuseTan(IConfiguration config)
        {
            bool sessionValid = false;

            // Retrieve the last session date and time from the application's configuration
            var configlastSessionDateTime = config.GetValue<DateTime?>("ComdirectSavedSession:LastSessionDateTime");

            // Check if the last session date and time is available
            if (configlastSessionDateTime.HasValue)
            {
                _logger.LogDebug($"Check Tan in: {nameof(CheckReuseTan)} configlastSessionDateTime.HasValue");
                TimeSpan difference = DateTime.Now - configlastSessionDateTime.Value;

                // Retrieve the session expiration time in seconds from the application's configuration
                var expiresInSeconds = config.GetValue<int?>("ComdirectSavedSession:ExpiresInSeconds") ?? 500;

                // Check if the session is still valid based on the expiration time
                if (difference.TotalSeconds < (expiresInSeconds - 99))
                {
                    sessionValid = true;
                }

            }
            _logger.LogDebug($"Check Tan in: {nameof(CheckReuseTan)} sessionValid: {sessionValid}");
            return sessionValid;
        }

        /// <summary>
        /// Performs the secondary authentication flow for the Comdirect API.
        /// This method is responsible for obtaining a valid access token and refresh token,
        /// and then saving the session details for future use.
        /// </summary>
        /// <param name="authClient">An instance of the AuthClient class, which provides methods for interacting with the Comdirect authentication API.</param>
        /// <param name="token">The ComdirectOAuthToken object containing the access token obtained during the initial authentication flow.</param>
        /// <returns>An asynchronous Task that completes when the secondary authentication flow is completed.</returns>
        private async Task AuthFlow(AuthClient authClient, ComdirectOAuthToken token)
        {
            // Perform the secondary authentication flow by calling the PostSecondaryFlowAsync method
            var validComdirectToken = await authClient.PostSecondaryFlowAsync(token.access_token);

            // Display the expiration time of the access token
            Console.WriteLine("token expires in (sec): " + validComdirectToken.expires_in);

            // Save the session details for future use
            SaveSessionApplication(authClient, token);
        }

        /// <summary>
        /// Saves the session details for future use by updating the application's settings.
        /// </summary>
        /// <param name="authClient">An instance of the AuthClient class, which provides methods for interacting with the Comdirect authentication API.</param>
        /// <param name="token">The ComdirectOAuthToken object containing the access token obtained during the initial authentication flow.</param>
        private void SaveSessionApplication(AuthClient authClient, ComdirectOAuthToken token)
        {
            // Update the application's settings with the session details
            SettingsHelpers.AddOrUpdateAppSetting<string>("ComdirectSavedSession:SessionId", authClient.SessionId);
            SettingsHelpers.AddOrUpdateAppSetting<string>("ComdirectSavedSession:RequestId", authClient.RequestId);
            SettingsHelpers.AddOrUpdateAppSetting<string>("ComdirectSavedSession:RefreshToken", token.refresh_token);
            SettingsHelpers.AddOrUpdateAppSetting<DateTime>("ComdirectSavedSession:LastSessionDateTime", DateTime.Now);
            SettingsHelpers.AddOrUpdateAppSetting<int>("ComdirectSavedSession:ExpiresInSeconds", token.expires_in);
        }
    }
}