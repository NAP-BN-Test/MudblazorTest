#pragma checksum "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36367083a92a3acbe6e12f9787a50f31094bc87b"
// <auto-generated/>
#pragma warning disable 1591
namespace TestMudBlazor.Pages
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
#line 11 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/nation")]
    public partial class Nation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudGrid>(0);
            __builder.AddAttribute(1, "Style", "margin-top: 10px");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudGrid>(3);
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(5);
                    __builder3.AddAttribute(6, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                     6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudText>(8);
                        __builder4.AddAttribute(9, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 5 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                           Typo.h5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(10, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                  true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(12, "Quốc gia");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(13, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(14);
                    __builder3.AddAttribute(15, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                     6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudToolBar>(17);
                        __builder4.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudSpacer>(19);
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(20, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(21);
                            __builder5.AddAttribute(22, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                      Icons.Material.Outlined.Add

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(23, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(24);
                            __builder5.AddAttribute(25, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                      Icons.Material.Outlined.Edit

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(26, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(27);
                            __builder5.AddAttribute(28, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                      Icons.Material.Outlined.Notifications

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(29, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(30);
                            __builder5.AddAttribute(31, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                      Icons.Material.Outlined.PushPin

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(32, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(33);
                            __builder5.AddAttribute(34, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                      Icons.Material.Outlined.PeopleAlt

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(35, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(36);
                            __builder5.AddAttribute(37, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                      Icons.Material.Outlined.MoreVert

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(38, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 15 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                                               Color.Inherit

#line default
#line hidden
#nullable disable
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
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudGrid>(40);
                __builder2.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(42);
                    __builder3.AddAttribute(43, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudForm>(45);
                        __builder4.AddAttribute(46, "OnValidSubmit", "OnValidSubmit");
                        __builder4.AddAttribute(47, "IsValid", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                 success

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(48, "IsValidChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => success = __value, success))));
                        __builder4.AddAttribute(49, "Errors", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 21 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                                         errors

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(50, "ErrorsChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String[]>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => errors = __value, errors))));
                        __builder4.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudGrid>(52);
                            __builder5.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(54);
                                __builder6.AddAttribute(55, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(56, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(57, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                4

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.TestMudBlazor.Pages.Nation.TypeInference.CreateMudTextField_0(__builder7, 59, 60, "Mã", 61, "Nhập mã!", 62, 
#nullable restore
#line 24 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                                                                     true

#line default
#line hidden
#nullable disable
                                    , 63, 
#nullable restore
#line 24 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                                                                                    Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 64, 
#nullable restore
#line 24 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                   ma

#line default
#line hidden
#nullable disable
                                    , 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ma = __value, ma)));
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(66, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(67);
                                __builder6.AddAttribute(68, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(69, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(70, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                4

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.TestMudBlazor.Pages.Nation.TypeInference.CreateMudTextField_1(__builder7, 72, 73, "Tên", 74, 
#nullable restore
#line 27 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                                             Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 75, 
#nullable restore
#line 27 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                   ten

#line default
#line hidden
#nullable disable
                                    , 76, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ten = __value, ten)));
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(77, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(78);
                                __builder6.AddAttribute(79, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(80, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(81, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                4

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.TestMudBlazor.Pages.Nation.TypeInference.CreateMudTextField_2(__builder7, 83, 84, "Thứ tự sắp xếp", 85, 
#nullable restore
#line 30 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                                                          Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 86, 
#nullable restore
#line 30 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                   thutu

#line default
#line hidden
#nullable disable
                                    , 87, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => thutu = __value, thutu)));
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(88, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudGrid>(89);
                            __builder5.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(91);
                                __builder6.AddAttribute(92, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(93, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(94, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                4

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(95, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudCheckBox<bool>>(96);
                                    __builder7.AddAttribute(97, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                        true

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(98, "RequiredError", "You must agree");
                                    __builder7.AddAttribute(99, "Class", "ml-n2");
                                    __builder7.AddAttribute(100, "Label", "Hoạt động");
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(101, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(102);
                                __builder6.AddAttribute(103, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(104, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(105, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                4

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(106, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudCheckBox<bool>>(107);
                                    __builder7.AddAttribute(108, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                        true

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(109, "RequiredError", "You must agree");
                                    __builder7.AddAttribute(110, "Class", "ml-n2");
                                    __builder7.AddAttribute(111, "Label", "Yêu thích");
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(112, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(113);
                                __builder6.AddAttribute(114, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 42 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(115, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 42 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(116, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 42 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                4

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(117, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudGrid>(118);
                            __builder5.AddAttribute(119, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(120);
                                __builder6.AddAttribute(121, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 47 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(122, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 47 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(123, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 47 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                4

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(124, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudButton>(125);
                                    __builder7.AddAttribute(126, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 48 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                            Variant.Filled

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(127, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 48 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                                   Color.Primary

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(128, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                                                                                              !success

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(129, "Class", "ml-auto");
                                    __builder7.AddAttribute(130, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(131, "Thêm");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.AddComponentReferenceCapture(132, (__value) => {
#nullable restore
#line 21 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
                           form = (MudBlazor.MudForm)__value;

#line default
#line hidden
#nullable disable
                        }
                        );
                        __builder4.CloseComponent();
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
#line 58 "C:\Users\Admin\source\repos\TestMudBlazor\TestMudBlazor\Pages\Nation.razor"
               
            public string ma { get; set; }
            public string ten { get; set; }
            public string thutu { get; set; }

            MudForm form;
            bool success;
            string[] errors = { };
            private void OnValidSubmit(EditContext context)
            {
            }
        

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.TestMudBlazor.Pages.Nation
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::MudBlazor.Variant __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "RequiredError", __arg1);
        __builder.AddAttribute(__seq2, "Required", __arg2);
        __builder.AddAttribute(__seq3, "Variant", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
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
        public static void CreateMudTextField_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591