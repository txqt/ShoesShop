using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PoPoy.Client.Extensions;
using PoPoy.Shared.Common;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PoPoy.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddServices();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
            builder.Services.AddNugetPackageServices();
            builder.Services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri(builder.Configuration["BackendApiUrl"])
            });
            builder.Services.PostConfigure<LoggerFilterOptions>(opt =>
    opt.Rules.Add(
        new LoggerFilterRule(null, "Microsoft.AspNetCore.Authorization.*", LogLevel.None, null)
        ));
            await builder.Build().RunAsync();
        }
    }
}
