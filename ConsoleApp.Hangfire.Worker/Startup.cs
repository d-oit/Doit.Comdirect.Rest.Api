using Hangfire;
using Hangfire.InMemory;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleSample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
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

            services.AddHangfireServer(options => options.Queues = new[] { "critical", "default" });

            services.AddHostedService<ComdirectApiHostedService>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseHangfireDashboard(String.Empty);

        }
    }
}
