#pragma checksum "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c96a1e8ce9cb9cf6e161bdb10755088418c5b07"
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
#line 1 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    public partial class DialogInfoBank : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudDialog>(0);
            __builder.AddAttribute(1, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(2);
                __builder2.AddAttribute(3, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 6 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Style", "margin-top: 10px");
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(7, 
#nullable restore
#line 6 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                                                              lang.Keys["ThongTinNganHang"]

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
#line 8 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                 6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                        6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.TestMudBlazor.Pages.DiaLog.DialogInfoBank.TypeInference.CreateMudTextField_0(__builder4, 17, 18, 
#nullable restore
#line 9 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                                               lang.Keys["SoTaiKhoan"]

#line default
#line hidden
#nullable disable
                        , 19, 
#nullable restore
#line 9 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                                                                                 Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 20, 
#nullable restore
#line 9 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                           SoTaiKhoan

#line default
#line hidden
#nullable disable
                        , 21, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SoTaiKhoan = __value, SoTaiKhoan)));
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(23);
                    __builder3.AddAttribute(24, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                 6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                        6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.TestMudBlazor.Pages.DiaLog.DialogInfoBank.TypeInference.CreateMudTextField_1(__builder4, 28, 29, 
#nullable restore
#line 12 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                                                lang.Keys["ChuTaiKhoan"]

#line default
#line hidden
#nullable disable
                        , 30, 
#nullable restore
#line 12 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                                                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 31, 
#nullable restore
#line 12 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                           ChuTaiKhoan

#line default
#line hidden
#nullable disable
                        , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ChuTaiKhoan = __value, ChuTaiKhoan)));
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
#line 17 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                 6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                        6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.TestMudBlazor.Pages.DiaLog.DialogInfoBank.TypeInference.CreateMudSelect_2(__builder4, 41, 42, 
#nullable restore
#line 18 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                   lang.Keys["NganHang"]

#line default
#line hidden
#nullable disable
                        , 43, 
#nullable restore
#line 18 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                                                  true

#line default
#line hidden
#nullable disable
                        , 44, 
#nullable restore
#line 18 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                                                                                        Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 45, "F2", 46, 
#nullable restore
#line 18 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                                                                     NganHang

#line default
#line hidden
#nullable disable
                        , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NganHang = __value, NganHang)), 48, (__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudSelectItem<bool>>(49);
                            __builder5.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 19 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                                   false

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(52, "a");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(53, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudSelectItem<bool>>(54);
                            __builder5.AddAttribute(55, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 20 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                                   true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(57, "b");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(59);
                    __builder3.AddAttribute(60, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(61, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                 6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(62, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                        6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.TestMudBlazor.Pages.DiaLog.DialogInfoBank.TypeInference.CreateMudSelect_3(__builder4, 64, 65, 
#nullable restore
#line 24 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                   lang.Keys["LoaiTienTe"]

#line default
#line hidden
#nullable disable
                        , 66, 
#nullable restore
#line 24 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                                                    true

#line default
#line hidden
#nullable disable
                        , 67, 
#nullable restore
#line 24 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                                                                                            Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 68, "F2", 69, 
#nullable restore
#line 24 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                                                                       LoaiTienTe

#line default
#line hidden
#nullable disable
                        , 70, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LoaiTienTe = __value, LoaiTienTe)), 71, (__builder5) => {
                            __Blazor.TestMudBlazor.Pages.DiaLog.DialogInfoBank.TypeInference.CreateMudSelectItem_4(__builder5, 72, 73, 
#nullable restore
#line 25 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                          'a'

#line default
#line hidden
#nullable disable
                            , 74, (__builder6) => {
                                __builder6.AddContent(75, "a");
                            }
                            );
                            __builder5.AddMarkupContent(76, "\r\n                    ");
                            __Blazor.TestMudBlazor.Pages.DiaLog.DialogInfoBank.TypeInference.CreateMudSelectItem_5(__builder5, 77, 78, 
#nullable restore
#line 26 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                          'a'

#line default
#line hidden
#nullable disable
                            , 79, (__builder6) => {
                                __builder6.AddContent(80, "b");
                            }
                            );
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
            __builder.AddAttribute(81, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(82);
                __builder2.AddAttribute(83, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                            Cancel

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(85, 
#nullable restore
#line 34 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                     lang.Keys["Cancel"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(87);
                __builder2.AddAttribute(88, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 35 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                          Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
                                                  Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(91, 
#nullable restore
#line 35 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
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
#line 38 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\DiaLog\DialogInfoBank.razor"
       
    public string ChuTaiKhoan { get; set; }
    public string SoTaiKhoan { get; set; }
    public string NganHang { get; set; }
    public string LoaiTienTe { get; set; }
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
namespace __Blazor.TestMudBlazor.Pages.DiaLog.DialogInfoBank
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
        public static void CreateMudSelect_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::MudBlazor.Variant __arg2, int __seq3, global::System.String __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
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
        public static void CreateMudSelect_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::MudBlazor.Variant __arg2, int __seq3, global::System.String __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
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
        public static void CreateMudSelectItem_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
