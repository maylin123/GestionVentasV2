#pragma checksum "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff258f3dc00f69145a17dc5111fe7bfa7730731e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Establecimiento_Details), @"mvc.1.0.view", @"/Views/Establecimiento/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff258f3dc00f69145a17dc5111fe7bfa7730731e", @"/Views/Establecimiento/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b77fd6673dc6d104944a08bc6e27379bd410ddb", @"/Views/_ViewImports.cshtml")]
    public class Views_Establecimiento_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestionVentasV2.Models.establecimiento>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
  
    ViewData["Title"] = "Establecimientos";
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
            <h1 data-animate=""fadeInUp"">Establecimientos</h1>
            <span data-animate=""fadeInUp"" data-delay=""300""></span>
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""#"">Administraci??n</a></li>
                <li class=""breadcrumb-item""><a>Establecimientos</a></li>
                <!--<li class=""breadcrumb-item active"" aria-current=""page"">Page Titles</li>-->
            </ol>
        </div>

    </section><!-- #page-title end -->
");
            }
            );
            WriteLiteral("\r\n\r\n<div class=\"container clearfix\">\r\n    <h3>Detalle de establecimiento</h3>\r\n    <hr />\r\n    <div>\r\n\r\n\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 38 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.razonSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 41 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayFor(model => model.razonSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 44 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.nombreComercial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 47 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayFor(model => model.nombreComercial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 50 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.descripcionGeneral));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 53 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayFor(model => model.descripcionGeneral));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 56 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.nit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 59 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayFor(model => model.nit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 62 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.correoElectronico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 65 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayFor(model => model.correoElectronico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 68 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.direccionFiscal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 71 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayFor(model => model.direccionFiscal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 74 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.direccionMobiliaria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 77 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayFor(model => model.direccionMobiliaria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 80 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 83 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayFor(model => model.telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 86 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.estados_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 89 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayFor(model => model.estados_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 92 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.usuarioCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 95 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayFor(model => model.usuarioCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 98 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.fechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 101 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayFor(model => model.fechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 104 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.usuarioActualizacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 107 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayFor(model => model.usuarioActualizacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 110 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.fechaActualizacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 113 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
           Write(Html.DisplayFor(model => model.fechaActualizacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff258f3dc00f69145a17dc5111fe7bfa7730731e14493", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 118 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Establecimiento\Details.cshtml"
                               WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff258f3dc00f69145a17dc5111fe7bfa7730731e16662", async() => {
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
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GestionVentasV2.Models.establecimiento> Html { get; private set; }
    }
}
#pragma warning restore 1591
