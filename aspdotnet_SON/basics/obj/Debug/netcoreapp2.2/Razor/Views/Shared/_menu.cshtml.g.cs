#pragma checksum "C:\Users\doguk\OneDrive\Masaüstü\MovieApp\Views\Shared\_menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c2c9e83908e3d6d70c64e0275772292042e54a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__menu), @"mvc.1.0.view", @"/Views/Shared/_menu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_menu.cshtml", typeof(AspNetCore.Views_Shared__menu))]
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
#line 1 "C:\Users\doguk\OneDrive\Masaüstü\MovieApp\Views\_ViewImports.cshtml"
using MovieApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c2c9e83908e3d6d70c64e0275772292042e54a0", @"/Views/Shared/_menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3fd1543014ab08bb53b07398d8ea7f79632394b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 30, true);
            WriteLiteral("\r\n<div class=\"list-group\">\r\n\r\n");
            EndContext();
#line 5 "C:\Users\doguk\OneDrive\Masaüstü\MovieApp\Views\Shared\_menu.cshtml"
     foreach (var i in Model)
    {

#line default
#line hidden
            BeginContext(98, 67, true);
            WriteLiteral("        <a href=\"#\" class=\"list-group-item list-group-item-action\">");
            EndContext();
            BeginContext(166, 6, false);
#line 7 "C:\Users\doguk\OneDrive\Masaüstü\MovieApp\Views\Shared\_menu.cshtml"
                                                              Write(i.Name);

#line default
#line hidden
            EndContext();
            BeginContext(172, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 8 "C:\Users\doguk\OneDrive\Masaüstü\MovieApp\Views\Shared\_menu.cshtml"
    }   

#line default
#line hidden
            BeginContext(188, 12, true);
            WriteLiteral("    \r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
