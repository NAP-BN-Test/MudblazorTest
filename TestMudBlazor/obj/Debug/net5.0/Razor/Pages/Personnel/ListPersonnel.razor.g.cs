#pragma checksum "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fb767e3d2085221771ee9d0b97ffaed7f7bb432"
// <auto-generated/>
#pragma warning disable 1591
namespace TestMudBlazor.Pages.Personnel
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
#line 1 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listpersonnel")]
    public partial class ListPersonnel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .mud-toolbar.mud-toolbar-gutters.toolbarCustom {
        padding-left: 6px;
        padding-right: 0px;
    }

    .searchcutom.mud-input-control > .mud-input-control-input-container > div.mud-input.mud-input-text {
        margin-top: 0px;
    }
</style>
");
            __builder.OpenComponent<MudBlazor.MudGrid>(1);
            __builder.AddAttribute(2, "Style", "margin-top: 10px");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudGrid>(4);
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(6);
                    __builder3.AddAttribute(7, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "Style", "margin-top: 10px");
                    __builder3.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudText>(10);
                        __builder4.AddAttribute(11, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 17 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                           Typo.h5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(12, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                                  true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(14, "Danh sách nhân sự");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(16);
                    __builder3.AddAttribute(17, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 19 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudToolBar>(19);
                        __builder4.AddAttribute(20, "Class", "toolbarCustom");
                        __builder4.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __Blazor.TestMudBlazor.Pages.Personnel.ListPersonnel.TypeInference.CreateMudTextField_0(__builder5, 22, 23, "width: 50%", 24, "Search", 25, 
#nullable restore
#line 21 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                                                                                            Adornment.Start

#line default
#line hidden
#nullable disable
                            , 26, 
#nullable restore
#line 21 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                                                                                                                             Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                            , 27, 
#nullable restore
#line 21 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                                                                                                                                                                     Size.Medium

#line default
#line hidden
#nullable disable
                            , 28, "mt-0 searchcutom", 29, 
#nullable restore
#line 21 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                           searchString

#line default
#line hidden
#nullable disable
                            , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString = __value, searchString)));
                            __builder5.AddMarkupContent(31, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudSpacer>(32);
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(33, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudLink>(34);
                            __builder5.AddAttribute(35, "Href", "/addnation");
                            __builder5.AddAttribute(36, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 23 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                                 Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudIconButton>(38);
                                __builder6.AddAttribute(39, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                                                                   Icons.Material.Outlined.Add

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(40, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(41);
                            __builder5.AddAttribute(42, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                      Icons.Material.Outlined.Edit

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(43, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(44);
                            __builder5.AddAttribute(45, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                      Icons.Material.Outlined.Delete

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(46, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(47);
                            __builder5.AddAttribute(48, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                      Icons.Material.Outlined.Print

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
                __builder2.AddMarkupContent(49, "\r\n\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudGrid>(50);
                __builder2.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(52);
                    __builder3.AddAttribute(53, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.TestMudBlazor.Pages.Personnel.ListPersonnel.TypeInference.CreateMudTable_1(__builder4, 55, 56, 
#nullable restore
#line 35 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                              Elements

#line default
#line hidden
#nullable disable
                        , 57, 
#nullable restore
#line 35 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                                        true

#line default
#line hidden
#nullable disable
                        , 58, 
#nullable restore
#line 35 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                                                                                           hover

#line default
#line hidden
#nullable disable
                        , 59, 
#nullable restore
#line 35 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                                                                   selectedItems1

#line default
#line hidden
#nullable disable
                        , 60, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItems1 = __value, selectedItems1)), 61, (__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudTh>(62);
                            __builder5.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(64, "Mã");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(65, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(66);
                            __builder5.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(68, "Họ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(69, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(70);
                            __builder5.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(72, "Tên đệm");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(73, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(74);
                            __builder5.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(76, "Tên");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(77, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(78);
                            __builder5.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(80, "Ngày sinh");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(81, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(82);
                            __builder5.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(84, "Giới tính");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(85, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(86);
                            __builder5.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(88, "Số CMND/CCCD");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(89, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(90);
                            __builder5.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(92, "Địa chỉ thường trú");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(93, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(94);
                            __builder5.AddAttribute(95, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(96, "Địa chỉ tạm trú");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(97, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(98);
                            __builder5.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(100, "Điện thoại");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(101, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(102);
                            __builder5.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(104, "Email");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(105, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(106);
                            __builder5.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(108, "Chức vụ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(109, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(110);
                            __builder5.AddAttribute(111, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(112, "Phòng ban");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(113, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(114);
                            __builder5.AddAttribute(115, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(116, "Ghi chú");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        , 117, (context) => (__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudTd>(118);
                            __builder5.AddAttribute(119, "DataLabel", "ma");
                            __builder5.AddAttribute(120, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(121, 
#nullable restore
#line 53 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                           context.ma

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(122, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(123);
                            __builder5.AddAttribute(124, "DataLabel", "ho");
                            __builder5.AddAttribute(125, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(126, 
#nullable restore
#line 54 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                           context.ho

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(127, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(128);
                            __builder5.AddAttribute(129, "DataLabel", "tendem");
                            __builder5.AddAttribute(130, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(131, 
#nullable restore
#line 55 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                               context.tendem

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(132, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(133);
                            __builder5.AddAttribute(134, "DataLabel", "ten");
                            __builder5.AddAttribute(135, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(136, 
#nullable restore
#line 56 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                            context.ten

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(137, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(138);
                            __builder5.AddAttribute(139, "DataLabel", "ngaysinh");
                            __builder5.AddAttribute(140, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(141, 
#nullable restore
#line 57 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                                 context.ngaysinh

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(142, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(143);
                            __builder5.AddAttribute(144, "DataLabel", "gioitinh");
                            __builder5.AddAttribute(145, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(146, 
#nullable restore
#line 58 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                                 context.gioitinh

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(147, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(148);
                            __builder5.AddAttribute(149, "DataLabel", "cmnd");
                            __builder5.AddAttribute(150, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(151, 
#nullable restore
#line 59 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                             context.cmnd

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(152, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(153);
                            __builder5.AddAttribute(154, "DataLabel", "dcthuongtru");
                            __builder5.AddAttribute(155, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(156, 
#nullable restore
#line 60 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                                    context.dcthuongtru

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(157, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(158);
                            __builder5.AddAttribute(159, "DataLabel", "dctamtru");
                            __builder5.AddAttribute(160, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(161, 
#nullable restore
#line 61 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                                 context.dctamtru

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(162, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(163);
                            __builder5.AddAttribute(164, "DataLabel", "dienthoai");
                            __builder5.AddAttribute(165, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(166, 
#nullable restore
#line 62 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                                  context.dienthoai

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(167, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(168);
                            __builder5.AddAttribute(169, "DataLabel", "email");
                            __builder5.AddAttribute(170, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(171, 
#nullable restore
#line 63 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                              context.email

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(172, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(173);
                            __builder5.AddAttribute(174, "DataLabel", "chucvu");
                            __builder5.AddAttribute(175, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(176, 
#nullable restore
#line 64 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                               context.chucvu

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(177, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(178);
                            __builder5.AddAttribute(179, "DataLabel", "phongban");
                            __builder5.AddAttribute(180, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(181, 
#nullable restore
#line 65 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                                 context.phongban

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(182, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(183);
                            __builder5.AddAttribute(184, "DataLabel", "ghichu");
                            __builder5.AddAttribute(185, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(186, 
#nullable restore
#line 66 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                               context.ghichu

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        , 187, (__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudTablePager>(188);
                            __builder5.AddAttribute(189, "PageSizeOptions", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32[]>(
#nullable restore
#line 69 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
                                                    new int[]{50, 100}

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                        }
                        );
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
#line 78 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Personnel\ListPersonnel.razor"
       
    private string searchString;
    private bool hover = true;
    EarningReport[] earningReports = new EarningReport[]
{
        new EarningReport { ma = "00001", ho = "Nguyễn", tendem = "Anh" , ten = "Bảnh", ngaysinh = "10/11/2003", gioitinh = "Nữ", cmnd = "1321541321", dcthuongtru = "Minh Khai, Hà Nội" , dctamtru = "Gầm cầu Nhật Tân", dienthoai = "039662312131", email = "banhaa@gmail.com", chucvu = "Trưởng Phòng" , phongban = "B1", ghichu = "10"  },
        new EarningReport { ma = "00001", ho = "Nguyễn", tendem = "Anh" , ten = "Bảnh", ngaysinh = "10/11/2003", gioitinh = "Nữ", cmnd = "1321541321", dcthuongtru = "Minh Khai, Hà Nội" , dctamtru = "Gầm cầu Nhật Tân", dienthoai = "039662312131", email = "banhaa@gmail.com", chucvu = "Trưởng Phòng" , phongban = "B1", ghichu = "10"  },
        new EarningReport { ma = "00001", ho = "Nguyễn", tendem = "Anh" , ten = "Bảnh", ngaysinh = "10/11/2003", gioitinh = "Nữ", cmnd = "1321541321", dcthuongtru = "Minh Khai, Hà Nội" , dctamtru = "Gầm cầu Nhật Tân", dienthoai = "039662312131", email = "banhaa@gmail.com", chucvu = "Trưởng Phòng" , phongban = "B1", ghichu = "10"  },
            };

    class EarningReport
    {
        public string ma;
        public string ho;
        public string tendem;
        public string ten;
        public string ngaysinh;
        public string gioitinh;
        public string cmnd;
        public string dcthuongtru;
        public string dctamtru;
        public string dienthoai;
        public string email;
        public string chucvu;
        public string phongban;
        public string ghichu;
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
namespace __Blazor.TestMudBlazor.Pages.Personnel.ListPersonnel
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::MudBlazor.Adornment __arg2, int __seq3, global::System.String __arg3, int __seq4, global::MudBlazor.Size __arg4, int __seq5, global::System.String __arg5, int __seq6, T __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg7)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Style", __arg0);
        __builder.AddAttribute(__seq1, "Placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Adornment", __arg2);
        __builder.AddAttribute(__seq3, "AdornmentIcon", __arg3);
        __builder.AddAttribute(__seq4, "IconSize", __arg4);
        __builder.AddAttribute(__seq5, "Class", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateMudTable_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Collections.Generic.HashSet<T> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<global::System.Collections.Generic.HashSet<T>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "MultiSelection", __arg1);
        __builder.AddAttribute(__seq2, "Hover", __arg2);
        __builder.AddAttribute(__seq3, "SelectedItems", __arg3);
        __builder.AddAttribute(__seq4, "SelectedItemsChanged", __arg4);
        __builder.AddAttribute(__seq5, "HeaderContent", __arg5);
        __builder.AddAttribute(__seq6, "RowTemplate", __arg6);
        __builder.AddAttribute(__seq7, "PagerContent", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
