#pragma checksum "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7ffca0824f9c573c6f6c2a1c3378de294544a6b"
// <auto-generated/>
#pragma warning disable 1591
namespace TestMudBlazor.Pages.Category.HSCode
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
#nullable restore
#line 3 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-update-hs-code")]
    public partial class AddUpdateHSCode : Microsoft.AspNetCore.Components.ComponentBase
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
#line 8 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                     6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudText>(8);
                        __builder4.AddAttribute(9, "Style", "line-height: 60px");
                        __builder4.AddAttribute(10, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 9 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                     Typo.h5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(11, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                                            true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(13, "Thêm mới mã HS");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(14, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(15);
                    __builder3.AddAttribute(16, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                     6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudToolBar>(18);
                        __builder4.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudSpacer>(20);
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(21, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(22);
                            __builder5.AddAttribute(23, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                      Icons.Material.Outlined.Add

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(24, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(25);
                            __builder5.AddAttribute(26, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                      Icons.Material.Outlined.Edit

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(27, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(28);
                            __builder5.AddAttribute(29, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                      Icons.Material.Outlined.Notifications

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
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudGrid>(31);
                __builder2.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(33);
                    __builder3.AddAttribute(34, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(36);
                        __builder4.AddAttribute(37, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 22 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                              model

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(38, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 22 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                    OnValidSubmit

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudGrid>(40);
                            __builder5.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(42);
                                __builder6.AddAttribute(43, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 24 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(44, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 24 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(45, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 24 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                4

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.TestMudBlazor.Pages.Category.HSCode.AddUpdateHSCode.TypeInference.CreateMudTextField_0(__builder7, 47, 48, "Mã (*)", 49, 
#nullable restore
#line 25 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                                                       Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 50, 
#nullable restore
#line 26 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                   () => model.code

#line default
#line hidden
#nullable disable
                                    , 51, 
#nullable restore
#line 25 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                   model.code

#line default
#line hidden
#nullable disable
                                    , 52, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.code = __value, model.code)));
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(53, "\r\n\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(54);
                                __builder6.AddAttribute(55, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(56, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(57, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                4

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.TestMudBlazor.Pages.Category.HSCode.AddUpdateHSCode.TypeInference.CreateMudTextField_1(__builder7, 59, 60, "Mô tả", 61, 
#nullable restore
#line 30 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                                                          Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 62, 
#nullable restore
#line 31 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                   () => model.descript

#line default
#line hidden
#nullable disable
                                    , 63, 
#nullable restore
#line 30 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                   model.descript

#line default
#line hidden
#nullable disable
                                    , 64, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.descript = __value, model.descript)));
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(65, "\r\n\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(66);
                                __builder6.AddAttribute(67, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(68, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(69, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                4

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.TestMudBlazor.Pages.Category.HSCode.AddUpdateHSCode.TypeInference.CreateMudTextField_2(__builder7, 71, 72, "Hàng hóa", 73, 
#nullable restore
#line 35 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                                                          Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 74, 
#nullable restore
#line 36 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                   () => model.goods

#line default
#line hidden
#nullable disable
                                    , 75, 
#nullable restore
#line 35 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                   model.goods

#line default
#line hidden
#nullable disable
                                    , 76, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.goods = __value, model.goods)));
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(77, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudGrid>(78);
                            __builder5.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(80);
                                __builder6.AddAttribute(81, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(82, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(83, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                4

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.TestMudBlazor.Pages.Category.HSCode.AddUpdateHSCode.TypeInference.CreateMudTextField_3(__builder7, 85, 86, "Quốc gia", 87, 
#nullable restore
#line 42 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                                                           Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 88, 
#nullable restore
#line 43 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                   () => model.nation

#line default
#line hidden
#nullable disable
                                    , 89, 
#nullable restore
#line 42 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                   model.nation

#line default
#line hidden
#nullable disable
                                    , 90, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.nation = __value, model.nation)));
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(91, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(92);
                                __builder6.AddAttribute(93, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 45 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(94, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 45 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(95, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 45 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                4

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudCheckBox<bool>>(97);
                                    __builder7.AddAttribute(98, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 46 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                        true

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(99, "RequiredError", "You must agree");
                                    __builder7.AddAttribute(100, "Class", "ml-n2");
                                    __builder7.AddAttribute(101, "Label", "hoạt động");
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(102, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(103);
                                __builder6.AddAttribute(104, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 49 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(105, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 49 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(106, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 49 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                4

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.TestMudBlazor.Pages.Category.HSCode.AddUpdateHSCode.TypeInference.CreateMudNumericField_4(__builder7, 108, 109, "Thứ tự", 110, 
#nullable restore
#line 50 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                                                         Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 111, 
#nullable restore
#line 51 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                   () => model.stt

#line default
#line hidden
#nullable disable
                                    , 112, 
#nullable restore
#line 50 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                      model.stt

#line default
#line hidden
#nullable disable
                                    , 113, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.stt = __value, model.stt)));
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(114, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudGrid>(115);
                            __builder5.AddAttribute(116, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(117);
                                __builder6.AddAttribute(118, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 55 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(119, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 55 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(120, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 55 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                4

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(121, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudCheckBox<bool>>(122);
                                    __builder7.AddAttribute(123, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 56 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                        true

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(124, "RequiredError", "You must agree");
                                    __builder7.AddAttribute(125, "Class", "ml-n2");
                                    __builder7.AddAttribute(126, "Label", "hoạt động");
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(127, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudGrid>(128);
                            __builder5.AddAttribute(129, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(130);
                                __builder6.AddAttribute(131, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 61 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(132, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudText>(133);
                                    __builder7.AddAttribute(134, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 62 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                        Align.Center

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(135, "Style", "color: red");
                                    __builder7.AddAttribute(136, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 62 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
                                                                                       true

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(137, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(138, "\"Vui lòng nhập thông tin,\r\n                            các ô có dấu (*) là bắt buộc\"");
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
#line 73 "H:\MudblazorTest\TestMudBlazor\Pages\Category\HSCode\AddUpdateHSCode.razor"
       

    Form model = new Form();
    public class Form
    {
        [Required(ErrorMessage = "Nhập mã!")]
        //[StringLength(8, ErrorMessage = "Name length can't be more than 8.")]
        public string code { get; set; }

        public string descript { get; set; }
        public string goods { get; set; }
        public string nation { get; set; }

        public string stt { get; set; }
        public bool active { get; set; }

        public string note { get; set; }



    }

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
namespace __Blazor.TestMudBlazor.Pages.Category.HSCode.AddUpdateHSCode
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudNumericField_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudNumericField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591