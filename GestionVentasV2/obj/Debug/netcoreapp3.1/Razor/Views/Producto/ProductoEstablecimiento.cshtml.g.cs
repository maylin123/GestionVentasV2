#pragma checksum "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Producto\ProductoEstablecimiento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ad0136686c636f4b34a973f038c2b6e43e80991"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_ProductoEstablecimiento), @"mvc.1.0.view", @"/Views/Producto/ProductoEstablecimiento.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ad0136686c636f4b34a973f038c2b6e43e80991", @"/Views/Producto/ProductoEstablecimiento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b77fd6673dc6d104944a08bc6e27379bd410ddb", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_ProductoEstablecimiento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestionVentasV2.Models.ViewModels.productoVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Establecimiento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart mb-0 d-flex justify-content-between align-items-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CrearPedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Producto\ProductoEstablecimiento.cshtml"
  
    Layout = "_LayoutPublic";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("TituloPrincipal", async() => {
                WriteLiteral("\r\n    <!-- Page Title\r\n            ============================================= -->\r\n    <section id=\"page-title\" style=\"background-color:#9dccd6;\">\r\n\r\n        <div class=\"container clearfix\">\r\n            <h1 data-animate=\"fadeInUp\">");
#nullable restore
#line 17 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Producto\ProductoEstablecimiento.cshtml"
                                   Write(Model.nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n            <span data-animate=\"fadeInUp\" data-delay=\"300\"></span>\r\n            <ol class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item\"><a href=\"#\">Inicio</a></li>\r\n                <li class=\"breadcrumb-item\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ad0136686c636f4b34a973f038c2b6e43e809916903", async() => {
#nullable restore
#line 21 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Producto\ProductoEstablecimiento.cshtml"
                                                                                                                                                    Write(Model.nombreEstablecimiento);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-EstablecimientoId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Producto\ProductoEstablecimiento.cshtml"
                                                                                                                   WriteLiteral(Model.idEstablecimiento);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["EstablecimientoId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-EstablecimientoId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["EstablecimientoId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n                <!--<li class=\"breadcrumb-item active\" aria-current=\"page\">Page Titles</li>-->\r\n            </ol>\r\n                    </div>\r\n\r\n                </section><!-- #page-title end -->\r\n");
            }
            );
            WriteLiteral(@"

<div class=""container clearfix"">

    <div class=""single-product"">
        <div class=""product"">
            <div class=""row gutter-40"">

                <div class=""col-md-6"">

                    <!-- Product Single - Gallery
                    ============================================= -->
                    <div class=""product-image"">
                        <div class=""fslider"" data-pagi=""false"" data-arrows=""false"" data-thumbs=""true"">
                            <div class=""flexslider"">
                                <div class=""slider-wrap"" data-lightbox=""gallery"">
                                    <div class=""slide"" data-thumb=""/");
#nullable restore
#line 44 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Producto\ProductoEstablecimiento.cshtml"
                                                               Write(Model.pathImagen);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><a");
            BeginWriteAttribute("href", " href=\"", 1761, "\"", 1786, 2);
            WriteAttributeValue("", 1768, "/", 1768, 1, true);
#nullable restore
#line 44 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Producto\ProductoEstablecimiento.cshtml"
WriteAttributeValue("", 1769, Model.pathImagen, 1769, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1787, "\"", 1823, 2);
#nullable restore
#line 44 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Producto\ProductoEstablecimiento.cshtml"
WriteAttributeValue("", 1795, Model.nombre, 1795, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1808, "data-lightbox=", 1809, 15, true);
            EndWriteAttribute();
            WriteLiteral("gallery-item\"><img");
            BeginWriteAttribute("src", " src=\"", 1842, "\"", 1866, 2);
            WriteAttributeValue("", 1848, "/", 1848, 1, true);
#nullable restore
#line 44 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Producto\ProductoEstablecimiento.cshtml"
WriteAttributeValue("", 1849, Model.pathImagen, 1849, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1867, "\"", 1886, 1);
#nullable restore
#line 44 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Producto\ProductoEstablecimiento.cshtml"
WriteAttributeValue("", 1873, Model.nombre, 1873, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></a></div>
                                    <!--<div class=""slide"" data-thumb=""images/shop/thumbs/dress/3-1.jpg""><a href=""images/shop/dress/3-1.jpg"" title=""Pink Printed Dress - Side View"" data-lightbox=""gallery-item""><img src=""images/shop/dress/3-1.jpg"" alt=""Pink Printed Dress""></a></div>
                                    <div class=""slide"" data-thumb=""images/shop/thumbs/dress/3-2.jpg""><a href=""images/shop/dress/3-2.jpg"" title=""Pink Printed Dress - Back View"" data-lightbox=""gallery-item""><img src=""images/shop/dress/3-2.jpg"" alt=""Pink Printed Dress""></a></div>-->
                                </div>
                            </div>
                        </div>
                        <!--<div class=""sale-flash badge bg-danger p-2"">Sale!</div>-->
                    </div><!-- Product Single - Gallery End -->

                </div>

                <div class=""col-md-6 product-desc"">

                    <div class=""d-flex align-items-center justify-content-between"">

               ");
            WriteLiteral("         <!-- Product Single - Price\r\n                        ============================================= -->\r\n                        <div class=\"product-price\"><!--<del>$39.99</del>--> <ins>Q ");
#nullable restore
#line 61 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Producto\ProductoEstablecimiento.cshtml"
                                                                              Write(Model.precioVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</ins></div><!-- Product Single - Price End -->
                        <!-- Product Single - Rating
                        ============================================= -->
                        <!-- <div class=""product-rating"">
                            <i class=""icon-star3""></i>
                            <i class=""icon-star3""></i>
                            <i class=""icon-star3""></i>
                            <i class=""icon-star-half-full""></i>
                            <i class=""icon-star-empty""></i>
                        </div><!-- Product Single - Rating End -->

                    </div>

                    <div class=""line""></div>

                    <!-- Product Single - Quantity & Cart Button
                    ============================================= -->
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ad0136686c636f4b34a973f038c2b6e43e8099115349", async() => {
                WriteLiteral("\r\n                        <div class=\"quantity clearfix\">\r\n                            <input type=\"hidden\" name=\"productoId\"");
                BeginWriteAttribute("value", " value=\"", 4253, "\"", 4270, 1);
#nullable restore
#line 80 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Producto\ProductoEstablecimiento.cshtml"
WriteAttributeValue("", 4261, Model.id, 4261, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"precioVenta\"");
                BeginWriteAttribute("value", " value=\"", 4343, "\"", 4369, 1);
#nullable restore
#line 81 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Producto\ProductoEstablecimiento.cshtml"
WriteAttributeValue("", 4351, Model.precioVenta, 4351, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"establecimientoId\"");
                BeginWriteAttribute("value", " value=\"", 4448, "\"", 4480, 1);
#nullable restore
#line 82 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Producto\ProductoEstablecimiento.cshtml"
WriteAttributeValue("", 4456, Model.idEstablecimiento, 4456, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                            <input type=""button"" value=""-"" class=""minus"">
                            <input type=""number"" step=""1"" min=""1"" name=""cantidad"" value=""1"" title=""Qty"" class=""qty"" />
                            <input type=""button"" value=""+"" class=""plus"">
                        </div>
                        <button type=""submit"" class=""add-to-cart button m-0"">Comprar</button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"<!-- Product Single - Quantity & Cart Button End -->

                    <div class=""line""></div>

                    <!-- Product Single - Short Description
                    ============================================= -->
                    <p>");
#nullable restore
#line 94 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Producto\ProductoEstablecimiento.cshtml"
                  Write(Model.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <!--<ul class=""iconlist"">
                        <li><i class=""icon-caret-right""></i> Dynamic Color Options</li>
                        <li><i class=""icon-caret-right""></i> Lots of Size Options</li>
                        <li><i class=""icon-caret-right""></i> 30-Day Return Policy</li>
                    </ul><!-- Product Single - Short Description End -->
                    <!-- Product Single - Meta
                    ============================================= -->
                    <!--<div class=""card product-meta"">
                        <div class=""card-body"">
                            <span itemprop=""productID"" class=""sku_wrapper"">SKU: <span class=""sku"">8465415</span></span>
                            <span class=""posted_in"">Category: <a href=""#"" rel=""tag"">Dress</a>.</span>
                            <span class=""tagged_as"">Tags: <a href=""#"" rel=""tag"">Pink</a>, <a href=""#"" rel=""tag"">Short</a>, <a href=""#"" rel=""tag"">Dress</a>, <a href=""#"" rel=""tag"">Print");
            WriteLiteral(@"ed</a>.</span>
                        </div>
                    </div><!-- Product Single - Meta End -->
                    <!-- Product Single - Share
                    ============================================= -->
                    <!--<div class=""si-share border-0 d-flex justify-content-between align-items-center mt-4"">
                        <span>Share:</span>
                        <div>
                            <a href=""#"" class=""social-icon si-borderless si-facebook"">
                                <i class=""icon-facebook""></i>
                                <i class=""icon-facebook""></i>
                            </a>
                            <a href=""#"" class=""social-icon si-borderless si-twitter"">
                                <i class=""icon-twitter""></i>
                                <i class=""icon-twitter""></i>
                            </a>
                            <a href=""#"" class=""social-icon si-borderless si-pinterest"">
                        ");
            WriteLiteral(@"        <i class=""icon-pinterest""></i>
                                <i class=""icon-pinterest""></i>
                            </a>
                            <a href=""#"" class=""social-icon si-borderless si-gplus"">
                                <i class=""icon-gplus""></i>
                                <i class=""icon-gplus""></i>
                            </a>
                            <a href=""#"" class=""social-icon si-borderless si-rss"">
                                <i class=""icon-rss""></i>
                                <i class=""icon-rss""></i>
                            </a>
                            <a href=""#"" class=""social-icon si-borderless si-email3"">
                                <i class=""icon-email3""></i>
                                <i class=""icon-email3""></i>
                            </a>
                        </div>
                    </div><!-- Product Single - Share End -->

                </div>

                <div class=""w-100""></div>
      ");
            WriteLiteral("      </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"line\"></div>\r\n\r\n\r\n    <div class=\"heading-block center\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12 col-sm-6 col-lg-3 mb-3 mb-lg-0\" style=\"margin: 0 auto;\">\r\n                <img");
            BeginWriteAttribute("alt", " alt=\"", 8512, "\"", 8546, 1);
#nullable restore
#line 154 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Producto\ProductoEstablecimiento.cshtml"
WriteAttributeValue("", 8518, Model.nombreEstablecimiento, 8518, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 8547, "\"", 8586, 2);
            WriteAttributeValue("", 8553, "/", 8553, 1, true);
#nullable restore
#line 154 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Producto\ProductoEstablecimiento.cshtml"
WriteAttributeValue("", 8554, Model.pathEstablecimientoImagen, 8554, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail w-100 d-block\">\r\n            </div>\r\n        </div>\r\n        <span>Ofrecido por</span>\r\n        <h3>");
#nullable restore
#line 158 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Producto\ProductoEstablecimiento.cshtml"
       Write(Model.nombreEstablecimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ad0136686c636f4b34a973f038c2b6e43e8099124643", async() => {
                WriteLiteral("Ir a la tienda");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-EstablecimientoId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 159 "C:\Users\50249\source\repos\GestionVentasV2\GestionVentasV2\Views\Producto\ProductoEstablecimiento.cshtml"
                                                                               WriteLiteral(Model.idEstablecimiento);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["EstablecimientoId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-EstablecimientoId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["EstablecimientoId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
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