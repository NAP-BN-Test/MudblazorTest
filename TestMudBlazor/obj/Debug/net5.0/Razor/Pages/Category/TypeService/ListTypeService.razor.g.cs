#pragma checksum "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c228ba33aec362c96cc29376f4d29dee0450ed33"
// <auto-generated/>
#pragma warning disable 1591
namespace TestMudBlazor.Pages.Category.TypeService
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
#line 1 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listtypeservice")]
    public partial class ListTypeService : Microsoft.AspNetCore.Components.ComponentBase
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
#line 17 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
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
#line 18 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
                           Typo.h5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(12, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
                                                  true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(14, 
#nullable restore
#line 18 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
                                                         lang.Keys["Code"]

#line default
#line hidden
#nullable disable
                            );
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
#line 20 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudToolBar>(19);
                        __builder4.AddAttribute(20, "Class", "toolbarCustom");
                        __builder4.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __Blazor.TestMudBlazor.Pages.Category.TypeService.ListTypeService.TypeInference.CreateMudTextField_0(__builder5, 22, 23, "width: 50%", 24, 
#nullable restore
#line 22 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
                                                                                          lang.Keys["Code"]

#line default
#line hidden
#nullable disable
                            , 25, 
#nullable restore
#line 22 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
                                                                                                                        Adornment.Start

#line default
#line hidden
#nullable disable
                            , 26, 
#nullable restore
#line 22 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
                                                                                                                                                         Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                            , 27, 
#nullable restore
#line 22 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
                                                                                                                                                                                                 Size.Medium

#line default
#line hidden
#nullable disable
                            , 28, "mt-0 searchcutom", 29, 
#nullable restore
#line 22 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
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
                            __builder5.AddAttribute(35, "Href", "/addservice");
                            __builder5.AddAttribute(36, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 24 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
                                                  Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudIconButton>(38);
                                __builder6.AddAttribute(39, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
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
#line 25 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
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
#line 26 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
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
#line 27 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
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
#line 35 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.TestMudBlazor.Pages.Category.TypeService.ListTypeService.TypeInference.CreateMudTable_1(__builder4, 55, 56, 
#nullable restore
#line 36 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
                              Elements

#line default
#line hidden
#nullable disable
                        , 57, 
#nullable restore
#line 36 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
                                                        true

#line default
#line hidden
#nullable disable
                        , 58, 
#nullable restore
#line 36 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
                                                                                                           hover

#line default
#line hidden
#nullable disable
                        , 59, 
#nullable restore
#line 36 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
                                                                                   selectedItems1

#line default
#line hidden
#nullable disable
                        , 60, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItems1 = __value, selectedItems1)), 61, (__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudTh>(62);
                            __builder5.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(64, 
#nullable restore
#line 38 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
                            lang.Keys["Code"]

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(65, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(66);
                            __builder5.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(68, 
#nullable restore
#line 39 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
                            lang.Keys["Code"]

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(69, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(70);
                            __builder5.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(72, 
#nullable restore
#line 40 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
                            lang.Keys["Code"]

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        , 73, (context) => (__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudTd>(74);
                            __builder5.AddAttribute(75, "DataLabel", "Ma");
                            __builder5.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(77, 
#nullable restore
#line 43 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
                                           context.Ma

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(78, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(79);
                            __builder5.AddAttribute(80, "DataLabel", "Ten");
                            __builder5.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(82, 
#nullable restore
#line 44 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
                                            context.Ten

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(83, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(84);
                            __builder5.AddAttribute(85, "DataLabel", "GhiChu");
                            __builder5.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(87, 
#nullable restore
#line 45 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
                                               context.GhiChu

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        , 88, (__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudTablePager>(89);
                            __builder5.AddAttribute(90, "PageSizeOptions", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32[]>(
#nullable restore
#line 48 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
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
#line 57 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\ListTypeService.razor"
       
    private bool hover = true;
    private string searchString;
    ServiceDetail[] serviceDetails = new ServiceDetail[]
{
        new ServiceDetail { Ma = "DV01", Ten = "Vận Chuyển",  GhiChu = "a", },
        new ServiceDetail { Ma = "DV02", Ten = "Vận Chuyển",  GhiChu = "a", },
        new ServiceDetail { Ma = "DV03", Ten = "Vận Chuyển",  GhiChu = "a", },
                        };

    class ServiceDetail
    {
        public string Ma;
        public string Ten;
        public string GhiChu;
    }

    private HashSet<ServiceDetail> selectedItems1 = new HashSet<ServiceDetail>();
    private IEnumerable<ServiceDetail> Elements = new List<ServiceDetail>();
    protected override async Task OnInitializedAsync()
    {
        Elements = serviceDetails;
        lang.InitLocalizedComponent(this);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILanguageContainerService lang { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
namespace __Blazor.TestMudBlazor.Pages.Category.TypeService.ListTypeService
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
