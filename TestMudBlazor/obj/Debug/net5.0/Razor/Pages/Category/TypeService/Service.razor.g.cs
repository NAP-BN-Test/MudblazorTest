#pragma checksum "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bee17721594459669675fd42414df45cb34e9e50"
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
#line 2 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addservice")]
    public partial class Service : Microsoft.AspNetCore.Components.ComponentBase
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
#line 8 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
                        __builder4.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                              model

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
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
#line 14 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
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
#line 15 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                                                 Typo.h5

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(22, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddContent(24, 
#nullable restore
#line 15 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                                                                               lang.Keys["AddService"]

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
#line 17 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
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
#line 20 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                                  Icons.Material.Outlined.Add

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(35, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 20 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
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
#line 21 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
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
#line 22 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
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
#line 27 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(47, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 27 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(48, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 27 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                                6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.TestMudBlazor.Pages.Category.TypeService.Service.TypeInference.CreateMudTextField_0(__builder7, 50, 51, 
#nullable restore
#line 28 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                                                     lang.Keys["Ma"]

#line default
#line hidden
#nullable disable
                                    , 52, 
#nullable restore
#line 28 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                                                                               Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 53, 
#nullable restore
#line 28 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                                                                                                        () => model.Ma

#line default
#line hidden
#nullable disable
                                    , 54, 
#nullable restore
#line 28 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
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
#line 31 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(59, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 31 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(60, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 31 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                                6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.TestMudBlazor.Pages.Category.TypeService.Service.TypeInference.CreateMudTextField_1(__builder7, 62, 63, 
#nullable restore
#line 32 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                                                      lang.Keys["Ten"]

#line default
#line hidden
#nullable disable
                                    , 64, 
#nullable restore
#line 32 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                                                                                 Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 65, 
#nullable restore
#line 32 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                                                                                                          () => model.Ten

#line default
#line hidden
#nullable disable
                                    , 66, 
#nullable restore
#line 32 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                                   model.Ten

#line default
#line hidden
#nullable disable
                                    , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Ten = __value, model.Ten)));
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(68, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudGrid>(69);
                            __builder5.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(71);
                                __builder6.AddAttribute(72, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 36 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(73, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 36 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                         12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(74, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 36 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.TestMudBlazor.Pages.Category.TypeService.Service.TypeInference.CreateMudTextField_2(__builder7, 76, 77, 
#nullable restore
#line 37 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                                                         lang.Keys["GhiChu"]

#line default
#line hidden
#nullable disable
                                    , 78, 
#nullable restore
#line 37 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                                                                                       Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 79, 
#nullable restore
#line 37 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                                                                                                                () => model.GhiChu

#line default
#line hidden
#nullable disable
                                    , 80, 
#nullable restore
#line 37 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                                   model.GhiChu

#line default
#line hidden
#nullable disable
                                    , 81, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.GhiChu = __value, model.GhiChu)));
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(82, "\r\n\r\n\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudGrid>(83);
                            __builder5.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(85);
                                __builder6.AddAttribute(86, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 44 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudText>(88);
                                    __builder7.AddAttribute(89, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 45 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                        Align.Center

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(90, "Style", "color: red");
                                    __builder7.AddAttribute(91, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 45 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
                                                                                       true

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(93, "\"Vui l??ng nh???p th??ng tin, c??c ?? c?? d???u (*) l?? b???t bu???c\"");
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
#line 55 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\TypeService\Service.razor"
       

    ServiceDetail model = new ServiceDetail();
    public class ServiceDetail
    {
        [Required(ErrorMessage = "Nh???p m??!")]
        //[StringLength(8, ErrorMessage = "Name length can't be more than 8.")]
        public string Ma { get; set; }
        public string Ten { get; set; }
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
namespace __Blazor.TestMudBlazor.Pages.Category.TypeService.Service
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
    }
}
#pragma warning restore 1591
