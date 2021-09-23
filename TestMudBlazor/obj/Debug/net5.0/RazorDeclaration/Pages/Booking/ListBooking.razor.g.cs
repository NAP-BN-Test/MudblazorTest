// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TestMudBlazor.Pages.Booking
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
#line 1 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Booking\ListBooking.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listbooking")]
    public partial class ListBooking : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 122 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Booking\ListBooking.razor"
       
    private bool dense1 = false;
    private string searchString;
    private bool hover = true;

    class Booking
    {
        public string Service;
        public string OrderNo;
        public string HouseNo;
        public string MasterNo;
        public string JobNo;
        public string BookingNo;
        public string Customer;
        public string Vessel;
        public string VOY;
        public string Consignee;
        public string ConsigneeName;
        public DateTime? DoorDate;
        public DateTime? ETD;
        public DateTime? ETA;
        public string Carrier;
        public string CarrierName;
        public string POL;
        public string POLName;
        public string POD;
        public string PODName;
        public string ClosingDate;
        public string CntrType;
        public string CntrQty;
        public string SalesCode;
        public string SalesName;
        public string Incoterms;
        public string LoadType;
        public string SVCTerm;
        public string Package;
        public string Unit;
        public string WeightOP;
        public string Status;
    }

    Booking[] bookings = new Booking[]
{
            new Booking { Service = "SEA", OrderNo = "", HouseNo = "LSHCLI204198" , MasterNo = "KYHCMH2002775", JobNo = "NAP21-001" ,BookingNo="B01", Customer = "Công ty cổ phần Hà Thăng" , Vessel = "Maersk Discovery", VOY = "001" ,Consignee="SEIKO",
            ConsigneeName = "Công ty TNHH SEIKO VN", DoorDate = DateTime.Now, ETD = DateTime.Now , ETA = DateTime.Now, Carrier = "ABOU" ,CarrierName="ABOX SA", POL = "SH" , POLName = "SHANGHAI", POD = "CATLAI" ,PODName="CẢNG CÁT LÁI",
            ClosingDate = "", CntrType = "40 D’C", CntrQty = "1" , SalesCode = "Tamtt", SalesName = "Trần Thanh Tâm" , Incoterms = "CIF" ,LoadType="FCL",
            SVCTerm = "CY/CY", Package = "BOX", Unit = "kgs" , WeightOP = "6500", Status = "Active"},
            new Booking { Service = "SEA", OrderNo = "", HouseNo = "LNBCLI201697" , MasterNo = "SITGNBCL113569B", JobNo = "NAP21-002" ,BookingNo="B02", Customer = "Công ty TNHH Mai Hương" , Vessel = "AKARI", VOY = "002" ,Consignee="Haivina",
            ConsigneeName = "Công ty TNHH Haivina", DoorDate = DateTime.Now, ETD = DateTime.Now , ETA = DateTime.Now, Carrier = "ADVU" ,CarrierName="ADVU INC", POL = "Ningbo" , POLName = "NINGBO, CN", POD = "HPH" ,PODName="CẢNG HẢI PHÒNG",
            ClosingDate = "", CntrType = "20 D’C", CntrQty = "1" , SalesCode = "NamLV", SalesName = "Lê Vĩnh Nam" , Incoterms = "FOB" ,LoadType="FCL",
            SVCTerm = "CFS-DOOR", Package = "BOX", Unit = "kgs" , WeightOP = "883.950", Status = "active"},
            new Booking { Service = "SEA", OrderNo = "", HouseNo = "HMSO-15001162" , MasterNo = "MOLU12014991846", JobNo = "NAP21-003" ,BookingNo="B03", Customer = "Công ty cổ phần Nhựa Châu Âu" , Vessel = "BIEN DONG NAVIGATOR", VOY = "510W" ,Consignee="FIT",
            ConsigneeName = "Công ty TNHH FIT Việt Nam", DoorDate = DateTime.Now, ETD = DateTime.Now , ETA = DateTime.Now, Carrier = "AGIP SPA" ,CarrierName="AGIP SPA", POL = "JPTYO" , POLName = "TOKYO-TOKYO, Japan", POD = "HPP" ,PODName="CẢNG HẢI PHÒNG",
            ClosingDate = "", CntrType = "20D’C", CntrQty = "1" , SalesCode = "SonLM", SalesName = "Lê Minh Sơn" , Incoterms = "CIF" ,LoadType="FCL",
            SVCTerm = "CY/CY", Package = "BAG", Unit = "KGS" , WeightOP = "14020", Status = "ACTIVE"},
        };









    private HashSet<Booking> selectedItems1 = new HashSet<Booking>();
    private IEnumerable<Booking> Elements = new List<Booking>();
    protected override async Task OnInitializedAsync()
    {
        Elements = bookings;
    }

    private bool resetValueOnEmptyText;
    private bool coerceText;
    private bool coerceValue;
    private string value1, value2;

    private string[] states =
{
        "Hà Nội", "Bắc Ninh", "TP HCM",
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

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
