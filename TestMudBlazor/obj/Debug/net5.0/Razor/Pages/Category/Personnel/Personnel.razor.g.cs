#pragma checksum "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "390cf3213ce516e125365069309e45779327c480"
// <auto-generated/>
#pragma warning disable 1591
namespace TestMudBlazor.Pages.Category.Personnel
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
#line 2 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addpersonnel")]
    public partial class Personnel : Microsoft.AspNetCore.Components.ComponentBase
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
#line 6 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
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
#line 7 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                                     Typo.h5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(11, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                                                            true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(13, "Thêm mới nhân sự");
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
#line 9 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
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
#line 12 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
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
#line 13 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
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
#line 14 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
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
#line 19 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(36);
                        __builder4.AddAttribute(37, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 22 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                              model

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(38, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 22 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
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
#line 24 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(44, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 24 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(45, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 24 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                                6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.TestMudBlazor.Pages.Category.Personnel.Personnel.TypeInference.CreateMudTextField_0(__builder7, 47, 48, "Mã (*)", 49, 
#nullable restore
#line 25 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                                                                     Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 50, 
#nullable restore
#line 25 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                                                                                              () => model.ma

#line default
#line hidden
#nullable disable
                                    , 51, 
#nullable restore
#line 25 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                                   model.ma

#line default
#line hidden
#nullable disable
                                    , 52, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.ma = __value, model.ma)));
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(53, "\r\n\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(54);
                                __builder6.AddAttribute(55, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(56, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                         6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(57, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                                6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.TestMudBlazor.Pages.Category.Personnel.Personnel.TypeInference.CreateMudTextField_1(__builder7, 59, 60, "Tên", 61, 
#nullable restore
#line 29 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 62, 
#nullable restore
#line 29 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                                                                                            () => model.ten

#line default
#line hidden
#nullable disable
                                    , 63, 
#nullable restore
#line 29 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                                   model.ten

#line default
#line hidden
#nullable disable
                                    , 64, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.ten = __value, model.ten)));
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(65, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudGrid>(66);
                            __builder5.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(68);
                                __builder6.AddAttribute(69, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 33 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(70, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 33 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                         12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(71, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 33 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __Blazor.TestMudBlazor.Pages.Category.Personnel.Personnel.TypeInference.CreateMudTextField_2(__builder7, 73, 74, "Địa chỉ", 75, 
#nullable restore
#line 34 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                                                                          Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 76, 
#nullable restore
#line 34 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                                                                                                   () => model.diachi

#line default
#line hidden
#nullable disable
                                    , 77, 
#nullable restore
#line 34 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                                   model.diachi

#line default
#line hidden
#nullable disable
                                    , 78, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.diachi = __value, model.diachi)));
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(79, "\r\n\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudGrid>(80);
                            __builder5.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(82);
                                __builder6.AddAttribute(83, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(84, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                         12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(85, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                                 6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudCheckBox<bool>>(87);
                                    __builder7.AddAttribute(88, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 42 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                                        true

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(89, "RequiredError", "You must agree");
                                    __builder7.AddAttribute(90, "Class", "ml-n2");
                                    __builder7.AddAttribute(91, "Label", "Hoạt động");
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(92, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudGrid>(93);
                            __builder5.AddAttribute(94, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(95);
                                __builder6.AddAttribute(96, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 47 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudText>(98);
                                    __builder7.AddAttribute(99, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 48 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                        Align.Center

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(100, "Style", "color: red");
                                    __builder7.AddAttribute(101, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
                                                                                       true

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(102, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(103, "\"Vui lòng nhập thông tin, các ô có dấu (*) là bắt buộc\"");
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
#line 58 "C:\Project\FontEnd\Blazor\MudblazorTest\TestMudBlazor\Pages\Category\Personnel\Personnel.razor"
       

    Form model = new Form();
    public class Form
    {
        [Required(ErrorMessage = "Nhập mã!")]
        //[StringLength(8, ErrorMessage = "Name length can't be more than 8.")]
        public string ma { get; set; }

        public string ten { get; set; }
        public string diachi { get; set; }
        public string yt { get; set; }



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
namespace __Blazor.TestMudBlazor.Pages.Category.Personnel.Personnel
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