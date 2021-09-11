// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TestMudBlazor.Pages.Category.Customer
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
#line 2 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Customer\Customer.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Customer\Customer.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addcustomer")]
    public partial class Customer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 255 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Customer\Customer.razor"
       

    public string searchString { get; set; }


    MudForm form;
    bool success;
    string[] errors = { };
    private void OnValidSubmit(EditContext context)
    {
    }
    CustomerDetail model = new CustomerDetail();
    public class CustomerDetail
    {
        [Required(ErrorMessage = "Nhập mã khách hàng!")]
        public string MaKhachHang { get; set; }
        public string Ten { get; set; }
        [Required(ErrorMessage = "Nhập số điện thoại!")]
        public string SoDienThoai { get; set; }
        public string thutu { get; set; }
        public string Loai { get; set; }
        public string NhomKhachhang { get; set; }
        public string DiaChiDangKyKinhDoanh { get; set; }
        public string DiaChi { get; set; }
        public string QuocGia { get; set; }
        [Required(ErrorMessage = "Nhập email!")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng!")]
        public string Email { get; set; }
        public string MaSoThue { get; set; }
        public string Fax { get; set; }
        public string LoaiTienTe { get; set; }
        public string LoaiKhachHang { get; set; }
        public string LoaiHinhKinhDoanh { get; set; }
        public string GhiChu { get; set; }
        public bool HoatDong { get; set; }
        [Range(typeof(DateTime), "1/1/1970", "12/31/3000", ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime? NgaySinh { get; set; }

    }

    private void OpenDialogContact()
    {
        DialogService.Show<DialogContact>("Simple Dialog");
    }

    private void OpenDialogAccBank()
    {
        DialogService.Show<DialogAccBank>("Simple Dialog");
    }



    private string value { get; set; } = "Nothing selected";
    private HashSet<string> options { get; set; } = new HashSet<string>() { "Alaska" };

    private string[] states =
    {
        "Alabama", "Alaska", "American Samoa", "Arizona",
        "Arkansas", "California", "Colorado", "Connecticut",
        "Delaware", "District of Columbia", "Federated States of Micronesia",
        "Florida", "Georgia", "Guam", "Hawaii", "Idaho",
        "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky",
        "Louisiana", "Maine", "Marshall Islands", "Maryland",
        "Massachusetts", "Michigan", "Minnesota", "Mississippi",
        "Missouri", "Montana", "Nebraska", "Nevada",
        "New Hampshire", "New Jersey", "New Mexico", "New York",
        "North Carolina", "North Dakota", "Northern Mariana Islands", "Ohio",
        "Oklahoma", "Oregon", "Palau", "Pennsylvania", "Puerto Rico",
        "Rhode Island", "South Carolina", "South Dakota", "Tennessee",
        "Texas", "Utah", "Vermont", "Virgin Island", "Virginia",
        "Washington", "West Virginia", "Wisconsin", "Wyoming",
    };

    private bool hover = true;
    Listcontact[] listcontact = new Listcontact[]
{
        new Listcontact { HoTen = "CV01", SoDienThoai = "a", Email = "abc@gmail.com" , Fax = "1234568", ChucVu = "10", HanhDong= true },
        new Listcontact { HoTen = "CV01", SoDienThoai = "a", Email = "abc@gmail.com" , Fax = "1234568", ChucVu = "10", HanhDong= true },
        new Listcontact { HoTen = "CV01", SoDienThoai = "a", Email = "abc@gmail.com" , Fax = "1234568", ChucVu = "10", HanhDong= true },
            };

    class Listcontact
    {
        public string HoTen;
        public string SoDienThoai;
        public bool HanhDong;
        public string Email;
        public string Fax;
        public string ChucVu;
    }

    private HashSet<Listcontact> selectedItems1 = new HashSet<Listcontact>();
    private IEnumerable<Listcontact> Elements = new List<Listcontact>();
    protected override async Task OnInitializedAsync()
    {
        Elements = listcontact;
        Elements2 = listbank;
    }


    class ListBank
    {
        public string GhiChu;
        public string Tinh;
        public string DiaChiChiNhanh;
        public string ChiNhanh;
        public string NganHang;
        public string ChuTaiKhoan;
        public string SoTaiKhoan;
        public bool HanhDong;
    }

    ListBank[] listbank = new ListBank[]
{
        new ListBank { SoTaiKhoan = "04041999999", ChuTaiKhoan = "Dũng", HanhDong = true , NganHang = "TPBANK", ChiNhanh = "HÀ NỘI", DiaChiChiNhanh="Hà Nội", Tinh="Hà Nội", GhiChu="abc" },
        new ListBank { SoTaiKhoan = "04041999999", ChuTaiKhoan = "Dũng", HanhDong = true , NganHang = "TPBANK", ChiNhanh = "HÀ NỘI", DiaChiChiNhanh="Hà Nội", Tinh="Hà Nội", GhiChu="abc" },
        new ListBank { SoTaiKhoan = "04041999999", ChuTaiKhoan = "Dũng", HanhDong = true , NganHang = "TPBANK", ChiNhanh = "HÀ NỘI", DiaChiChiNhanh="Hà Nội", Tinh="Hà Nội", GhiChu="abc" },
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
