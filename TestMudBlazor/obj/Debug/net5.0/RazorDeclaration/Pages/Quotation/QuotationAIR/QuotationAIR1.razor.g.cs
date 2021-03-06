// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TestMudBlazor.Pages.Quotation.QuotationAIR
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
#line 12 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\_Imports.razor"
using AKSoftware.Localization.MultiLanguages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\_Imports.razor"
using AKSoftware.Localization.MultiLanguages.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\QuotationAIR\QuotationAIR1.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\QuotationAIR\QuotationAIR1.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\QuotationAIR\QuotationAIR1.razor"
using DiaLog;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/quotationairone")]
    public partial class QuotationAIR1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 294 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\QuotationAIR\QuotationAIR1.razor"
           

        Quotation model = new Quotation();
        GhiChuBaoGia model1 = new GhiChuBaoGia();
        public class GhiChuBaoGia
        {
            public string GhiChu { get; set; }
            public string LienHe { get; set; }
        }
        public class Quotation
        {
            public string SoBaoGia { get; set; }
            public string KhachHang { get; set; }
            public string PICKH { get; set; }
            [EmailAddress(ErrorMessage = "Email kh??ng ????ng ?????nh d???ng!")]
            public string Email { get; set; }
            public string SoDienThoai { get; set; }
            public string HangHoa { get; set; }
            public string Cangden { get; set; }
            public string DiemDen { get; set; }
            public string CangDi { get; set; }
            public string DiemDi { get; set; }
            public string LoaiXNK { get; set; }
            public string LoaiTai { get; set; }
            [Range(typeof(DateTime), "1/1/1970", "12/31/3000", ErrorMessage = "Value for {0} must be between {1} and {2}")]
            public DateTime? NgayHieuLuc { get; set; }
            [Range(typeof(DateTime), "1/1/1970", "12/31/3000", ErrorMessage = "Value for {0} must be between {1} and {2}")]
            public DateTime? NgayPhatHang { get; set; }
            public string NhanVienKinhDoanh { get; set; }
            public string TrangThai { get; set; }
            public string DieuKienGiaoHang { get; set; }
            public string MoTa { get; set; }
            public string GhiChu { get; set; }

        }

        bool success;
        string[] errors = { };
        private void OnValidSubmit(EditContext context)
        {
        }

        private void OnValidSubmit1(EditContext context)
        {
        }
        protected override async Task OnInitializedAsync()
        {
            Elements2 = detailQuatationSea1;
        }

        private void OpenDetailQuotation()
        {
            DialogService.Show<DialogDetailQuotationAir>("Simple Dialog");
        }


        private bool resetValueOnEmptyText;
        private bool coerceText;
        private bool coerceValue;
        private string value1, value2;
        private bool hover = true;
        public string searchString { get; set; }

        private string[] states =
    {
        "Alabama", "Alaska", "American Samoa", "Arizona",
        "Arkansas", "California", "Colorado", "Connecticut",
        "Delaware", "District of Columbia", "Federated States of Micronesia",
        "Florida", "Georgia", "Guam", "Hawaii", "Idaho",
    };

        private string[] states2 =
        {
        "X??c nh???n", "Treo", "H???y",
    };

        private async Task<IEnumerable<string>> Search1(string value)
        {
            // In real life use an asynchronous function for fetching data from an api.
            await Task.Delay(5);

            // if text is null or empty, show complete list
            if (string.IsNullOrEmpty(value))
                return states;
            return states.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
        }

        private async Task<IEnumerable<string>> Search2(string value)
        {
            // In real life use an asynchronous function for fetching data from an api.
            await Task.Delay(5);

            // if text is null or empty, show complete list
            if (string.IsNullOrEmpty(value))
                return states2;
            return states2.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
        }

        class DetailQuatationSea1
        {
            public string MaPhi;
            public string TenPhi;
            public string KieuPhi;
            public string TienTe;
            public string DonGia;
            public string GhiChu;
        }

        DetailQuatationSea1[] detailQuatationSea1 = new DetailQuatationSea1[]
    {
        new DetailQuatationSea1 { MaPhi = "04041999999", TenPhi = "D??ng",  KieuPhi = "TPBANK",  TienTe="VN??" , DonGia="1000/MIN(KG); 22.500/+45(KG)", GhiChu=""},
        new DetailQuatationSea1 { MaPhi = "04041999999", TenPhi = "D??ng", KieuPhi = "TPBANK",  TienTe="USD" , DonGia="1000/MIN(KG); 22.500/+45(KG)", GhiChu=""},
        new DetailQuatationSea1 { MaPhi = "04041999999", TenPhi = "D??ng", KieuPhi = "TPBANK",  TienTe="VN??"  , DonGia="1000/MIN(KG); 22.500/+45(KG)", GhiChu=""},
                            };


        private HashSet<DetailQuatationSea1> selectedItems = new HashSet<DetailQuatationSea1>();
        private IEnumerable<DetailQuatationSea1> Elements2 = new List<DetailQuatationSea1>();






    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
