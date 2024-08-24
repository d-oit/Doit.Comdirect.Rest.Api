using Hangfire;
using Hangfire.InMemory;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleSample
{
    public class Startup
    {
        /// <summary>
        /// Configures the services for the application.
        /// </summary>
        /// <param name="services">The collection of services to configure.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            // Add Hangfire services to the application.
            services.AddHangfire(config => config
                .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
                .UseSimpleAssemblyNameTypeSerializer()
                .UseIgnoredAssemblyVersionTypeResolver()
                .UseColouredConsoleLogProvider()
                .UseSerilogLogProvider()
                .UseInMemoryStorage(new InMemoryStorageOptions
                {
                    IdType = InMemoryStorageIdType.Long,
                    MaxExpirationTime = TimeSpan.FromHours(12),
                    StringComparer = StringComparer.Ordinal // Default value, case -sensitive.
                }));

            // Add Hangfire server to the application.
            services.AddHangfireServer(options => options.Queues = new[] { "critical", "default" });

            // Add hosted service for Comdirect API.
            services.AddHostedService<ComdirectApiHostedService>();
        }

        /// <summary>
        /// Configures the application and its request processing pipeline.
        /// </summary>
        /// <param name="app">The application builder.</param>
        /// <param name="env">The web host environment.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Add developer exception page middleware to the application.
            app.UseDeveloperExceptionPage();

            // Add Hangfire Dashboard to the application.
            app.UseHangfireDashboard(String.Empty);
        }
    }
}
