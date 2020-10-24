using Autofac;
using Autofac.Extensions.DependencyInjection;
using MediatR;
using MediatR.Extensions.Autofac.DependencyInjection;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SkiResortManager.Backoffice.Modules.Installations;
using SkiResortManager.Backoffice.Shared;
using SkiResortManager.Backoffice.Shared.Events;
using Syncfusion.Blazor;
using System;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;

namespace SkiResortManager.Backoffice
{
    public class Program
    {
        public static IConfigurationRoot Configuration { get; private set; }

        public static async Task Main(string[] args)
        {
            await CreateHostBuilder(args)
                .Build()
                .RunAsync();
        }

        public static WebAssemblyHostBuilder CreateHostBuilder(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            Configuration = builder.Configuration;
            ConfigureServices(builder.Services);

            builder.ConfigureContainer(new AutofacServiceProviderFactory(Register));

            return builder;
        }

        private static void Register(ContainerBuilder builder)
        {
            builder
                .Register(ctx => new HttpClient()
                {
                    BaseAddress = new Uri(Configuration.GetValue<string>("ApiBaseAddress"))
                })
                .InstancePerLifetimeScope();

            builder.RegisterMediatR(typeof(Program).GetTypeInfo().Assembly);

            builder.RegisterModule<SharedModule>();
            builder.RegisterModule<InstallationsModule>();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSyncfusionBlazor();
            Syncfusion.Licensing.SyncfusionLicenseProvider
                .RegisterLicense(Configuration.GetValue<string>("SyncfusionLicense"));
        }
    }
}
