#pragma checksum "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9d55a83d7bc22c7461c68fe848aaacad8917351"
// <auto-generated/>
#pragma warning disable 1591
namespace TestMudBlazor.Pages.Warehouse
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
#line 1 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listwarehouse")]
    public partial class ListWarehouse : Microsoft.AspNetCore.Components.ComponentBase
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
#line 16 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
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
#line 17 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
                           Typo.h5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(12, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
                                                  true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(14, "Danh sách kho");
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
#line 19 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudToolBar>(19);
                        __builder4.AddAttribute(20, "Class", "toolbarCustom");
                        __builder4.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __Blazor.TestMudBlazor.Pages.Warehouse.ListWarehouse.TypeInference.CreateMudTextField_0(__builder5, 22, 23, "width: 50%", 24, "Search", 25, 
#nullable restore
#line 21 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
                                                                                                            Adornment.Start

#line default
#line hidden
#nullable disable
                            , 26, 
#nullable restore
#line 21 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
                                                                                                                                             Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                            , 27, 
#nullable restore
#line 21 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
                                                                                                                                                                                     Size.Medium

#line default
#line hidden
#nullable disable
                            , 28, "mt-0 searchcutom", 29, 
#nullable restore
#line 21 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
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
                            __builder5.AddAttribute(35, "Href", "/addwarehouse");
                            __builder5.AddAttribute(36, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 23 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
                                                    Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudIconButton>(38);
                                __builder6.AddAttribute(39, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
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
#line 24 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
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
#line 25 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
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
#line 26 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
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
#line 34 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.TestMudBlazor.Pages.Warehouse.ListWarehouse.TypeInference.CreateMudTable_1(__builder4, 55, 56, 
#nullable restore
#line 35 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
                              Elements

#line default
#line hidden
#nullable disable
                        , 57, 
#nullable restore
#line 35 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
                                                        true

#line default
#line hidden
#nullable disable
                        , 58, 
#nullable restore
#line 35 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
                                                                                                           hover

#line default
#line hidden
#nullable disable
                        , 59, 
#nullable restore
#line 35 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
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
                                __builder6.AddMarkupContent(68, "Tên");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(69, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(70);
                            __builder5.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(72, "Loại kho");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(73, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(74);
                            __builder5.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(76, "Dịch vụ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(77, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(78);
                            __builder5.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(80, "Địa chỉ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(81, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(82);
                            __builder5.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(84, "Điện thoại");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(85, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(86);
                            __builder5.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(88, "Fax");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(89, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(90);
                            __builder5.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(92, "Người phụ trách");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(93, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(94);
                            __builder5.AddAttribute(95, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(96, "Quốc gia");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(97, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(98);
                            __builder5.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(100, "Hoạt động");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        , 101, (context) => (__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudTd>(102);
                            __builder5.AddAttribute(103, "DataLabel", "ma");
                            __builder5.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(105, 
#nullable restore
#line 49 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
                                           context.ma

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(106, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(107);
                            __builder5.AddAttribute(108, "DataLabel", "ten");
                            __builder5.AddAttribute(109, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(110, 
#nullable restore
#line 50 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
                                            context.ten

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(111, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(112);
                            __builder5.AddAttribute(113, "DataLabel", "loai");
                            __builder5.AddAttribute(114, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(115, 
#nullable restore
#line 51 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
                                             context.loai

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(116, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(117);
                            __builder5.AddAttribute(118, "DataLabel", "dichvu");
                            __builder5.AddAttribute(119, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(120, 
#nullable restore
#line 52 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
                                               context.dichvu

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(121, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(122);
                            __builder5.AddAttribute(123, "DataLabel", "diachi");
                            __builder5.AddAttribute(124, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(125, 
#nullable restore
#line 53 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
                                               context.diachi

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(126, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(127);
                            __builder5.AddAttribute(128, "DataLabel", "dienthoai");
                            __builder5.AddAttribute(129, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(130, 
#nullable restore
#line 54 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
                                                  context.dienthoai

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(131, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(132);
                            __builder5.AddAttribute(133, "DataLabel", "fax");
                            __builder5.AddAttribute(134, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(135, 
#nullable restore
#line 55 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
                                            context.fax

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(136, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(137);
                            __builder5.AddAttribute(138, "DataLabel", "nguoiphutrach");
                            __builder5.AddAttribute(139, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(140, 
#nullable restore
#line 56 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
                                                      context.nguoiphutrach

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(141, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(142);
                            __builder5.AddAttribute(143, "DataLabel", "quocgia");
                            __builder5.AddAttribute(144, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(145, 
#nullable restore
#line 57 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
                                                context.quocgia

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(146, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(147);
                            __builder5.AddAttribute(148, "DataLabel", "hoatdong");
                            __builder5.AddAttribute(149, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(150, 
#nullable restore
#line 58 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
                                                 context.hoatdong

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        , 151, (__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudTablePager>(152);
                            __builder5.AddAttribute(153, "PageSizeOptions", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32[]>(
#nullable restore
#line 61 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
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
#line 70 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Warehouse\ListWarehouse.razor"
       
    private string searchString;
    private bool hover = true;
    EarningReport[] earningReports = new EarningReport[]
{
        new EarningReport { ma = "00001", loai = "a", dichvu = "Vận chuyển" , ten = "Bảnh", diachi = "Từ Sơn - Bắc Ninh", dienthoai = "1321541321", fax = "123" , nguoiphutrach = "Dũng", quocgia = "Việt Nam", hoatdong = true  },
        new EarningReport { ma = "00002", loai = "b", dichvu = "Vận chuyển" , ten = "Bảnh", diachi = "Từ Sơn - Bắc Ninh", dienthoai = "1321541321", fax = "3232" , nguoiphutrach = "Hưng", quocgia = "Việt Nam", hoatdong = true  },
        new EarningReport { ma = "00003", loai = "c", dichvu = "Vận chuyển" , ten = "Bảnh", diachi = "Từ Sơn - Bắc Ninh", dienthoai = "1321541321", fax = "423423423" , nguoiphutrach = "Tùng", quocgia = "Việt Nam", hoatdong = true  },
                };

    class EarningReport
    {
        public string ma;
        public string ten;
        public string loai;
        public string dichvu;
        public string diachi;
        public string dienthoai;
        public string fax;
        public string nguoiphutrach;
        public string quocgia;
        public bool hoatdong;
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
namespace __Blazor.TestMudBlazor.Pages.Warehouse.ListWarehouse
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
