// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TestMudBlazor.Pages.Category.Currency
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\_Imports.razor"
using TestMudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\_Imports.razor"
using TestMudBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\_Imports.razor"
using AKSoftware.Localization.MultiLanguages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\_Imports.razor"
using AKSoftware.Localization.MultiLanguages.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\Pages\Category\Currency\ListCurrency.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listcurrency")]
    public partial class ListCurrency : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\Pages\Category\Currency\ListCurrency.razor"
       
    private bool hover = true;
    private string searchString;


    class Curency
    {
        public string Ma;
        public string Ten;
        public bool YeuThich;
        public bool HoatDong;
        public bool MacDinh;

    }

    Curency[] curencys = new Curency[]
{
        new Curency { Ma = "QGVN", Ten = "a", HoatDong = true , YeuThich = true, MacDinh = true },
        new Curency { Ma = "QGMY ", Ten =  "b" ,  HoatDong = false, YeuThich = true, MacDinh = true},
        new Curency { Ma = "QGHQ", Ten = "c",  HoatDong = true, YeuThich = false, MacDinh = true },
        };

    private HashSet<Curency> selectedItems1 = new HashSet<Curency>();
    private IEnumerable<Curency> Elements = new List<Curency>();
    protected override async Task OnInitializedAsync()
    {
        Elements = curencys;
        lang.InitLocalizedComponent(this);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILanguageContainerService lang { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
