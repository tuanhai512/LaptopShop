#pragma checksum "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Customer\Hide.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6aa40ac754b1d6375939713252adbb892a0ee624"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Hide), @"mvc.1.0.view", @"/Views/Customer/Hide.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aa40ac754b1d6375939713252adbb892a0ee624", @"/Views/Customer/Hide.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78fff7de114e5d368bcb520556b8ec07f96d2d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Hide : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Management.ViewModel.Customer.CustomerDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Customer\Hide.cshtml"
  
   
    if (Model.Count() > 0)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <table>\r\n            <thead>\r\n                <tr>\r\n                    <th>ID</th>\r\n                    <th>Name</th>\r\n                    <th>Email</th>\r\n                </tr>\r\n            </thead>\r\n");
#nullable restore
#line 15 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Customer\Hide.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th>");
#nullable restore
#line 18 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Customer\Hide.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                    <th>");
#nullable restore
#line 19 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Customer\Hide.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                    <th>");
#nullable restore
#line 20 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Customer\Hide.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                    <th>\r\n                      \r\n                       \r\n                    </th>\r\n                </tr>\r\n");
#nullable restore
#line 26 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Customer\Hide.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 29 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Customer\Hide.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No data</p>\r\n");
#nullable restore
#line 33 "D:\Github\laptop\LaptopShop\LaptopShop\Management\Views\Customer\Hide.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Management.ViewModel.Customer.CustomerDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
