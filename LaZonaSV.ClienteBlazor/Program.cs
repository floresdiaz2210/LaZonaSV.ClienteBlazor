using LaZonaSV.ClienteBlazor.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LaZonaSV.ClienteBlazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            //COMENTADO POR  QUE SON CODIGO QUE INCLUIA LA CLASE AL CREARSE PUEDE SERVIR ADELANTE
            /////////////////////////////////////////////////////////////////////////////////
            //builder.RootComponents.Add<HeadOutlet>("head::after");
            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            /////////////////////////////////////////////////////////////////////////////////

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5001/api/") });
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://lazonasv.somee.com/api/") });

            builder.Services.AddScoped<ICategoriasServices, CategoriasServices>();
            builder.Services.AddScoped<IProductosServices, ProductosServices>();

            builder.Services.AddMudServices(); /*importacion de los servicios de mudblazor*/


            await builder.Build().RunAsync();
        }
    }
}
