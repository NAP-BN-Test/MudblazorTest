#pragma checksum "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b8710ac07bfea5c10aeac9b50121b3e5fe8db2f"
// <auto-generated/>
#pragma warning disable 1591
namespace TestMudBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\_Imports.razor"
using TestMudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\_Imports.razor"
using TestMudBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Shared\NavMenu.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudDrawer>(0);
            __builder.AddAttribute(1, "ClipMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.DrawerClipMode>(
#nullable restore
#line 5 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Shared\NavMenu.razor"
                                        clipMode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Breakpoint", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Breakpoint>(
#nullable restore
#line 5 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Shared\NavMenu.razor"
                                                               breakpoint

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "PreserveOpenState", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Shared\NavMenu.razor"
                                                                                               preserveOpenState

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Shared\NavMenu.razor"
                                                                                                                             1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.DrawerVariant>(
#nullable restore
#line 5 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Shared\NavMenu.razor"
                                                                                                                                          DrawerVariant.Mini

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Shared\NavMenu.razor"
                        open

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => open = __value, open))));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudNavMenu>(9);
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(11);
                    __builder3.AddAttribute(12, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 7 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Shared\NavMenu.razor"
                           NavLinkMatch.All

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Shared\NavMenu.razor"
                                                    Icons.Filled.Store

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(15, "Store");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(17);
                    __builder3.AddAttribute(18, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 8 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Shared\NavMenu.razor"
                           NavLinkMatch.All

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Shared\NavMenu.razor"
                                                    Icons.Filled.LibraryBooks

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(21, "Library");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(23);
                    __builder3.AddAttribute(24, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 9 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Shared\NavMenu.razor"
                           NavLinkMatch.All

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Shared\NavMenu.razor"
                                                    Icons.Filled.Group

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(27, "Community");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Shared\NavMenu.razor"
      
    bool open = false;
    bool dense = false;
    bool preserveOpenState = false;
    Breakpoint breakpoint = Breakpoint.Lg;
    DrawerClipMode clipMode = DrawerClipMode.Never;

    void ToggleDrawer()
    {
        open = !open;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
