// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TestMudBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "H:\MudblazorTest\TestMudBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\MudblazorTest\TestMudBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\MudblazorTest\TestMudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "H:\MudblazorTest\TestMudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\MudblazorTest\TestMudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\MudblazorTest\TestMudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "H:\MudblazorTest\TestMudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "H:\MudblazorTest\TestMudBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "H:\MudblazorTest\TestMudBlazor\_Imports.razor"
using TestMudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "H:\MudblazorTest\TestMudBlazor\_Imports.razor"
using TestMudBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "H:\MudblazorTest\TestMudBlazor\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Demo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 230 "H:\MudblazorTest\TestMudBlazor\Pages\Demo.razor"
       
    bool open = false;
    bool dense = false;
    bool preserveOpenState = false;
    bool Basic_CheckBox1 = false;
    Breakpoint breakpoint = Breakpoint.Lg;
    DrawerClipMode clipMode = DrawerClipMode.Never;
    DateTime? date = DateTime.Today;
    public string TextValue { get; set; }
    private string value1;
    private string _normalText;
    private bool resetValueOnEmptyText;
    private bool coerceText;
    private bool coerceValue;
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

    private async Task<IEnumerable<string>> Search1(string value)
    {
        // In real life use an asynchronous function for fetching data from an api.
        await Task.Delay(5);

        // if text is null or empty, show complete list
        if (string.IsNullOrEmpty(value))
            return states;
        return states.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
    }

    void ToggleDrawer()
    {
        open = !open;
    }


    EarningReport[] earningReports = new EarningReport[]
{
        new EarningReport { Name = "Quincy Larson: Learn Google Sheets like a pro [free 3-hour course on spreadsheets for data science " +
            "Quincy Larson: Learn Google Sheets like a pro [free 3-hour course on spreadsheets for data science" +
            " Quincy Larson: Learn Google Sheets like a pro [free 3-hour course on spreadsheets for data science" },
        new EarningReport { Name = "Quincy Larson: Learn Google Sheets like a pro [free 3-hour course on spreadsheets for data science" },
        new EarningReport { Name = "Quincy Larson: Learn Google Sheets like a pro [free 3-hour course on spreadsheets for data science" },
};

    class EarningReport
    {
        public string Name;
    }

    private HashSet<EarningReport> selectedItems1 = new HashSet<EarningReport>();
    private IEnumerable<EarningReport> Elements = new List<EarningReport>();
    protected override async Task OnInitializedAsync()
    {
        Elements = earningReports;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
