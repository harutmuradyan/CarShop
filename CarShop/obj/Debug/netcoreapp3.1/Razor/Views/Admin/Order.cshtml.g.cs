#pragma checksum "C:\Users\User\source\repos\CarShop1\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\Views\Admin\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c682686fe753c3e8bf0e2de8d3c60e37ea321f80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Order), @"mvc.1.0.view", @"/Views/Admin/Order.cshtml")]
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
#line 1 "C:\Users\User\source\repos\CarShop1\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\Views\_ViewImports.cshtml"
using CarShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\CarShop1\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\Views\_ViewImports.cshtml"
using CarShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c682686fe753c3e8bf0e2de8d3c60e37ea321f80", @"/Views/Admin/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4c0d735d051fba12fbf7807849e7c1ea31600c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarShop.Models.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\repos\CarShop1\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\Views\Admin\Order.cshtml"
  
    ViewBag.Title = "Orders";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"small-container\">\r\n    <div class=\"my-row\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\User\source\repos\CarShop1\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\Views\Admin\Order.cshtml"
         foreach (var Order in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"my-col-4\">\r\n                <p>Order Id : ");
#nullable restore
#line 12 "C:\Users\User\source\repos\CarShop1\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\Views\Admin\Order.cshtml"
                         Write(Order.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Name : ");
#nullable restore
#line 13 "C:\Users\User\source\repos\CarShop1\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\Views\Admin\Order.cshtml"
                     Write(Order.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Addres : ");
#nullable restore
#line 14 "C:\Users\User\source\repos\CarShop1\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\Views\Admin\Order.cshtml"
                       Write(Order.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Phone : ");
#nullable restore
#line 15 "C:\Users\User\source\repos\CarShop1\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\Views\Admin\Order.cshtml"
                      Write(Order.ContactPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Comment : ");
#nullable restore
#line 16 "C:\Users\User\source\repos\CarShop1\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\Views\Admin\Order.cshtml"
                        Write(Order.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 18 "C:\Users\User\source\repos\CarShop1\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\CarShop\Views\Admin\Order.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarShop.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
