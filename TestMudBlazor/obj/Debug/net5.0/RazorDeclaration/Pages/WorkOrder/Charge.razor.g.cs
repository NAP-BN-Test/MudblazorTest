// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TestMudBlazor.Pages.WorkOrder
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
#line 2 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\WorkOrder\Charge.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\WorkOrder\Charge.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\WorkOrder\Charge.razor"
using DiaLog;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/charge")]
    public partial class Charge : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 437 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\WorkOrder\Charge.razor"
       
    private bool dense1 = true;
    private bool dense2 = true;
    Charges model = new Charges();
    public string Search { get; set; }
    public class Charges
    {
        public string Profit { get; set; }
        public string ExRate { get; set; }
        public DateTime? ExDate { get; set; }

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
        Elements8 = Sellings;
        Elements9 = Buyings;
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





    private HashSet<Selling> selectedItems8 = new HashSet<Selling>();
    private IEnumerable<Selling> Elements8 = new List<Selling>();

    private HashSet<Buying> selectedItems9 = new HashSet<Buying>();
    private IEnumerable<Buying> Elements9 = new List<Buying>();









    class Selling
    {
        public string Number;
        public string Customer;
        public string FareName;
        public string Fare;
        public string TaxType;
        public string Currency;
        public string ExRate;
        public string Unit;
        public int Qty;
        public string Rate;
        public string Tax1;
        public string Amt;
        public string LocalAmount;
        public string VAT;
        public string Remark;
        public string Evidence;
        public string Amount;
        public string BillNo;
        public string Group;
        public string Tax2;
        public string TaxDate;
        public string Paid;
        public string PaidDate;
        public string Department;
        public string Create;
        public string Createdate;
    }

    Selling[] Sellings = new Selling[]
                   {
        new Selling {
            Customer = "Công ty cổ phần Hà Thăng",Fare = "THC", FareName = "Phí xếp dỡ",TaxType = "0% VAT", Currency = "VNĐ",ExRate = "", Unit = "Container/ngày",Qty = 1,Rate = "500.000",
        Tax1 = "Y",Amt = "0", LocalAmount = "500.000", VAT = "0%",Remark = "", Evidence = "Internal",Amount = "500.000",BillNo = "HPAY21030015",
        Group = "Y1",Tax2 = "Y", TaxDate = "01/10/2021", Paid = "N",PaidDate = "", Department = "SALES",Create = "Tamtt",Createdate = "01/10/2021", Number = "1", },

         new Selling {
            Customer = "Công ty cổ phần Hà Thăng",Fare = "DOC",FareName = "Phí chứng từ", TaxType = "0% VAT", Currency = "VNĐ",ExRate = "", Unit = "BL",Qty = 1,Rate = "1.000.000",
        Tax1 = "Y",Amt = "0", LocalAmount = "1.000.000", VAT = "0%",Remark = "", Evidence = "Tax",Amount = "1.000.000",BillNo = "HPAY21030015",
        Group = "Y",Tax2 = "Y", TaxDate = "01/10/2021", Paid = "N",PaidDate = "", Department = "SALES",Create = "Tamtt",Createdate = "01/10/2021", Number = "2",},

          new Selling {
            Customer = "IV1806001",Fare = "OF",FareName = "Cước vận tải nội địa", TaxType = "0% VAT", Currency = "VNĐ",ExRate = "", Unit = "Container or CBM",Qty = 1,Rate = "4.000.000",
        Tax1 = "Y",Amt = "0", LocalAmount = "4.000.000", VAT = "29/09/2021",Remark = "", Evidence = "Tax",Amount = "4.000.000",BillNo = "HPAY21030015",
        Group = "Y",Tax2 = "Y", TaxDate = "01/10/2021", Paid = "N",PaidDate = "", Department = "SALES",Create = "Tamtt",Createdate = "01/10/2021", Number = "3",},


                                               };


    class Buying
    {
        public string Number;
        public string Vendor;
        public string FareName;
        public string Fare;
        public string TaxType;
        public string Currency;
        public string ExRate;
        public string Unit;
        public int Qty;
        public string Rate;
        public string Tax1;
        public string Amt;
        public string LocalAmount;
        public string VAT;
        public string Remark;
        public string Evidence;
        public string Amount;
        public string BillNo;
        public string Group;
        public string Tax2;
        public string TaxDate;
        public string Paid;
        public string PaidDate;
        public string Department;
        public string Create;
        public string Createdate;
    }

    Buying[] Buyings = new Buying[]
                       {
        new Buying {
            Vendor = "4PS/Chi nhánh công ty cổ phần Pizza 4PS",Fare = "TRG", FareName = "Phí vận tải đường bộ", TaxType = "0% VAT", Currency = "VNĐ",ExRate = "", Unit = "Shpt",Qty = 1,Rate = "4.000.000",
        Tax1 = "Y",Amt = "0", LocalAmount = "4.000.000", VAT = "0%",Remark = "", Evidence = "Tax",Amount = "4.000.000",BillNo = "HPAY21030016",
        Group = "Y",Tax2 = "Y", TaxDate = "11/10/2021", Paid = "N",PaidDate = "", Department = "SALES",Create = "Tamtt",Createdate = "01/10/2021", Number = "1",},

         new Buying {
            Vendor = "4PS/Chi nhánh công ty cổ phần Pizza 4PS",Fare= "TOL Fee", FareName = "Phí cầu đường", TaxType = "0% VAT", Currency = "600.000",ExRate = "", Unit = "Container",Qty = 1,Rate = "600.000",
        Tax1 = "Y",Amt = "0", LocalAmount = "600.000", VAT = "0%",Remark = "", Evidence = "Internal",Amount = "600.000",BillNo = "HPAY21030016",
        Group = "Y",Tax2 = "Y", TaxDate = "11/10/2021", Paid = "N",PaidDate = "", Department = "SALES",Create = "Tamtt",Createdate = "01/10/2021", Number = "2",},

          new Buying {
            Vendor = "4PS/Chi nhánh công ty cổ phần Pizza 4PS",Fare = "LON", FareName = "Phí nâng",TaxType = "0% VAT", Currency = "VNĐ",ExRate = "", Unit = "Container",Qty = 1,Rate = "700.000",
        Tax1 = "Y",Amt = "0", LocalAmount = "700.000", VAT = "0%",Remark = "", Evidence = "Tax",Amount = "1",BillNo = "HPAY21030016",
        Group = "Y",Tax2 = "Y", TaxDate = "11/10/2021", Paid = "N",PaidDate = "", Department = "SALES",Create = "Tamtt",Createdate = "01/10/2021", Number = "3",},


                                                   };


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
