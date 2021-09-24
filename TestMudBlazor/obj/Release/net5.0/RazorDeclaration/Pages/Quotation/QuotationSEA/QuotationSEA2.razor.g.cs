// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TestMudBlazor.Pages.Quotation.QuotationSEA
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
#line 2 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\_Imports.razor"
using System.Net.Http.Json;

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
#line 2 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\Pages\Quotation\QuotationSEA\QuotationSEA2.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\Pages\Quotation\QuotationSEA\QuotationSEA2.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\Pages\Quotation\QuotationSEA\QuotationSEA2.razor"
using DiaLog;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/quotationseatwo")]
    public partial class QuotationSEA2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 449 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\Pages\Quotation\QuotationSEA\QuotationSEA2.razor"
       
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
        DialogService.Show<DialogOtherChargesSEA>("Simple Dialog");
    }

    private void OpenFreightCharges()
    {
        DialogService.Show<DialogFreightChargesSEA>("Simple Dialog");
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
        public string MaPhi;
        public string TenPhi;
        public string KieuPhi;
        public string TienTe;
        public string LoaiCont;
        public string HaiMuoiDC;
        public string BonMuoiDC;
        public string HQ;
        public string FCLUnit;
        public string GiaLCL;
        public string DVTLCL;
        public string GhiChu;
    }

    class DetailCuoc
    {
        public string MaHangTau;
        public string TenHangTau;
        public string CangBoc;
        public string CangDo;
        public string TienTe;
        public string LoaiCont;
        public string HaiMuoiDC;
        public string BonMuoiDC;
        public string HQ;
        public string DVFCV;
        public string GiaLCL;
        public string DVTLCL;
        public string GhiChu;
    }



    DetailCuocKhac[] detailcuockhacs = new DetailCuocKhac[]
{
        new DetailCuocKhac { MaPhi = "OF", TenPhi = "Cước vận tải quốc tế",  KieuPhi = "Cước vận chuyển chính",  TienTe="VNĐ" , LoaiCont="40’DC", HaiMuoiDC="1000", BonMuoiDC="1000", HQ="1000", FCLUnit="1000", GhiChu="", DVTLCL="CBM", GiaLCL="1.000.000"},
        new DetailCuocKhac { MaPhi = "THC", TenPhi = "Phí xếp dỡ", KieuPhi = "Phí THC",  TienTe="USD" , LoaiCont="20’DC",HaiMuoiDC="1000", BonMuoiDC="1000", HQ="1000", FCLUnit="1000", GhiChu="", DVTLCL="Tons", GiaLCL="2.000.000"},
        new DetailCuocKhac { MaPhi = "DOC", TenPhi = "Phí chứng từ", KieuPhi = "Phí chứng từ",  TienTe="VNĐ"  , LoaiCont="40’DC",HaiMuoiDC="1000", BonMuoiDC="1000", HQ="1000", FCLUnit="1000", GhiChu="", DVTLCL="CBM", GiaLCL="1.000.000"},
            };


    DetailCuoc[] detailCuocs = new DetailCuoc[]
{
        new DetailCuoc { MaHangTau = "ABOU", TenHangTau = "ABOX SA",  CangBoc = "Cảng Hải Phòng",  TienTe="VNĐ" , CangDo="TOKYO – TOKYO,Japan", LoaiCont="40’DC", HaiMuoiDC="1000", BonMuoiDC="1000", HQ="1000", DVFCV="1000", GhiChu="VNĐ" , DVTLCL="CBM", GiaLCL="1.000.000"},
        new DetailCuoc { MaHangTau = "AUSU", TenHangTau = "ACE LINES LTD", CangBoc = "Cảng Đà Nẵng",  TienTe="USD" , CangDo="Cảng Hải Phòng", LoaiCont="20’DC", HaiMuoiDC="1000", BonMuoiDC="1000", HQ="1000", DVFCV="1000", GhiChu="VNĐ" , DVTLCL="Tons", GiaLCL="2.000.000"},
        new DetailCuoc { MaHangTau = "ADVU", TenHangTau = "ADV INC", CangBoc = "Dongxing China",  TienTe="VNĐ"  , CangDo="Cảng Chân Mây", LoaiCont="40’DC", HaiMuoiDC="1000", BonMuoiDC="1000", HQ="1000", DVFCV="1000", GhiChu="VNĐ" , DVTLCL="CBM", GiaLCL="1.000.000"},
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
