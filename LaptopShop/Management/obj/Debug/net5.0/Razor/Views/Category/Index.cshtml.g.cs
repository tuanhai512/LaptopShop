#pragma checksum "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1653294b80020a94991b89b42f5fe7b1dfda0d1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\_ViewImports.cshtml"
using Management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\_ViewImports.cshtml"
using Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1653294b80020a94991b89b42f5fe7b1dfda0d1e", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78fff7de114e5d368bcb520556b8ec07f96d2d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Management.ViewModel.Categories.CategoryDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <p>Category list</p>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 101, "\"", 144, 1);
#nullable restore
#line 4 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Category\Index.cshtml"
WriteAttributeValue("", 108, Url.ActionLink("Create","Category"), 108, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tao moi</a>\r\n");
#nullable restore
#line 5 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Category\Index.cshtml"
    if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        <thead>\r\n            <tr>\r\n                <th>ID</th>\r\n                <th>Name</th>\r\n            </tr>\r\n        </thead>\r\n");
#nullable restore
#line 14 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Category\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <th>");
#nullable restore
#line 17 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Category\Index.cshtml"
       Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 18 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Category\Index.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th><a");
            BeginWriteAttribute("href", " href=\"", 468, "\"", 530, 1);
#nullable restore
#line 19 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Category\Index.cshtml"
WriteAttributeValue("", 475, Url.ActionLink("Edit","Category",new { id = item.ID }), 475, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a></th>\r\n        <th><a");
            BeginWriteAttribute("href", " href=\"", 561, "\"", 625, 1);
#nullable restore
#line 20 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Category\Index.cshtml"
WriteAttributeValue("", 568, Url.ActionLink("Delete","Category",new { id = item.ID }), 568, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></th>\r\n        <th><a");
            BeginWriteAttribute("href", " href=\"", 658, "\"", 722, 1);
#nullable restore
#line 21 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Category\Index.cshtml"
WriteAttributeValue("", 665, Url.ActionLink("Detail","Category",new { id = item.ID }), 665, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detail</a></th>\r\n    </tr>\r\n");
#nullable restore
#line 23 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Category\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 26 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Category\Index.cshtml"
       
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No data</p>\r\n");
#nullable restore
#line 31 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Management.ViewModel.Categories.CategoryDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
