using HA.UI.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace HA.UI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

            var host = new Uri("https://localhost:44353/");

            builder.Services.AddHttpClient<IZoneService, ZoneService>(client => client.BaseAddress = new Uri(host, "api/zone"));
            builder.Services.AddHttpClient<ISurveyService, SurveyService>(client => client.BaseAddress = new Uri(host, "api/survey"));

            await builder.Build().RunAsync();
        }
    }
}
