#pragma checksum "C:\Users\mtaba\OneDrive\Masaüstü\HaberSitesi\denemeV3\denemeV3\Views\Home\Components\ReadMeMore\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02199b10b60ec4ca9e703666bca5b7a8c8de9535"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_ReadMeMore_Default), @"mvc.1.0.view", @"/Views/Home/Components/ReadMeMore/Default.cshtml")]
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
#line 1 "C:\Users\mtaba\OneDrive\Masaüstü\HaberSitesi\denemeV3\denemeV3\Views\_ViewImports.cshtml"
using denemeV3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mtaba\OneDrive\Masaüstü\HaberSitesi\denemeV3\denemeV3\Views\_ViewImports.cshtml"
using denemeV3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02199b10b60ec4ca9e703666bca5b7a8c8de9535", @"/Views/Home/Components/ReadMeMore/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ec17b8587ebf8af156a3cf16d64a661a1e695df", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_ReadMeMore_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Haber>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("<div class=\"col-lg-3\">\n    <div class=\"mn-list\">\n        <h2>Daha fazla oku</h2>\n        <ul>\n");
#nullable restore
#line 13 "C:\Users\mtaba\OneDrive\Masaüstü\HaberSitesi\denemeV3\denemeV3\Views\Home\Components\ReadMeMore\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 317, "\"", 382, 1);
#nullable restore
#line 15 "C:\Users\mtaba\OneDrive\Masaüstü\HaberSitesi\denemeV3\denemeV3\Views\Home\Components\ReadMeMore\Default.cshtml"
WriteAttributeValue("", 324, Url.Action("HaberDetay", "Home", new {id = item.HaberID}), 324, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "C:\Users\mtaba\OneDrive\Masaüstü\HaberSitesi\denemeV3\denemeV3\Views\Home\Components\ReadMeMore\Default.cshtml"
                                                                                    Write(item.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 16 "C:\Users\mtaba\OneDrive\Masaüstü\HaberSitesi\denemeV3\denemeV3\Views\Home\Components\ReadMeMore\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Haber>> Html { get; private set; }
    }
}
#pragma warning restore 1591
