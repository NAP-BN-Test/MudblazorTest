#pragma checksum "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c78111c3090685ed8a52a4bcbbb51f0aef7fb43e"
// <auto-generated/>
#pragma warning disable 1591
namespace TestMudBlazor.Pages.Category.TypeContainer
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
#line 3 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-update-type-container")]
    public partial class AddUpdateTypeContainer : Microsoft.AspNetCore.Components.ComponentBase
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
#line 9 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
                        __builder4.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                              model

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                    OnValidSubmit

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder5) => {
                            __builder5.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(13, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudGrid>(14);
                            __builder5.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(16);
                                __builder6.AddAttribute(17, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                 6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudText>(19);
                                    __builder7.AddAttribute(20, "Style", "line-height: 60px");
                                    __builder7.AddAttribute(21, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 14 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                                 Typo.h5

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(22, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddContent(24, 
#nullable restore
#line 14 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                                                               lang.Keys["AddTypeContainer"]

#line default
#line hidden
#nullable disable
                                        );
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(25, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(26);
                                __builder6.AddAttribute(27, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                 6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudToolBar>(29);
                                    __builder7.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.OpenComponent<MudBlazor.MudSpacer>(31);
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(32, "\r\n                            ");
                                        __builder8.OpenComponent<MudBlazor.MudIconButton>(33);
                                        __builder8.AddAttribute(34, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                  Icons.Material.Outlined.Add

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(35, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 19 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                                                           ButtonType.Submit

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(36, "\r\n                            ");
                                        __builder8.OpenComponent<MudBlazor.MudIconButton>(37);
                                        __builder8.AddAttribute(38, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                  Icons.Material.Outlined.Edit

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(39, "\r\n                            ");
                                        __builder8.OpenComponent<MudBlazor.MudIconButton>(40);
                                        __builder8.AddAttribute(41, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                  Icons.Material.Outlined.Notifications

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.CloseComponent();
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(42, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudGrid>(43);
                            __builder5.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(45);
                                __builder6.AddAttribute(46, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(47, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(48, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                4

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.TestMudBlazor.Pages.Category.TypeContainer.AddUpdateTypeContainer.TypeInference.CreateMudTextField_0(__builder7, 50, 51, 
#nullable restore
#line 27 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                                     lang.Keys["Ma"]

#line default
#line hidden
#nullable disable
                                    , 52, 
#nullable restore
#line 27 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                                                               Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 53, 
#nullable restore
#line 28 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                             () => model.Ma

#line default
#line hidden
#nullable disable
                                    , 54, 
#nullable restore
#line 27 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                   model.Ma

#line default
#line hidden
#nullable disable
                                    , 55, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Ma = __value, model.Ma)));
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(56, "\r\n\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(57);
                                __builder6.AddAttribute(58, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 31 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(59, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 31 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(60, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 31 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                4

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.TestMudBlazor.Pages.Category.TypeContainer.AddUpdateTypeContainer.TypeInference.CreateMudTextField_1(__builder7, 62, 63, 
#nullable restore
#line 32 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                                      lang.Keys["Ten"]

#line default
#line hidden
#nullable disable
                                    , 64, 
#nullable restore
#line 32 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                                                                 Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 65, 
#nullable restore
#line 33 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                             () => model.Ten

#line default
#line hidden
#nullable disable
                                    , 66, 
#nullable restore
#line 32 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                   model.Ten

#line default
#line hidden
#nullable disable
                                    , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Ten = __value, model.Ten)));
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(68, "\r\n\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(69);
                                __builder6.AddAttribute(70, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 36 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(71, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 36 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(72, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 36 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                4

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.TestMudBlazor.Pages.Category.TypeContainer.AddUpdateTypeContainer.TypeInference.CreateMudNumericField_2(__builder7, 74, 75, 
#nullable restore
#line 37 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                                           lang.Keys["ThuTu"]

#line default
#line hidden
#nullable disable
                                    , 76, 
#nullable restore
#line 37 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                                                                        Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 77, 
#nullable restore
#line 38 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                () => model.ThuTu

#line default
#line hidden
#nullable disable
                                    , 78, 
#nullable restore
#line 37 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                      model.ThuTu

#line default
#line hidden
#nullable disable
                                    , 79, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.ThuTu = __value, model.ThuTu)));
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(80, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudGrid>(81);
                            __builder5.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(83);
                                __builder6.AddAttribute(84, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 46 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(85, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 46 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                         12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(86, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 46 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.TestMudBlazor.Pages.Category.TypeContainer.AddUpdateTypeContainer.TypeInference.CreateMudTextField_3(__builder7, 88, 89, 
#nullable restore
#line 47 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                                         lang.Keys["GhiChu"]

#line default
#line hidden
#nullable disable
                                    , 90, 
#nullable restore
#line 47 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                                                                       Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 91, 
#nullable restore
#line 48 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                             () => model.GhiChu

#line default
#line hidden
#nullable disable
                                    , 92, 
#nullable restore
#line 47 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                   model.GhiChu

#line default
#line hidden
#nullable disable
                                    , 93, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.GhiChu = __value, model.GhiChu)));
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(94, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudGrid>(95);
                            __builder5.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(97);
                                __builder6.AddAttribute(98, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 54 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(99, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 54 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(100, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 54 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                4

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(101, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudCheckBox<bool>>(102);
                                    __builder7.AddAttribute(103, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 55 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                        true

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(104, "RequiredError", "You must agree");
                                    __builder7.AddAttribute(105, "Class", "ml-n2");
                                    __builder7.AddAttribute(106, "Label", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                             lang.Keys["HoatDong"]

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(107, "Value", 
#nullable restore
#line 55 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                                           model.HoatDong

#line default
#line hidden
#nullable disable
                                    );
                                    __builder7.AddAttribute(108, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.HoatDong = __value, model.HoatDong));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(109, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudGrid>(110);
                            __builder5.AddAttribute(111, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(112);
                                __builder6.AddAttribute(113, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 60 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(114, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudText>(115);
                                    __builder7.AddAttribute(116, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 61 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                        Align.Center

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(117, "Style", "color: red");
                                    __builder7.AddAttribute(118, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 61 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
                                                                                       true

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(119, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(120, "\r\n                            \"Vui lòng nhập thông tin,\r\n                            các ô có dấu (*) là bắt buộc\"\r\n                        ");
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
#line 74 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeContainer\AddUpdateTypeContainer.razor"
       

    TypeContainerCategory model = new TypeContainerCategory();
    public class TypeContainerCategory
    {
        [Required(ErrorMessage = "Nhập mã!")]
        //[StringLength(8, ErrorMessage = "Name length can't be more than 8.")]
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string ThuTu { get; set; }
        public bool HoatDong { get; set; }
        public string GhiChu { get; set; }



    }

    bool success;
    string[] errors = { };
    private void OnValidSubmit(EditContext context)
    {
    }
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
namespace __Blazor.TestMudBlazor.Pages.Category.TypeContainer.AddUpdateTypeContainer
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
        public static void CreateMudNumericField_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudNumericField<T>>(seq);
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
    }
}
#pragma warning restore 1591