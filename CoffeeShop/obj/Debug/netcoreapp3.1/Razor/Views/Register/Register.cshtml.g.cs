#pragma checksum "C:\Users\mschwartz2\OneDrive - Knex\Documents\Dev_Build\CoffeeShop\CoffeeShop\Views\Register\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fbb22f738e3689cf74556846a7d890ee609d89f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Register), @"mvc.1.0.view", @"/Views/Register/Register.cshtml")]
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
#line 1 "C:\Users\mschwartz2\OneDrive - Knex\Documents\Dev_Build\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mschwartz2\OneDrive - Knex\Documents\Dev_Build\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fbb22f738e3689cf74556846a7d890ee609d89f", @"/Views/Register/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0280a23aa28fddc99a39f5869bf0f0a5a4076c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoffeeShop.Models.UserReg>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mschwartz2\OneDrive - Knex\Documents\Dev_Build\CoffeeShop\CoffeeShop\Views\Register\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        <h1>Thank you for registering  ");
#nullable restore
#line 7 "C:\Users\mschwartz2\OneDrive - Knex\Documents\Dev_Build\CoffeeShop\CoffeeShop\Views\Register\Register.cshtml"
                                  Write(ViewData["name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(", your new username is ");
#nullable restore
#line 7 "C:\Users\mschwartz2\OneDrive - Knex\Documents\Dev_Build\CoffeeShop\CoffeeShop\Views\Register\Register.cshtml"
                                                                          Write(ViewData["username"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p>You may be contacted at ");
#nullable restore
#line 8 "C:\Users\mschwartz2\OneDrive - Knex\Documents\Dev_Build\CoffeeShop\CoffeeShop\Views\Register\Register.cshtml"
                              Write(ViewData["phone"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>\r\n            Your preferred drink is ");
            WriteLiteral("</p>\r\n            <p>A confirmation email has been sent to ");
#nullable restore
#line 11 "C:\Users\mschwartz2\OneDrive - Knex\Documents\Dev_Build\CoffeeShop\CoffeeShop\Views\Register\Register.cshtml"
                                                Write(ViewData["email"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoffeeShop.Models.UserReg> Html { get; private set; }
    }
}
#pragma warning restore 1591