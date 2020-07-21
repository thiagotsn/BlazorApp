#pragma checksum "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c526afdeb9c4eb68fb854f5cb626db62fe9a6bde"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/_Imports.razor"
using BlazorApp.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/Pages/FetchData.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/Pages/FetchData.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
#nullable restore
#line 12 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/Pages/FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<div>Loading...</div>\r\n");
#nullable restore
#line 15 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/Pages/FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __Blazor.BlazorApp.Pages.FetchData.TypeInference.CreateDxDataGrid_0(__builder, 4, 5, 
#nullable restore
#line 18 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/Pages/FetchData.razor"
                   forecasts

#line default
#line hidden
#nullable disable
            , 6, (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridDateEditColumn>(8);
                __builder2.AddAttribute(9, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/Pages/FetchData.razor"
                                     nameof(WeatherForecast.Date)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(11);
                __builder2.AddAttribute(12, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/Pages/FetchData.razor"
                             nameof(WeatherForecast.TemperatureC)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Caption", "Temp. (C)");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridSpinEditColumn>(15);
                __builder2.AddAttribute(16, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/Pages/FetchData.razor"
                                     nameof(WeatherForecast.TemperatureF)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "Caption", "Temp. (F)");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(19);
                __builder2.AddAttribute(20, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/Pages/FetchData.razor"
                             nameof(WeatherForecast.Summary)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "Caption", "Summary");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n");
            }
            );
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 24 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/Pages/FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "/Users/thiagonogueira/Projects/BlazorApp/BlazorApp/Pages/FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
namespace __Blazor.BlazorApp.Pages.FetchData
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDxDataGrid_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxDataGrid<T>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
