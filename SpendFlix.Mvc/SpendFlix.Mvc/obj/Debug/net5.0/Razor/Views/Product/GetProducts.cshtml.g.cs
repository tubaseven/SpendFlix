#pragma checksum "C:\Users\tugba.seven\source\repos\SpendFlix\SpendFlix.Mvc\SpendFlix.Mvc\Views\Product\GetProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "222cd83e6a853ab1c9646b901e9f2c76b407267d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetProducts), @"mvc.1.0.view", @"/Views/Product/GetProducts.cshtml")]
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
#line 1 "C:\Users\tugba.seven\source\repos\SpendFlix\SpendFlix.Mvc\SpendFlix.Mvc\Views\_ViewImports.cshtml"
using SpendFlix.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tugba.seven\source\repos\SpendFlix\SpendFlix.Mvc\SpendFlix.Mvc\Views\_ViewImports.cshtml"
using SpendFlix.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"222cd83e6a853ab1c9646b901e9f2c76b407267d", @"/Views/Product/GetProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"babfb2f8b0ef9f540ffe3e262fa39520b7bfe7ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SpendFlix.Entities.ProductDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"card-deck\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\tugba.seven\source\repos\SpendFlix\SpendFlix.Mvc\SpendFlix.Mvc\Views\Product\GetProducts.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 304, "\"", 320, 1);
#nullable restore
#line 12 "C:\Users\tugba.seven\source\repos\SpendFlix\SpendFlix.Mvc\SpendFlix.Mvc\Views\Product\GetProducts.cshtml"
WriteAttributeValue("", 310, item.Link, 310, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 14 "C:\Users\tugba.seven\source\repos\SpendFlix\SpendFlix.Mvc\SpendFlix.Mvc\Views\Product\GetProducts.cshtml"
                                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 15 "C:\Users\tugba.seven\source\repos\SpendFlix\SpendFlix.Mvc\SpendFlix.Mvc\Views\Product\GetProducts.cshtml"
                                Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                <a href=\"#\" class=\"btn btn-primary\">Go somewhere</a>\r\n                <a href=\"#\" class=\"badge badge-info m-3\">$9.99</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 22 "C:\Users\tugba.seven\source\repos\SpendFlix\SpendFlix.Mvc\SpendFlix.Mvc\Views\Product\GetProducts.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SpendFlix.Entities.ProductDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
