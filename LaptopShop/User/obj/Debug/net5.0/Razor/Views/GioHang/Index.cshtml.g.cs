#pragma checksum "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f520ba1f1918e9e799a8dc72fc37802fef6b0cd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GioHang_Index), @"mvc.1.0.view", @"/Views/GioHang/Index.cshtml")]
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
#line 1 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\_ViewImports.cshtml"
using User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\_ViewImports.cshtml"
using User.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f520ba1f1918e9e799a8dc72fc37802fef6b0cd9", @"/Views/GioHang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b6078523a3f569f61432cee5c190025aac6783b", @"/Views/_ViewImports.cshtml")]
    public class Views_GioHang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    $(document).ready(function () {
        $("".UpdateCart"").click(function (event) {
            event.preventDefault();
            var quantity = $("".quantity_"" + $(this).attr(""data-id"")).val();
            console.log(quantity);
            $.ajax({
                type: ""POST"",
                url:""");
#nullable restore
#line 14 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml"
                Write(Url.Action("Index","GioHang"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\n                data: {\n                    id: $(this).attr(\"data-id\"),\n                    quantity:quantity\n                },\n                success: function (result) {\n                    window.location.href = \'");
#nullable restore
#line 20 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml"
                                       Write(Url.Action("Index","GioHang"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\n                }\n            });\n        });\n    });\n</script>\n\n");
#nullable restore
#line 27 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""bg-light py-3"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12 mb-0""><a href=""index.html"">Home</a> <span class=""mx-2 mb-0"">/</span> <strong class=""text-black"">Cart</strong></div>
            </div>
        </div>
    </div>
");
            WriteLiteral("    <div class=\"site-section\">\n        <div class=\"container\">\n            <div class=\"row mb-5\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f520ba1f1918e9e799a8dc72fc37802fef6b0cd96109", async() => {
                WriteLiteral(@"
                    <div class=""site-blocks-table"">
                        <table class=""table table-bordered"">
                            <thead>
                                <tr>
                                    <th class=""product-thumbnail"">Image</th>
                                    <th class=""product-name"">Product</th>
                                    <th class=""product-price"">Price</th>
                                    <th class=""product-quantity"">Quantity</th>
                                    <th class=""product-total"">Total</th>
                                    <th class=""product-remove"">Remove</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 57 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\n                                        <td class=\"product-thumbnail\">\n                                            <img");
                BeginWriteAttribute("src", " src=\"", 2241, "\"", 2273, 1);
#nullable restore
#line 61 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 2247, Url.Content(item.Hinhanh), 2247, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2274, "\"", 2291, 1);
#nullable restore
#line 61 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 2280, item.Tensp, 2280, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"250px\" height=\"200px\" class=\"img-fluid\">\n                                        </td>\n                                        <td class=\"product-name\">\n                                            <h2 class=\"h5 text-black\">");
#nullable restore
#line 64 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml"
                                                                 Write(item.Tensp);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\n                                        </td>\n                                        <td>");
#nullable restore
#line 66 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml"
                                       Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                        <td>
                                            <div class=""input-group mb-3"" style=""max-width: 120px;"">
                                                <div class=""input-group-prepend"">
                                                    <button class=""btn btn-outline-primary js-btn-minus"" type=""button"">&minus;</button>
                                                </div>
                                                <input type=""text"" disabled class=""form-control text-center""");
                BeginWriteAttribute("value", " value=\"", 3174, "\"", 3195, 1);
#nullable restore
#line 72 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 3182, item.Soluong, 3182, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " \n                                                       placeholder=\"", 3196, "\"", 3266, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-label=""Example text with button addon"" aria-describedby=""button-addon1"">
                                                <div class=""input-group-append"">
                                                    <button class=""btn btn-outline-primary js-btn-plus"" type=""button"">&plus;</button>
                                                </div>
                                            </div>

                                        </td>
                                        <td>");
#nullable restore
#line 80 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml"
                                       Write(item.Thanhtien);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                        <td><a href=\"#\" class=\"btn btn-primary btn-sm\">X</a></td>\n                                    </tr>\n");
#nullable restore
#line 83 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tbody>\n                        </table>\n                    </div>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n            <div class=\"row\">\n\n\n                <div class=\"col-md-6\">\n                    <div class=\"row mb-5\">\n                        <div class=\"col-md-6 mb-3 mb-md-0\">\n");
#nullable restore
#line 95 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml"
                             using (Html.BeginForm("UpdateCart", "GioHang"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input type=\"submit\" value=\"Update Cart\" class=\"btn UpdateCart btn-primary btn-sm btn-block\" />\n");
#nullable restore
#line 98 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                        </div>\n                        <div class=\"col-md-6\">\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4642, "\"", 4681, 1);
#nullable restore
#line 103 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 4649, Url.ActionLink("Index", "Home"), 4649, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-primary btn-sm btn-block"">Continue Shopping</a>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <label class=""text-black h4"" for=""coupon"">Coupon</label>
                            <p>Enter your coupon code if you have one.</p>
                        </div>
                        <div class=""col-md-8 mb-3 mb-md-0"">
                            <input type=""text"" class=""form-control py-3"" id=""coupon"" placeholder=""Coupon Code"">
                        </div>
                        <div class=""col-md-4"">
                            <button class=""btn btn-primary btn-sm"">Apply Coupon</button>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6 pl-5"">
                    <div class=""row justify-content-end"">


                        <div class=""col-md-7"">
                            <div class=""row"">
");
            WriteLiteral("                                <div class=\"col-md-12 text-right border-bottom mb-5\">\n                                    <h3 class=\"text-black h4 text-uppercase\">Cart Totals</h3>\n                                </div>\n                            </div>\n");
#nullable restore
#line 129 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml"
                             foreach (var item in Model) { 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""row mb-3"">
                                <div class=""col-md-6"">
                                    <span class=""text-black"">Quantity</span>
                                </div>
                                <div class=""col-md-6 text-right"">
");
            WriteLiteral("                                    <strong class=\"text-black\">");
#nullable restore
#line 136 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml"
                                                          Write(ViewBag.totalQty);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>

                                </div>
                            </div>
                            <div class=""row mb-5"">
                                <div class=""col-md-6"">
                                    <span class=""text-black"">Total</span>
                                </div>

                                <div class=""col-md-6 text-right"">

                                    <strong class=""text-black"">");
#nullable restore
#line 147 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml"
                                                          Write(ViewBag.total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n\n                                </div>\n                            </div>\n");
#nullable restore
#line 151 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <button class=""btn btn-primary btn-lg py-3 btn-block"" onclick=""window.location='checkout.html'"">Proceed To Checkout</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
");
#nullable restore
#line 164 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\User\Views\GioHang\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
