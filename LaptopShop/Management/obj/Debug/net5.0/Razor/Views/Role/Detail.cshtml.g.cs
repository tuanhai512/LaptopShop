#pragma checksum "H:\năm 4\LaptopShop\LaptopShop\Management\Views\Role\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ce36b7634665e27cc711bc22c2057807ad425de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Detail), @"mvc.1.0.view", @"/Views/Role/Detail.cshtml")]
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
#line 1 "H:\năm 4\LaptopShop\LaptopShop\Management\Views\_ViewImports.cshtml"
using Management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\năm 4\LaptopShop\LaptopShop\Management\Views\_ViewImports.cshtml"
using Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ce36b7634665e27cc711bc22c2057807ad425de", @"/Views/Role/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78fff7de114e5d368bcb520556b8ec07f96d2d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Management.ViewModel.Role.DetailRoleInput>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "H:\năm 4\LaptopShop\LaptopShop\Management\Views\Role\Detail.cshtml"
  
    if(Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        <thead>\r\n            <tr>\r\n                <th>");
#nullable restore
#line 8 "H:\năm 4\LaptopShop\LaptopShop\Management\Views\Role\Detail.cshtml"
               Write(Html.LabelFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 9 "H:\năm 4\LaptopShop\LaptopShop\Management\Views\Role\Detail.cshtml"
               Write(Html.LabelFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n        </thead>\r\n\r\n        <tr>\r\n            <th>");
#nullable restore
#line 14 "H:\năm 4\LaptopShop\LaptopShop\Management\Views\Role\Detail.cshtml"
           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 15 "H:\năm 4\LaptopShop\LaptopShop\Management\Views\Role\Detail.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 18 "H:\năm 4\LaptopShop\LaptopShop\Management\Views\Role\Detail.cshtml"
    
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No data</p>\r\n");
#nullable restore
#line 23 "H:\năm 4\LaptopShop\LaptopShop\Management\Views\Role\Detail.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Management.ViewModel.Role.DetailRoleInput> Html { get; private set; }
    }
}
#pragma warning restore 1591
