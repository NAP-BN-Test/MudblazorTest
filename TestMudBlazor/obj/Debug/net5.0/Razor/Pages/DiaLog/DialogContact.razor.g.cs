#pragma checksum "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e199958004a8f32edabdc782d22fa4ed22bc5e3"
// <auto-generated/>
#pragma warning disable 1591
namespace TestMudBlazor.Pages.DiaLog
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
#line 1 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    public partial class DialogContact : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudDialog>(0);
            __builder.AddAttribute(1, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(2);
                __builder2.AddAttribute(3, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 7 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Style", "margin-top: 10px");
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(7, 
#nullable restore
#line 7 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                                                              lang.Keys["ThemLienHe"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudGrid>(9);
                __builder2.AddAttribute(10, "Style", "margin-top: 10px");
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(12);
                    __builder3.AddAttribute(13, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                 6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                        6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.TestMudBlazor.Pages.DiaLog.DialogContact.TypeInference.CreateMudTextField_0(__builder4, 17, 18, 
#nullable restore
#line 10 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                                          lang.Keys["HoTen"]

#line default
#line hidden
#nullable disable
                        , 19, 
#nullable restore
#line 10 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                                                                       Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 20, 
#nullable restore
#line 10 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                           HoTen

#line default
#line hidden
#nullable disable
                        , 21, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HoTen = __value, HoTen)));
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(23);
                    __builder3.AddAttribute(24, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                 6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                        6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.TestMudBlazor.Pages.DiaLog.DialogContact.TypeInference.CreateMudTextField_1(__builder4, 28, 29, 
#nullable restore
#line 13 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                                                lang.Keys["SoDienThoai"]

#line default
#line hidden
#nullable disable
                        , 30, 
#nullable restore
#line 13 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                                                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 31, 
#nullable restore
#line 13 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                           SoDienThoai

#line default
#line hidden
#nullable disable
                        , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SoDienThoai = __value, SoDienThoai)));
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudGrid>(34);
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(36);
                    __builder3.AddAttribute(37, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                 6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                        6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.TestMudBlazor.Pages.DiaLog.DialogContact.TypeInference.CreateMudTextField_2(__builder4, 41, 42, 
#nullable restore
#line 19 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                                          lang.Keys["Email"]

#line default
#line hidden
#nullable disable
                        , 43, 
#nullable restore
#line 19 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                                                                            new EmailAddressAttribute() {ErrorMessage = "The email address is invalid"}

#line default
#line hidden
#nullable disable
                        , 44, 
#nullable restore
#line 19 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                                                                                                                                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 45, 
#nullable restore
#line 19 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                           Email

#line default
#line hidden
#nullable disable
                        , 46, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Email = __value, Email)));
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(48);
                    __builder3.AddAttribute(49, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                 6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(51, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                        6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.TestMudBlazor.Pages.DiaLog.DialogContact.TypeInference.CreateMudTextField_3(__builder4, 53, 54, 
#nullable restore
#line 22 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                                        lang.Keys["Fax"]

#line default
#line hidden
#nullable disable
                        , 55, 
#nullable restore
#line 22 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 56, 
#nullable restore
#line 22 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                           Fax

#line default
#line hidden
#nullable disable
                        , 57, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Fax = __value, Fax)));
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudGrid>(59);
                __builder2.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(61);
                    __builder3.AddAttribute(62, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(63, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                 6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(64, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                        6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.TestMudBlazor.Pages.DiaLog.DialogContact.TypeInference.CreateMudSelect_4(__builder4, 66, 67, 
#nullable restore
#line 27 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                   lang.Keys["ChucVu"]

#line default
#line hidden
#nullable disable
                        , 68, 
#nullable restore
#line 27 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                                                                     true

#line default
#line hidden
#nullable disable
                        , 69, 
#nullable restore
#line 27 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                                                                                    Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 70, "F2", 71, 
#nullable restore
#line 27 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                                                     ChucVu

#line default
#line hidden
#nullable disable
                        , 72, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ChucVu = __value, ChucVu)), 73, (__builder5) => {
                            __Blazor.TestMudBlazor.Pages.DiaLog.DialogContact.TypeInference.CreateMudSelectItem_5(__builder5, 74, 75, 
#nullable restore
#line 28 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                          'a'

#line default
#line hidden
#nullable disable
                            , 76, (__builder6) => {
                                __builder6.AddContent(77, "a");
                            }
                            );
                            __builder5.AddMarkupContent(78, "\r\n                    ");
                            __Blazor.TestMudBlazor.Pages.DiaLog.DialogContact.TypeInference.CreateMudSelectItem_6(__builder5, 79, 80, 
#nullable restore
#line 29 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                          'b'

#line default
#line hidden
#nullable disable
                            , 81, (__builder6) => {
                                __builder6.AddContent(82, "b");
                            }
                            );
                        }
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\r\n\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(84);
                    __builder3.AddAttribute(85, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 33 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(86, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 33 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                 6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(87, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 33 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                        6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudSelect<bool>>(89);
                        __builder4.AddAttribute(90, "Label", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                            lang.Keys["HoatDong"]

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(91, "Strict", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                                                                                  true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(92, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 34 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                                                                                                 Variant.Outlined

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(93, "Format", "F2");
                        __builder4.AddAttribute(94, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 34 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                                                                HoatDong

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(95, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HoatDong = __value, HoatDong))));
                        __builder4.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudSelectItem<bool>>(97);
                            __builder5.AddAttribute(98, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 35 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                                   true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(100, "On");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(101, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudSelectItem<bool>>(102);
                            __builder5.AddAttribute(103, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 36 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                                   false

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(105, "Off");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(106, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(107);
                __builder2.AddAttribute(108, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                            Cancel

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(109, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(110, 
#nullable restore
#line 42 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                     lang.Keys["Cancel"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(111, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(112);
                __builder2.AddAttribute(113, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 43 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                          Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(114, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                                  Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(115, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(116, 
#nullable restore
#line 43 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
                                                           lang.Keys["Submit"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogContact.razor"
       
    public string Fax { get; set; }
    public string HoTen { get; set; }
    public string SoDienThoai { get; set; }
    public string Email { get; set; }
    public string ChucVu { get; set; }
    public bool HoatDong { get; set; }
    [CascadingParameter] MudDialogInstance MudDialog { get; set; }

    void Submit() => MudDialog.Close(DialogResult.Ok(true));
    void Cancel() => MudDialog.Cancel();
    protected override async Task OnInitializedAsync()
    {
        lang.InitLocalizedComponent(this);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILanguageContainerService lang { get; set; }
    }
}
namespace __Blazor.TestMudBlazor.Pages.DiaLog.DialogContact
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Object __arg1, int __seq2, global::MudBlazor.Variant __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Validation", __arg1);
        __builder.AddAttribute(__seq2, "Variant", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudSelect_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::MudBlazor.Variant __arg2, int __seq3, global::System.String __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelect<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Strict", __arg1);
        __builder.AddAttribute(__seq2, "Variant", __arg2);
        __builder.AddAttribute(__seq3, "Format", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_6<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
