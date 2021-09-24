// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TestMudBlazor.Pages.Category.Port
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
#line 1 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\Pages\Category\Port\ListPort.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listport")]
    public partial class ListPort : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\Pages\Category\Port\ListPort.razor"
       
    private string searchString;
    private bool hover = true;
    PortDetail[] portDetails = new PortDetail[]
{
new PortDetail { Ma = "HN", Ten = "Hà Nội", HoatDong = true , QuocGia = "Việt Nam", ThuTu = "1",GhiChu="", Loai="1", ThanhPho="HCM"},
new PortDetail { Ma = "HCM ", Ten = "Hồ Chí Minh" , HoatDong = false, QuocGia = "Việt Nam", ThuTu ="2",GhiChu="", Loai="1", ThanhPho="HCM"},
new PortDetail { Ma = "HP", Ten = "Hải Phòng", HoatDong = true, QuocGia = "Việt Nam", ThuTu = "3" ,GhiChu="", Loai="1", ThanhPho="HCM"},
    };

    class PortDetail
    {
        public string Ma;
        public string Ten;
        public string QuocGia;
        public string ThuTu;
        public bool HoatDong;
        public string GhiChu;
        public string Loai;
        public string ThanhPho;
    }



    private HashSet<PortDetail> selectedItems1 = new HashSet<PortDetail>();
    private IEnumerable<PortDetail> Elements = new List<PortDetail>();
    protected override async Task OnInitializedAsync()
    {
        Elements = portDetails;
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
