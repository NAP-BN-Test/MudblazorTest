#pragma checksum "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36577cd1f6df2d6a9e7b89e31bee45f768bc6e1b"
// <auto-generated/>
#pragma warning disable 1591
namespace TestMudBlazor.Pages.Category.Rules
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
#line 2 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addrules")]
    public partial class Rules : Microsoft.AspNetCore.Components.ComponentBase
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
#line 7 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
                        __builder4.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                              model

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
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
#line 13 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
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
#line 14 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                                                 Typo.h5

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(22, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(24, "Thêm mới điều khoản");
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
#line 16 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
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
#line 19 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                                  Icons.Material.Outlined.Add

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(35, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 19 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
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
#line 20 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
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
#line 21 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
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
#line 27 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(47, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 27 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(48, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 27 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                                6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.TestMudBlazor.Pages.Category.Rules.Rules.TypeInference.CreateMudTextField_0(__builder7, 50, 51, "Tên", 52, 
#nullable restore
#line 28 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 53, 
#nullable restore
#line 28 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                                                                                            () => model.Ten

#line default
#line hidden
#nullable disable
                                    , 54, 
#nullable restore
#line 28 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                                   model.Ten

#line default
#line hidden
#nullable disable
                                    , 55, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Ten = __value, model.Ten)));
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(56, "\r\n\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(57);
                                __builder6.AddAttribute(58, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 31 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(59, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 31 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                         12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(60, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 31 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                                 6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudAutocomplete<string>>(62);
                                    __builder7.AddAttribute(63, "Label", "Loại");
                                    __builder7.AddAttribute(64, "SearchFunc", new System.Func<System.String, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>>>(
#nullable restore
#line 32 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                                                                                       Search1

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(65, "ResetValueOnEmptyText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                                                 resetValueOnEmptyText

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(66, "CoerceText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                                      coerceText

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(67, "CoerceValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                                                                coerceValue

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(68, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 34 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                                                                                      Variant.Outlined

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(69, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(
#nullable restore
#line 34 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                                                                                                               () => model.Loai

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(70, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 32 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                                                              model.Loai

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(71, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Loai = __value, model.Loai))));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(72, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudGrid>(73);
                            __builder5.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(75);
                                __builder6.AddAttribute(76, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 40 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(77, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 40 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                         12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(78, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 40 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.TestMudBlazor.Pages.Category.Rules.Rules.TypeInference.CreateMudTextField_1(__builder7, 80, 81, "Mô tả", 82, 
#nullable restore
#line 41 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                                                                      Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 83, 
#nullable restore
#line 41 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                                                                                               () => model.MoTa

#line default
#line hidden
#nullable disable
                                    , 84, 
#nullable restore
#line 41 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                                   model.MoTa

#line default
#line hidden
#nullable disable
                                    , 85, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.MoTa = __value, model.MoTa)));
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(86, "\r\n\r\n\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudGrid>(87);
                            __builder5.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(89);
                                __builder6.AddAttribute(90, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 48 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudText>(92);
                                    __builder7.AddAttribute(93, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 49 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                        Align.Center

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(94, "Style", "color: red");
                                    __builder7.AddAttribute(95, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 49 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
                                                                                       true

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(97, "\"Vui lòng nhập thông tin, các ô có dấu (*) là bắt buộc\"");
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
#line 59 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Rules\Rules.razor"
       

    RulesDetail model = new RulesDetail();
    public class RulesDetail
    {
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public string Loai { get; set; }
    }

    bool success;
    string[] errors = { };
    private void OnValidSubmit(EditContext context)
    {
    }

    private string value { get; set; } = "Nothing selected";
    private HashSet<string> options { get; set; } = new HashSet<string>() { "Sale" };

    private string[] states =
    {
        "Sale", "Kế toán", "Maketing",
    };



    private bool resetValueOnEmptyText;
    private bool coerceText;
    private bool coerceValue;
    private string value1, value2;

    private async Task<IEnumerable<string>> Search1(string value)
    {
        // In real life use an asynchronous function for fetching data from an api.
        await Task.Delay(5);

        // if text is null or empty, show complete list
        if (string.IsNullOrEmpty(value))
            return states;
        return states.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.TestMudBlazor.Pages.Category.Rules.Rules
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
    }
}
#pragma warning restore 1591
