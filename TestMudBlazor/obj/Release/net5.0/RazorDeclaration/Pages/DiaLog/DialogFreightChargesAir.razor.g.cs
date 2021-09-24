// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TestMudBlazor.Pages.DiaLog
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
#line 1 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\Pages\DiaLog\DialogFreightChargesAir.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\Pages\DiaLog\DialogFreightChargesAir.razor"
using DiaLog;

#line default
#line hidden
#nullable disable
    public partial class DialogFreightChargesAir : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "c:\project\fontend\blazor\mudblazortest\TestMudBlazor\Pages\DiaLog\DialogFreightChargesAir.razor"
       

    [CascadingParameter] MudDialogInstance MudDialog { get; set; }

    void Submit() => MudDialog.Close(DialogResult.Ok(true));
    void Cancel() => MudDialog.Cancel();

    protected override async Task OnInitializedAsync()
    {
    }

    DetailFreightCharges model = new DetailFreightCharges();

    public class DetailFreightCharges
    {
        [Required(ErrorMessage = "Nhập mã!")]
        public string MaHangVanChuyen { get; set; }
        public string HangVanChuyen { get; set; }
        public string CangBoc { get; set; }
        public string CangDo { get; set; }
        public string TienTe { get; set; }
        public string DonGia { get; set; }
        public string PhuPhi { get; set; }
    }


    bool success;
    string[] errors = { };
    private void OnValidSubmit(EditContext context)
    {
    }
    private string[] states =
    {
        "Alabama", "Alaska", "American Samoa", "Arizona",
        "Arkansas", "California", "Colorado", "Connecticut",
        "Delaware", "District of Columbia", "Federated States of Micronesia",
    };
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
