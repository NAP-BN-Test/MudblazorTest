// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TestMudBlazor.Pages.Category.Office
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
#line 2 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\_Imports.razor"
using System.Net.Http.Json;

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
#line 2 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Office\Office.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Office\Office.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addoffice")]
    public partial class Office : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 137 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Office\Office.razor"
       

    public string searchString { get; set; }


    MudForm form;
    bool success;
    string[] errors = { };
    private void OnValidSubmit(EditContext context)
    {
    }
    OfficeDetail model = new OfficeDetail();
    public class OfficeDetail
    {
        [Required(ErrorMessage = "Nhập mã khách hàng!")]
        //[StringLength(8, ErrorMessage = "Name length can't be more than 8.")]
        public string Ma { get; set; }
        public string Ten { get; set; }
        [Required(ErrorMessage = "Nhập số điện thoại!")]
        public string SoDienThoai { get; set; }
        public bool HoatDong { get; set; }
        public string Fax { get; set; }
        public string DiaChi { get; set; }


    }

    private void OpenDialogAccBank()
    {
        DialogService.Show<DialogInfoBank>("Simple Dialog");
    }



    private string value { get; set; } = "Nothing selected";
    private HashSet<string> options { get; set; } = new HashSet<string>() { "Alaska" };

    private string[] states =
    {
        "Alabama", "Alaska", "American Samoa", "Arizona",
        "Arkansas", "California", "Colorado", "Connecticut",
        "Delaware", "District of Columbia", "Federated States of Micronesia",
        "Florida", "Georgia", "Guam", "Hawaii", "Idaho",
    };

    private bool hover = true;

    protected override async Task OnInitializedAsync()
    {
        Elements2 = listbank;
    }


    class ListBank
    {
        public string ChuTaiKhoan;
        public string SoTaiKhoan;
        public string NganHang;
        public string LoaiTienTe;
    }

    ListBank[] listbank = new ListBank[]
{
        new ListBank { SoTaiKhoan = "04041999999", ChuTaiKhoan = "Dũng",  NganHang = "TPBANK",  LoaiTienTe="VNĐ" },
        new ListBank { SoTaiKhoan = "04041999999", ChuTaiKhoan = "Dũng", NganHang = "TPBANK",  LoaiTienTe="USD"},
        new ListBank { SoTaiKhoan = "04041999999", ChuTaiKhoan = "Dũng", NganHang = "TPBANK",  LoaiTienTe="VNĐ" },
        };



    private HashSet<ListBank> selectedItemsBank = new HashSet<ListBank>();
    private IEnumerable<ListBank> Elements2 = new List<ListBank>();

    private bool resetValueOnEmptyText;
    private bool coerceText;
    private bool coerceValue;
    private string value1, value2;

    private async Task<IEnumerable<string>> Search1(string value)
    {
        // In real life use an asynchronous function for fetching data from an api.
        await Task.Delay(5);

        // if text is null or empty, show complete list
        if (string.IsNullOrEmpty(value))
            return states;
        return states.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
