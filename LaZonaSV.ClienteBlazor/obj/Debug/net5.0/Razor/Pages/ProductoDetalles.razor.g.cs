#pragma checksum "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\Pages\ProductoDetalles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6096842980ad34082f2c9f086562790d1db2961f"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<global::MudBlazor.MudText>(0);
            __builder.AddAttribute(1, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 6 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\Pages\ProductoDetalles.razor"
               Typo.h5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Class", "d-flex justify-center");
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "Detalles Productos");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 9 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\Pages\ProductoDetalles.razor"
 if (prod == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p><em>Cargando...</em></p>");
#nullable restore
#line 12 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\Pages\ProductoDetalles.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::MudBlazor.MudCard>(6);
            __builder.AddAttribute(7, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudCardHeader>(8);
                __builder2.AddAttribute(9, "Class", "red accent-4 shades-text text-white");
                __builder2.AddAttribute(10, "CardHeaderContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudText>(11);
                    __builder3.AddAttribute(12, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 18 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\Pages\ProductoDetalles.razor"
                               Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "Class", "d-flex justify-center");
                    __builder3.AddAttribute(14, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 18 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\Pages\ProductoDetalles.razor"
__builder4.AddContent(15, prod.Producto);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudCardContent>(17);
                __builder2.AddAttribute(18, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudText>(19);
                    __builder3.AddAttribute(20, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 22 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\Pages\ProductoDetalles.razor"
                           Typo.body2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 22 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\Pages\ProductoDetalles.razor"
__builder4.AddContent(22, prod.Precio);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudCardActions>(24);
                __builder2.AddAttribute(25, "class", "d-flex justify-center");
                __builder2.AddAttribute(26, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(27, "img");
                    __builder3.AddAttribute(28, "src", 
#nullable restore
#line 26 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\Pages\ProductoDetalles.razor"
                       prod.Imagen

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(29, "alt", 
#nullable restore
#line 26 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\Pages\ProductoDetalles.razor"
                                          prod.Producto

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(30, "Elevation", "25");
                    __builder3.AddAttribute(31, "Class", "rounded-lg");
                    __builder3.AddAttribute(32, "width", "250");
                    __builder3.AddAttribute(33, "height", "250");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 31 "C:\Users\FERNANlml\Desktop\Practica Profesional\LaZonaClienteBlazor\Nueva carpeta\LaZonaSV.ClienteBlazor\Pages\ProductoDetalles.razor"
}

#line default
#line hidden
#nullable disable
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