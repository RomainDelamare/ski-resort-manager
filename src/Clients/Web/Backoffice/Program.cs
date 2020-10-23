using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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

            var baseAddress = builder.Configuration.GetValue<string>("ApiBaseAddress");
            builder.Services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri(baseAddress)
            });

            builder.Services.AddSyncfusionBlazor();

            var configuration = builder.Configuration.Build();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(configuration["SyncfusionLicense"]);

            await builder.Build().RunAsync();
        }
    }
}
