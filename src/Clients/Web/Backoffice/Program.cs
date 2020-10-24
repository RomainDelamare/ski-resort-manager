using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SkiResortManager.Backoffice.Modules.Installations.Pages.SkiLifts.Forms.Services;
using SkiResortManager.Backoffice.Shared.Events;
using Syncfusion.Blazor;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SkiResortManager.Backoffice
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            var configuration = builder.Configuration.Build();

            ConfigureServices(builder.Services, configuration);

            await builder.Build().RunAsync();
        }

        public static void ConfigureServices(IServiceCollection services, IConfigurationRoot configuration)
        {
            var baseAddress = configuration.GetValue<string>("ApiBaseAddress");
            services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri(baseAddress)
            });

            services.AddSyncfusionBlazor();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(configuration["SyncfusionLicense"]);

            services.AddSingleton<LockPageEvent>();
            services.AddScoped<INewSkiLiftService, NewSkiLiftService>();
        }
    }
}
