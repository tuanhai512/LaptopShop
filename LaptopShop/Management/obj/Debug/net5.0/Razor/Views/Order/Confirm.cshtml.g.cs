#pragma checksum "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f57f67c31a7ef68edc90a5a47cc91fffb243dbd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Confirm), @"mvc.1.0.view", @"/Views/Order/Confirm.cshtml")]
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
#line 1 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\_ViewImports.cshtml"
using Management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\_ViewImports.cshtml"
using Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f57f67c31a7ef68edc90a5a47cc91fffb243dbd1", @"/Views/Order/Confirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78fff7de114e5d368bcb520556b8ec07f96d2d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Confirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Management.ViewModel.Order.OrderDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""card"">
        <div class=""card-header"">
            <div class=""row"">
                <div class=""col-md-6 text-danger text-uppercase"">
                    <strong>Danh sách đơn hàng</strong>
                </div>

            </div>
        </div>
    </div>
");
#nullable restore
#line 13 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml"
    if (Model.Count() > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card-block p-3\">\r\n                <table class=\"table table-bordered table-hover table-striped\">\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 23 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml"
                       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 26 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml"
                       Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 29 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml"
                       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n\r\n                    </tr>\r\n\r\n");
#nullable restore
#line 34 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 38 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 41 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 44 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 47 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml"
                                 if (item.Status != 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span disabled />\r\n");
#nullable restore
#line 50 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml"

                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a  class=\"btn btn-info btn-sm\">\r\n");
#nullable restore
#line 55 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml"
                                         if (item.Status.Equals(0))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>Xác Nhận</span>\r\n");
#nullable restore
#line 58 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>Đã Xác Nhận</span>\r\n");
#nullable restore
#line 62 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </a>\r\n");
#nullable restore
#line 64 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
#nullable restore
#line 65 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml"
                           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 69 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </table>\r\n            </div>\r\n");
#nullable restore
#line 73 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Giỏ hàng trống</p>\r\n");
#nullable restore
#line 78 "D:\HUFLIT\MTK\DoAn\13-10\LaptopShop\LaptopShop\Management\Views\Order\Confirm.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Management.ViewModel.Order.OrderDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
