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
#line 2 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Booking\Booking3.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Booking\Booking3.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Booking\Booking3.razor"
using DiaLog;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bookingcomponent3")]
    public partial class Booking3 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 557 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Booking\Booking3.razor"
               


            private void HandleSubmit()
            {
                //Access and validate the values list here
            }

            public class TodoItem
            {
                public string cnt { get; set; }
                public int qty { get; set; }
            }




            void AddTodo()
            {
                todos.Add(new TodoItem { cnt = "", qty = 0 });
            }

            private void RemoveTodo(int i) => todos.RemoveAt(i);
            private void UpdateCnt(int i, string value) => todos[i].cnt = value;
            private void Updateqty(int i, string value) => todos[i].qty = Int32.Parse(value);

            IList<TodoItem> todos = new List<TodoItem>();
            
            private bool dense1 = true;
            //public string SelectedOption { get; set; }

            public string SelectedOption = "Sea";
            MudListItem selectedItem;
            object selectedValue = 1;


            Booking model = new Booking();
            GhiChuBaoGia model1 = new GhiChuBaoGia();
            public class GhiChuBaoGia
            {
                public string GhiChu { get; set; }
                public string LienHe { get; set; }
            }
            public class Booking
            {
                public string LoadType { get; set; }
                public string FreightTerms { get; set; }
                public string ServiceTerms { get; set; }
                public string IncoTerms { get; set; }
                public string CargoClose { get; set; }
                public string WMGClose { get; set; }
                public string SIClose { get; set; }
                public DateTime? DoorDate { get; set; }
                public string Weight { get; set; }
                public string Measure { get; set; }
                public string Sale { get; set; }
                public string Operator { get; set; }
                public string User { get; set; }
                public DateTime? Date { get; set; }
                public string Remark { get; set; }

                public string HouseNo { get; set; }
                public string MasterNo { get; set; }
                public string Service { get; set; }
                public string POR { get; set; }
                public string Carrier { get; set; }
                public string Customer { get; set; }
                public string Vessel { get; set; }
                public string VOY { get; set; }
                public string VIA { get; set; }
                public string PICTel1 { get; set; }
                public string FinalDest { get; set; }
                public DateTime? ETD { get; set; }
                public string Shipper { get; set; }
                public string Warehose { get; set; }
                public DateTime? ETA { get; set; }
                public string PICTel2 { get; set; }
                public string Delivery { get; set; }
                public string POL { get; set; }
                public string Consignee { get; set; }
                public string StuffingPlace { get; set; }
                public string POD { get; set; }
                public string Partner { get; set; }
                public int NWeight { get; set; }
                public string Package { get; set; }
                public int Qty { get; set; }
                public string Item { get; set; }
                public TimeSpan? Time1 { get; set; }
                public TimeSpan? Time2 { get; set; }
                public TimeSpan? Time3 { get; set; }
                public string Trucker { get; set; }
                public string CYInfor { get; set; }
            }

            bool success;
            string[] errors = { };
            private void OnValidSubmit(EditContext context)
            {
                //detailQuatationSea1.Add(new DetailQuatationSea1 { MaPhi = "04041999999", TenPhi = "Dũng", KieuPhi = "TPBANK", TienTe = "VNĐ", DonGia = "1000/MIN(KG); 22.500/+45(KG)", GhiChu = "" });
            }

            private void OnValidSubmit1(EditContext context)
            {
            }
            protected override async Task OnInitializedAsync()
            {
                Elements2 = detailContainerlists;
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

            class DetailContainerlist
            {
                public string Stt;
                public string Cntr;
                public string Qty;
            }

            DetailContainerlist[] detailContainerlists = new DetailContainerlist[]
        {
        new DetailContainerlist { Stt = "1",Cntr = "OF", Qty = "1", },
        new DetailContainerlist {Stt = "2", Cntr = "OF", Qty = "2", },
 new DetailContainerlist { Stt = "3",Cntr = "OF", Qty = "3", },
                                        };


            private HashSet<DetailContainerlist> selectedItems = new HashSet<DetailContainerlist>();
            private IEnumerable<DetailContainerlist> Elements2 = new List<DetailContainerlist>();

        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
