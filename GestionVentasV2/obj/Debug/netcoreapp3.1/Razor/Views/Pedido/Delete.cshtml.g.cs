#pragma checksum "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a728a3d33e3139673fba02ab292f121e67ae932"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Delete), @"mvc.1.0.view", @"/Views/Pedido/Delete.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\_ViewImports.cshtml"
using GestionVentasV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\_ViewImports.cshtml"
using GestionVentasV2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a728a3d33e3139673fba02ab292f121e67ae932", @"/Views/Pedido/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b77fd6673dc6d104944a08bc6e27379bd410ddb", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestionVentasV2.Models.pedido>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "_LayoutEstablecimiento";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("TituloPrincipal", async() => {
                WriteLiteral(@"
    <!-- Page Title
            ============================================= -->
    <section id=""page-title"" style=""background-color:#9dccd6;"">

        <div class=""container clearfix"">
            <h1 data-animate=""fadeInUp"">Pedidos</h1>
            <span data-animate=""fadeInUp"" data-delay=""300"">");
#nullable restore
#line 16 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
                                                      Write(ViewBag.Establecimiento);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""#"">Administración</a></li>
                <li class=""breadcrumb-item""><a>Prodcutos</a></li>
                <!--<li class=""breadcrumb-item active"" aria-current=""page"">Page Titles</li>-->
            </ol>
        </div>

    </section><!-- #page-title end -->
");
            }
            );
            WriteLiteral("\r\n\r\n<div class=\"container clearfix\">\r\n\r\n    <h1>Está seguro de ");
#nullable restore
#line 30 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
                   Write(Model.estados_id== 1 ? "deshabilitar" : "habilitar");

#line default
#line hidden
#nullable disable
            WriteLiteral(" el pedido?</h1>\r\n    <div>\r\n        <h4>pedido</h4>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 36 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 39 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
           Write(Html.DisplayFor(model => model.fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 42 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.nombreCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 45 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
           Write(Html.DisplayFor(model => model.nombreCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 48 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.direccionEntrega));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 51 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
           Write(Html.DisplayFor(model => model.direccionEntrega));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 54 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 57 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
           Write(Html.DisplayFor(model => model.telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 60 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 63 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
           Write(Html.DisplayFor(model => model.correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 66 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.usuarioCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 69 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
           Write(Html.DisplayFor(model => model.usuarioCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 72 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.fechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 75 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
           Write(Html.DisplayFor(model => model.fechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 78 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.usuarioActualizacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 81 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
           Write(Html.DisplayFor(model => model.usuarioActualizacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 84 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.fechaActualizacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 87 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
           Write(Html.DisplayFor(model => model.fechaActualizacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 90 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.estados_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 93 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
           Write(Html.DisplayFor(model => model.estados_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n        </dl>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a728a3d33e3139673fba02ab292f121e67ae93213293", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9a728a3d33e3139673fba02ab292f121e67ae93213564", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 99 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 3601, "\"", 3663, 1);
#nullable restore
#line 100 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
WriteAttributeValue("", 3609, Model.estados_id== 1 ? "Deshabilitar" : "Habilitar", 3609, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 3664, "\"", 3730, 2);
                WriteAttributeValue("", 3672, "btn", 3672, 3, true);
#nullable restore
#line 100 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Delete.cshtml"
WriteAttributeValue(" ", 3675, Model.estados_id== 1 ? "btn-danger" : "btn-success", 3676, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> |\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a728a3d33e3139673fba02ab292f121e67ae93216210", async() => {
                    WriteLiteral("Regresar a la lista");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GestionVentasV2.Models.pedido> Html { get; private set; }
    }
}
#pragma warning restore 1591
