#pragma checksum "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\CrearPedido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "999983f39e445dc01d5496cc1c3e60706ea751ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_CrearPedido), @"mvc.1.0.view", @"/Views/Pedido/CrearPedido.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"999983f39e445dc01d5496cc1c3e60706ea751ee", @"/Views/Pedido/CrearPedido.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b77fd6673dc6d104944a08bc6e27379bd410ddb", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_CrearPedido : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestionVentasV2.Models.ViewModels.productoVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("accordion-content clearfix"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RegistrarPedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\CrearPedido.cshtml"
  
    ViewData["Title"] = "Generar Pedido";
    Layout = "_LayoutPublic";
  

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("TituloPrincipal", async() => {
                WriteLiteral(@"
    <!-- Page Title
            ============================================= -->
    <section id=""page-title"" style=""background-image: url('../imagenes/header/headerbg.jpeg'); padding: 120px 0;"" data-bottom-top=""background-position:0px 300px;"" data-top-bottom=""background-position:0px -300px;"">

        <div class=""container clearfix"">
            <h1 data-animate=""fadeInUp"">Generar Nuevo pedido</h1>
            <!--<span data-animate=""fadeInUp"" data-delay=""300"">A Short Page Title Tagline</span>-->
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""#"">Inicio</a></li>
                <li class=""breadcrumb-item""><a href=""#"">");
#nullable restore
#line 23 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\CrearPedido.cshtml"
                                                   Write(ViewBag.datosEstablecimiento.nombreComercial);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n                <!--<li class=\"breadcrumb-item active\" aria-current=\"page\">Page Titles</li> -->\r\n            </ol>\r\n        </div>\r\n\r\n    </section><!-- #page-title end -->\r\n");
            }
            );
            WriteLiteral(@"<div class=""container clearfix"">
    <div class=""row col-mb-50 gutter-50"">
        <div class=""col-lg-6"">
            <h4>Detalle del pedido</h4>

            <div class=""table-responsive"">
                <table class=""table cart"">
                    <thead>
                        <tr>
                            <th class=""cart-product-thumbnail"">&nbsp;</th>
                            <th class=""cart-product-name"">Nombre del producto</th>
                            <th class=""cart-product-quantity"">Cantidad</th>
                            <th class=""cart-product-subtotal"">Total</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr class=""cart_item"">
                            <td class=""cart-product-thumbnail"">
                                <a href=""#""><img width=""64"" height=""64""");
            BeginWriteAttribute("src", " src=\"", 2088, "\"", 2112, 2);
            WriteAttributeValue("", 2094, "/", 2094, 1, true);
#nullable restore
#line 48 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\CrearPedido.cshtml"
WriteAttributeValue("", 2095, Model.pathImagen, 2095, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Pink Printed Dress\"></a>\r\n                            </td>\r\n\r\n                            <td class=\"cart-product-name\">\r\n                                <a href=\"#\">");
#nullable restore
#line 52 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\CrearPedido.cshtml"
                                       Write(Model.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </td>\r\n\r\n                            <td class=\"cart-product-quantity\">\r\n                                <div class=\"quantity clearfix\">\r\n                                    ");
#nullable restore
#line 57 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\CrearPedido.cshtml"
                               Write(Model.cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n\r\n                            <td class=\"cart-product-subtotal\">\r\n                                <span class=\"amount\">Q ");
#nullable restore
#line 62 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\CrearPedido.cshtml"
                                                  Write(Model.subTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </td>
                        </tr>
                    </tbody>

                </table>
            </div>
        </div>

        <div class=""col-lg-6"">
            <h4>Totales</h4>

            <div class=""table-responsive"">
                <table class=""table cart"">
                    <tbody>
                        <!--
                        <tr class=""cart_item"">
                            <td class=""border-top-0 cart-product-name"">
                                <strong>Total pedido</strong>
                            </td>

                            <td class=""border-top-0 cart-product-name"">
                                <span class=""amount"">$106.94</span>
                            </td>
                        </tr>-->


                        <tr class=""cart_item"">
                            <td class=""cart-product-name"">
                                <strong>Total Pedido</strong>
                            </td>
");
            WriteLiteral("\r\n                            <td class=\"cart-product-name\">\r\n                                <span class=\"amount color lead\"><strong>Q ");
#nullable restore
#line 95 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\CrearPedido.cshtml"
                                                                     Write(Model.subTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></span>
                            </td>
                        </tr>

                        <tr class=""cart_item"">
                            <td class=""cart-product-name"">
                                <strong>Costo de env??o (pago adicional)</strong>
                            </td>

                            <td class=""cart-product-name"">
                                <span class=""amount"">Q 30.00</span>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>

            <div class=""accordion clearfix"">
                <div class=""accordion-header"">
                    <div class=""accordion-icon"">
                        <i class=""accordion-closed icon-line-minus""></i>
                        <i class=""accordion-open icon-line-check""></i>
                    </div>
                    <div class=""accordion-title"">
                        Pago contra entrega
                    </di");
            WriteLiteral("v>\r\n                </div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "999983f39e445dc01d5496cc1c3e60706ea751ee11348", async() => {
                WriteLiteral(@"
                    Pagas al momento de recibir tus productos.

                    <h4 class=""mt-3"">Datos del cliente</h4>

                    <div class=""row"">
                        <div class=""col-md-6 form-group"">
                            <label for=""billing-form-name"">Nombre del cliente</label>
                            <input type=""text"" id=""billing-form-name"" name=""nombreCliente"" maxlength=""100""");
                BeginWriteAttribute("value", " value=\"", 5494, "\"", 5502, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""sm-form-control"" />
                        </div>

                        <div class=""col-md-6 form-group"">
                            <label for=""billing-form-name"">Nit</label>
                            <input type=""text"" id=""billing-form-name"" name=""nit"" maxlength=""100""");
                BeginWriteAttribute("value", " value=\"", 5793, "\"", 5801, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""sm-form-control"" />
                        </div>

                        <div class=""col-md-6 form-group"">
                            <label for=""billing-form-name"">Direcci??n</label>
                            <input type=""text"" id=""billing-form-name"" name=""direccion"" maxlength=""100""");
                BeginWriteAttribute("value", " value=\"", 6104, "\"", 6112, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"sm-form-control\" />\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n                    <h4 class=\"mt-3\">Datos de env??o</h4>\r\n\r\n                    <input type=\"hidden\" id=\"billing-form-lname\" name=\"cantidad\"");
                BeginWriteAttribute("value", " value=\"", 6346, "\"", 6369, 1);
#nullable restore
#line 147 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\CrearPedido.cshtml"
WriteAttributeValue("", 6354, Model.cantidad, 6354, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"sm-form-control\" />\r\n                    <input type=\"hidden\" id=\"billing-form-lname\" name=\"producto_id\"");
                BeginWriteAttribute("value", " value=\"", 6482, "\"", 6499, 1);
#nullable restore
#line 148 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\CrearPedido.cshtml"
WriteAttributeValue("", 6490, Model.id, 6490, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"sm-form-control\" />\r\n                    <input type=\"hidden\" id=\"billing-form-lname\" name=\"precio\"");
                BeginWriteAttribute("value", " value=\"", 6607, "\"", 6633, 1);
#nullable restore
#line 149 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\CrearPedido.cshtml"
WriteAttributeValue("", 6615, Model.precioVenta, 6615, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"sm-form-control\" />\r\n                    <input type=\"hidden\" id=\"billing-form-lname\" name=\"establecimiento_id\"");
                BeginWriteAttribute("value", " value=\"", 6753, "\"", 6785, 1);
#nullable restore
#line 150 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Pedido\CrearPedido.cshtml"
WriteAttributeValue("", 6761, Model.establecimientoId, 6761, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""sm-form-control"" />


                    <div class=""row"">


                        <div class=""col-md-6 form-group"">
                            <label for=""billing-form-name"">Direcci??n de entrega</label>
                            <input type=""text"" id=""billing-form-name"" name=""direccionEntrega"" maxlength=""100""");
                BeginWriteAttribute("value", " value=\"", 7119, "\"", 7127, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""sm-form-control"" />
                        </div>

                        <div class=""col-md-6 form-group"">
                            <label for=""billing-form-name"">Departamento</label>
                            <input type=""text"" id=""billing-form-name"" name=""departamento"" maxlength=""100""");
                BeginWriteAttribute("value", " value=\"", 7436, "\"", 7444, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""sm-form-control"" />
                        </div>

                        <div class=""col-md-6 form-group"">
                            <label for=""billing-form-lname"">Municipio</label>
                            <input type=""text"" id=""billing-form-lname"" name=""municipio"" maxlength=""100""");
                BeginWriteAttribute("value", " value=\"", 7749, "\"", 7757, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""sm-form-control"" />
                        </div>


                        <div class=""col-md-6 form-group"">
                            <label for=""billing-form-lname"">Tel??fono</label>
                            <input type=""phone"" id=""billing-form-lname"" name=""telefono"" maxlength=""100""");
                BeginWriteAttribute("value", " value=\"", 8063, "\"", 8071, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""sm-form-control"" />
                        </div>

                        <div class=""col-md-6 form-group"">
                            <label for=""billing-form-lname"">Correo electr??nico</label>
                            <input type=""email"" id=""billing-form-lname"" name=""correo"" maxlength=""100""");
                BeginWriteAttribute("value", " value=\"", 8383, "\"", 8391, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"sm-form-control\" />\r\n                        </div>\r\n                    </div>\r\n                    <button type=\"submit\" class=\"button button-3d float-end\">Realizar pedido</button>\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"




            </div>

                <!--<div class=""accordion-header"">
        <div class=""accordion-icon"">
            <i class=""accordion-closed icon-line-minus""></i>
            <i class=""accordion-open icon-line-check""></i>
        </div>
        <div class=""accordion-title"">
            Cheque Payment
        </div>
    </div>
    <div class=""accordion-content clearfix"">Integer posuere erat a ante venenatis dapibus posuere velit aliquet. Duis mollis, est non commodo luctus. Aenean lacinia bibendum nulla sed consectetur. Cras mattis consectetur purus sit amet fermentum.</div>

    <div class=""accordion-header"">
        <div class=""accordion-icon"">
            <i class=""accordion-closed icon-line-minus""></i>
            <i class=""accordion-open icon-line-check""></i>
        </div>
        <div class=""accordion-title"">
            Paypal
        </div>
    </div>
    <div class=""accordion-content clearfix"">Nullam id dolor id nibh ultricies vehicula ut id elit. Integer posuere");
            WriteLiteral(" erat a ante venenatis dapibus posuere velit aliquet. Duis mollis, est non commodo luctus. Aenean lacinia bibendum nulla sed consectetur.</div>-->\r\n            </div>\r\n            \r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GestionVentasV2.Models.ViewModels.productoVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
