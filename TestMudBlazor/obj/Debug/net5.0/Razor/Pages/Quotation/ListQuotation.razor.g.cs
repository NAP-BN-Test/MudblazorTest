#pragma checksum "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94a1d04bcc97e93a4af3428036de62fc1a322180"
// <auto-generated/>
#pragma warning disable 1591
namespace TestMudBlazor.Pages.Quotation
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
#line 1 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listquotation")]
    public partial class ListQuotation : Microsoft.AspNetCore.Components.ComponentBase
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
#line 16 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
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
#line 17 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                           Typo.h5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(12, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                                                  true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(14, "Danh sách báo giá");
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
#line 19 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudToolBar>(19);
                        __builder4.AddAttribute(20, "Class", "toolbarCustom");
                        __builder4.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __Blazor.TestMudBlazor.Pages.Quotation.ListQuotation.TypeInference.CreateMudTextField_0(__builder5, 22, 23, "width: 50%", 24, "Search", 25, 
#nullable restore
#line 22 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                                         Adornment.Start

#line default
#line hidden
#nullable disable
                            , 26, 
#nullable restore
#line 22 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                                                                          Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                            , 27, 
#nullable restore
#line 22 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                                                                                                                  Size.Medium

#line default
#line hidden
#nullable disable
                            , 28, "mt-0 searchcutom", 29, 
#nullable restore
#line 21 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                                           searchString

#line default
#line hidden
#nullable disable
                            , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString = __value, searchString)));
                            __builder5.AddMarkupContent(31, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudSpacer>(32);
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(33, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(34);
                            __builder5.AddAttribute(35, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                                      Icons.Material.Outlined.Archive

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(36, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(37);
                            __builder5.AddAttribute(38, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
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
                __builder2.AddMarkupContent(39, "\r\n\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudGrid>(40);
                __builder2.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(42);
                    __builder3.AddAttribute(43, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.TestMudBlazor.Pages.Quotation.ListQuotation.TypeInference.CreateMudTable_1(__builder4, 45, 46, 
#nullable restore
#line 35 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                              Elements

#line default
#line hidden
#nullable disable
                        , 47, 
#nullable restore
#line 35 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                                                        true

#line default
#line hidden
#nullable disable
                        , 48, 
#nullable restore
#line 35 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                                                                                                           hover

#line default
#line hidden
#nullable disable
                        , 49, 
#nullable restore
#line 35 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                                                                                   selectedItems1

#line default
#line hidden
#nullable disable
                        , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItems1 = __value, selectedItems1)), 51, (__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudTh>(52);
                            __builder5.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(54, "Số báo giá");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(55, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(56);
                            __builder5.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(58, "Loại hình");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(59, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(60);
                            __builder5.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(62, "Mã khách hàng");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(63, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(64);
                            __builder5.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(66, "Tên khách hàng");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(67, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(68);
                            __builder5.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(70, "Người phụ trách");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(71, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(72);
                            __builder5.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(74, "Cảng bốc");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(75, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(76);
                            __builder5.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(78, "Cảng dỡ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(79, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(80);
                            __builder5.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(82, "Trạng thái");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(83, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(84);
                            __builder5.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(86, "Người tạo");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(87, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(88);
                            __builder5.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(90, "Ghi chú");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        , 91, (context) => (__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudTd>(92);
                            __builder5.AddAttribute(93, "DataLabel", "SoBaoGia");
                            __builder5.AddAttribute(94, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(95, 
#nullable restore
#line 49 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                                                 context.SoBaoGia

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(96, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(97);
                            __builder5.AddAttribute(98, "DataLabel", "LoaiHinh");
                            __builder5.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(100, 
#nullable restore
#line 50 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                                                 context.LoaiHinh

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(101, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(102);
                            __builder5.AddAttribute(103, "DataLabel", "MaKhachHang");
                            __builder5.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(105, 
#nullable restore
#line 51 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                                                    context.MaKhachHang

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(106, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(107);
                            __builder5.AddAttribute(108, "DataLabel", "TenKhachHang");
                            __builder5.AddAttribute(109, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(110, 
#nullable restore
#line 52 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                                                     context.TenKhachHang

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(111, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(112);
                            __builder5.AddAttribute(113, "DataLabel", "NguoiPhuTrach");
                            __builder5.AddAttribute(114, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(115, 
#nullable restore
#line 53 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                                                      context.NguoiPhuTrach

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(116, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(117);
                            __builder5.AddAttribute(118, "DataLabel", "CangBoc");
                            __builder5.AddAttribute(119, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(120, 
#nullable restore
#line 54 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                                                context.CangBoc

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(121, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(122);
                            __builder5.AddAttribute(123, "DataLabel", "CangDo");
                            __builder5.AddAttribute(124, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(125, 
#nullable restore
#line 55 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                                               context.CangDo

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(126, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(127);
                            __builder5.AddAttribute(128, "DataLabel", "TrangThai");
                            __builder5.AddAttribute(129, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(130, 
#nullable restore
#line 56 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                                                  context.TrangThai

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(131, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(132);
                            __builder5.AddAttribute(133, "DataLabel", "NguoiTao");
                            __builder5.AddAttribute(134, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(135, 
#nullable restore
#line 57 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                                                 context.NguoiTao

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(136, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(137);
                            __builder5.AddAttribute(138, "DataLabel", "GhiChu");
                            __builder5.AddAttribute(139, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(140, 
#nullable restore
#line 58 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
                                               context.GhiChu

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        , 141, (__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudTablePager>(142);
                            __builder5.AddAttribute(143, "PageSizeOptions", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32[]>(
#nullable restore
#line 61 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
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
#line 70 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Quotation\ListQuotation.razor"
       
    private string searchString;
    private bool hover = true;

    Quatation[] quatation = new Quatation[]
        {
            new Quatation { SoBaoGia = "HN", LoaiHinh = "Hà Nội", MaKhachHang = "a" , TenKhachHang = "Việt Nam", NguoiPhuTrach = "1" ,CangBoc="", CangDo = "a" , TrangThai = "Việt Nam", NguoiTao = "1" ,GhiChu=""},
            new Quatation { SoBaoGia = "HN", LoaiHinh = "Hà Nội", MaKhachHang = "a" , TenKhachHang = "Việt Nam", NguoiPhuTrach = "1" ,CangBoc="", CangDo = "a" , TrangThai = "Việt Nam", NguoiTao = "1" ,GhiChu=""},
            new Quatation { SoBaoGia = "HN", LoaiHinh = "Hà Nội", MaKhachHang = "a" , TenKhachHang = "Việt Nam", NguoiPhuTrach = "1" ,CangBoc="", CangDo = "a" , TrangThai = "Việt Nam", NguoiTao = "1" ,GhiChu=""},
                };

    class Quatation
    {
        public string SoBaoGia;
        public string LoaiHinh;
        public string MaKhachHang;
        public string TenKhachHang;
        public string NguoiPhuTrach;
        public string CangBoc;
        public string CangDo;
        public string TrangThai;
        public string NguoiTao;
        public string GhiChu;
    }

    private HashSet<Quatation> selectedItems1 = new HashSet<Quatation>();
    private IEnumerable<Quatation> Elements = new List<Quatation>();
    protected override async Task OnInitializedAsync()
    {
        Elements = quatation;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
namespace __Blazor.TestMudBlazor.Pages.Quotation.ListQuotation
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