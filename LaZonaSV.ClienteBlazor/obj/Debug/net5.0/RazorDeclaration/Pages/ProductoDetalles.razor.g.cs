// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LaZonaSV.ClienteBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\_Imports.razor"
using LaZonaSV.ClienteBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\_Imports.razor"
using LaZonaSV.ClienteBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\Pages\ProductoDetalles.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\Pages\ProductoDetalles.razor"
using Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Productodetalles/{id:int}")]
    public partial class ProductoDetalles : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\Pages\ProductoDetalles.razor"
       
    [Parameter]
    public int id { get; set; }

    Productos prod = new Productos();

    protected override async Task OnInitializedAsync()
    {
        if (id > 0)
            prod = await ProductosServices.GetById(id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductosServices ProductosServices { get; set; }
    }
}
#pragma warning restore 1591