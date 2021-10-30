#pragma checksum "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfbf6a11c330c2a552a35d28707a7d6ca4f6d885"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Details), @"mvc.1.0.view", @"/Views/Pedido/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfbf6a11c330c2a552a35d28707a7d6ca4f6d885", @"/Views/Pedido/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b77fd6673dc6d104944a08bc6e27379bd410ddb", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestionVentasV2.Models.pedido>
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
#line 3 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Details.cshtml"
  
    ViewData["Title"] = "Detalle Pedido";
    Layout = "_LayoutEstablecimiento";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("TituloPrincipal", async() => {
                WriteLiteral(@"
    <!-- Page Title
            ============================================= -->
    <section id=""page-title"" style=""background-color:#9dccd6;"">

        <div class=""container clearfix"">
            <h1 data-animate=""fadeInUp"">Pedidos</h1>
            <span data-animate=""fadeInUp"" data-delay=""300"">");
#nullable restore
#line 17 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Details.cshtml"
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
            WriteLiteral("\r\n\r\n<div class=\"container clearfix\">\r\n\r\n    <h3>Detalle Pedido</h3>\r\n\r\n    <div>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                Fecha\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 40 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Details.cshtml"
           Write(Html.DisplayFor(model => model.fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Nombre cliente\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 46 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Details.cshtml"
           Write(Html.DisplayFor(model => model.nombreCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt class=\"col-sm-2\">\r\n                Nit\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 53 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Details.cshtml"
           Write(Html.DisplayFor(model => model.nit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Dirección Entrega\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 59 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Details.cshtml"
           Write(Html.DisplayFor(model => model.direccionEntrega));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                ");
#nullable restore
#line 60 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Details.cshtml"
           Write(Html.DisplayFor(model => model.municipio));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                ");
#nullable restore
#line 61 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Details.cshtml"
           Write(Html.DisplayFor(model => model.departamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Teléfono\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 67 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Details.cshtml"
           Write(Html.DisplayFor(model => model.telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Correo Electrónico\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 73 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Details.cshtml"
           Write(Html.DisplayFor(model => model.correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt class=\"col-sm-2\">\r\n                Estado\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 80 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Details.cshtml"
           Write(Html.DisplayFor(model => model.estados.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt class=\"col-sm-2\">\r\n                Total\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                Q ");
#nullable restore
#line 87 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Details.cshtml"
             Write(ViewBag.totalPedido);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </dd>
        </dl>
    </div>

    <div class=""table-responsive"">
        <table class=""table cart"">
            <thead>
                <tr>
                    <th class=""cart-product-thumbnail"">&nbsp;</th>
                    <th class=""cart-product-quantity"">Cantidad</th>
                    <th class=""cart-product-name"">Nombre del producto</th>
                    <th class=""cart-product-name"">Precio</th>
                    <th class=""cart-product-subtotal"">Total</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 104 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Details.cshtml"
                 foreach (var item in (IEnumerable<GestionVentasV2.Models.ViewModels.productoVM>)ViewBag.detalle)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"cart_item\">\r\n                        <td class=\"cart-product-thumbnail\">\r\n                            <a href=\"#\"><img width=\"64\" height=\"64\"");
            BeginWriteAttribute("src", " src=\"", 3530, "\"", 3553, 2);
            WriteAttributeValue("", 3536, "/", 3536, 1, true);
#nullable restore
#line 108 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Details.cshtml"
WriteAttributeValue("", 3537, item.pathImagen, 3537, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Pink Printed Dress\"></a>\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
#nullable restore
#line 112 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Details.cshtml"
                       Write(item.cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"cart-product-name\">\r\n                            ");
#nullable restore
#line 115 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Details.cshtml"
                       Write(item.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"cart-vproduct-name\">\r\n                            Q ");
#nullable restore
#line 118 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Details.cshtml"
                         Write(item.precioVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td class=\"cart-product-name\">\r\n                            <a href=\"#\">Q ");
#nullable restore
#line 122 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Details.cshtml"
                                     Write(item.subTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 125 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>    \r\n\r\n\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfbf6a11c330c2a552a35d28707a7d6ca4f6d88512782", async() => {
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
#line 132 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\Details.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfbf6a11c330c2a552a35d28707a7d6ca4f6d88514942", async() => {
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
