#pragma checksum "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f99a0d7dd621551d5f3ded7b11541c5adff5c72f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Create), @"mvc.1.0.view", @"/Views/Product/Create.cshtml")]
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
#line 1 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\_ViewImports.cshtml"
using Management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\_ViewImports.cshtml"
using Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f99a0d7dd621551d5f3ded7b11541c5adff5c72f", @"/Views/Product/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78fff7de114e5d368bcb520556b8ec07f96d2d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Management.ViewModel.Product.CreateProductInput>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml"
     using (Html.BeginForm("Create", "Product", FormMethod.Post, new { enctype = "multipart/form-data" }))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form\">\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 9 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml"
           Write(Html.LabelFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 10 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml"
           Write(Html.EditorFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 11 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Name,"", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group \">\r\n                ");
#nullable restore
#line 14 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml"
           Write(Html.LabelFor(m => m.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 15 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml"
           Write(Html.EditorFor(m => m.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 16 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Price,"", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 19 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml"
           Write(Html.LabelFor(m => m.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml"
           Write(Html.EditorFor(m => m.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Quantity,"", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group \">\r\n                ");
#nullable restore
#line 24 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml"
           Write(Html.LabelFor(m => m.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 25 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml"
           Write(Html.EditorFor(m => m.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 26 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Description,"", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group \">\r\n                ");
#nullable restore
#line 30 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml"
           Write(Html.LabelFor(m => m.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 31 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml"
           Write(Html.DropDownList("CategoryId", (IEnumerable<SelectListItem>)ViewBag.Categories, "Chọn loại", new { @class = "form -control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 32 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.CategoryId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group \">\r\n                ");
#nullable restore
#line 37 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml"
           Write(Html.LabelFor(m => m.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <input type=\"file\" id=\"file\" name=\"UploadImage\" style=\"width:100%\" />\r\n");
            WriteLiteral("            </div>\r\n            <div>\r\n                <input type=\"submit\" value=\"Create\" />\r\n                <span class=\"btn btn-link\">");
#nullable restore
#line 43 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml"
                                      Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 46 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Product\Create.cshtml"

    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Management.ViewModel.Product.CreateProductInput> Html { get; private set; }
    }
}
#pragma warning restore 1591
