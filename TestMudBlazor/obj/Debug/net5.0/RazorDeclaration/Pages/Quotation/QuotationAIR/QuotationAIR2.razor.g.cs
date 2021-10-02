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
#line 2 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\QuotationAIR\QuotationAIR2.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\QuotationAIR\QuotationAIR2.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\QuotationAIR\QuotationAIR2.razor"
using DiaLog;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/quotationairtwo")]
    public partial class QuotationAIR2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 350 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\QuotationAIR\QuotationAIR2.razor"
           

        private bool dense1 = false;
        private bool dense2 = false;

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
            [EmailAddress(ErrorMessage = "Email không đúng định dạng!")]
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
            Elements2 = detailcuockhacs;
            Elements3 = detailCuocs;
        }

        private void OpenOtherCharges()
        {
            DialogService.Show<DialogOtherChargesAir2>("Simple Dialog");
        }

        private void OpenFreightCharges()
        {
            DialogService.Show<DiaLogFreightChargesAir2>("Simple Dialog");
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
        "Xác nhận", "Treo", "Hủy",
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

        class DetailCuocKhac
        {
            public string MaHangVanChuyen;
            public string HangVanChuyen;
            public string LoaiCuoc;
            public string Cuoc;
            public string TenCuoc;
            public string TienTe;
            public string GiaDonVi;
            public string DonVi;
            public string GhiChu;
        }

        class DetailCuoc
        {
            public string MaHangVanChuyen;
            public string HangVanChuyen;
            public string CangBoc;
            public string CangDo;
            public string TienTe;
            public string Min;
            public string Am45;
            public string Duong45;
            public string Duong100;
            public string Duong300;
            public string Duong500;
            public string Duong1000;
            public string PhuPhi;
        }



        DetailCuocKhac[] detailcuockhacs = new DetailCuocKhac[]
    {
        new DetailCuocKhac { MaHangVanChuyen = "DHL", HangVanChuyen = "Công ty cổ phần giao nhận Toàn Cầu DHL",  LoaiCuoc = "Cước chính",  TienTe="VNĐ" , Cuoc="AC", GhiChu="", TenCuoc="Cước vận chuyển hàng không", GiaDonVi="3.000.000", DonVi="Kg"},
        new DetailCuocKhac { MaHangVanChuyen = "MTV", HangVanChuyen = "Công ty TNHH MTV Tổng công ty Tân Cảng Sài Gòn", LoaiCuoc = "Phi làm Bill",  TienTe="USD" , Cuoc="AWB", GhiChu="", TenCuoc="Phí làm bill", GiaDonVi="300", DonVi="BL"},
        new DetailCuocKhac { MaHangVanChuyen = "Transerco", HangVanChuyen = "Tổng công ty vận tải Hà Nội", LoaiCuoc = "Phí THC",  TienTe="VNĐ"  , Cuoc="THC", GhiChu="", TenCuoc="Phí xếp dỡ tại sân bay", GiaDonVi="300.000", DonVi="Kg"},
                    };


        DetailCuoc[] detailCuocs = new DetailCuoc[]
    {
        new DetailCuoc { MaHangVanChuyen = "DHL", HangVanChuyen = "Công ty cổ phần giao nhận Toàn Cầu DHL",  CangBoc = "Sân bay Nội Bài",  TienTe="VNĐ" , CangDo="Sân bay Tân Sơn Nhất", Min="200.000", Am45="100.000",Duong45="400.000",Duong100="500.000",Duong300="600.000",Duong500="700.000",Duong1000="700.000", PhuPhi="Phụ phí an ninh", },
        new DetailCuoc { MaHangVanChuyen = "MTV", HangVanChuyen = "Công ty TNHH MTV Tổng công ty Tân Cảng Sài Gòn", CangBoc = "Sân bay Liên Khương",  TienTe="USD" , CangDo="Sân bay Nội Bài",Min="50", Am45="100",Duong45="200",Duong100="100",Duong300="200",Duong500="400",Duong1000="500",  PhuPhi="Phụ phí an ninh", },
        new DetailCuoc { MaHangVanChuyen = "Transerco", HangVanChuyen = "Tổng công ty vận tải Hà Nội", CangBoc = "Sân bay Vinh",  TienTe="VNĐ"  , CangDo="Sân bay Cát Bi Hải Phòng", Min="300.000", Am45="300.000",Duong45="400.000",Duong100="450.000",Duong300="600.000",Duong500="600.000",Duong1000="700.000", PhuPhi="Phụ phí soi chiếu", },
                   };







        private HashSet<DetailCuocKhac> selectedItems = new HashSet<DetailCuocKhac>();
        private IEnumerable<DetailCuocKhac> Elements2 = new List<DetailCuocKhac>();

        private HashSet<DetailCuoc> selectedItems3 = new HashSet<DetailCuoc>();
        private IEnumerable<DetailCuoc> Elements3 = new List<DetailCuoc>();






    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
