// Config ComdirectCredentials appSecret before you start (see appsettings.json in the rest api project)
// Get the OAuth ClientCredentials in your comdirect Account: Verwaltung > Entwicklerzugang
// https://kunde.comdirect.de/itx/oauth/privatkunden?execution=e4s1
// dotnet user-secrets set ComdirectCredentials:ClientId <your client secret>
// dotnet user-secrets set ComdirectCredentials:ClientSecret <your client secret>
// dotnet user-secrets set ComdirectCredentials:Pin <your pin>
// dotnet user-secrets set ComdirectCredentials:Username <your username>

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;


namespace ConsoleSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //https://github.com/dotnet/EntityFramework.Docs/issues/3939#issuecomment-1239576724
            CreateHostBuilder(args).UseEnvironment("Development").Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
             .ConfigureAppConfiguration((context, config) =>
                     {
                         var env = context.HostingEnvironment;
                         config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                               .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                               .AddEnvironmentVariables();
                     })
                    .UseSerilog((context, services, configuration) => configuration
                        .ReadFrom.Configuration(context.Configuration)
                        .Enrich.FromLogContext())
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

    }
}
