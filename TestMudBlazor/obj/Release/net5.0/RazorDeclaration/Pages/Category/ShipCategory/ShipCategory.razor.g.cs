// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TestMudBlazor.Pages.Category.ShipCategory
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\_Imports.razor"
using TestMudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\_Imports.razor"
using TestMudBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\ShipCategory\ShipCategory.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/shipcategory")]
    public partial class ShipCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\ShipCategory\ShipCategory.razor"
       
    private string searchString;
    private bool hover = true;
    ShipCategoryDetail[] ships = new ShipCategoryDetail[]
{
new ShipCategoryDetail { Ma = "S01", Ten = "Tàu A", HoatDong = true , QuocGia = "Việt Nam", ThuTu ="1" ,GhiChu=""},
new ShipCategoryDetail { Ma = "S02 ", Ten = "Tàu B" , HoatDong = false, QuocGia = "Việt Nam", ThuTu = "2",GhiChu=""},
new ShipCategoryDetail { Ma = "S03", Ten = "Tàu C", HoatDong = true, QuocGia = "Trung Quốc", ThuTu = "3" ,GhiChu=""},
};

    class ShipCategoryDetail
    {
        public string Ma;
        public string Ten;
        public string QuocGia;
        public string ThuTu;
        public bool HoatDong;
        public string GhiChu;
    }

    private HashSet<ShipCategoryDetail> selectedItems1 = new HashSet<ShipCategoryDetail>();
    private IEnumerable<ShipCategoryDetail> Elements = new List<ShipCategoryDetail>();
    protected override async Task OnInitializedAsync()
    {
        Elements = ships;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
