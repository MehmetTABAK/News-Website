#pragma checksum "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Components\HaberGrid\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7712d54badd6259d79e19fda0872b5d508737cd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_HaberGrid_Default), @"mvc.1.0.view", @"/Views/Home/Components/HaberGrid/Default.cshtml")]
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
#line 1 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\_ViewImports.cshtml"
using denemeV3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\_ViewImports.cshtml"
using denemeV3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7712d54badd6259d79e19fda0872b5d508737cd5", @"/Views/Home/Components/HaberGrid/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ec17b8587ebf8af156a3cf16d64a661a1e695df", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_HaberGrid_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Haber>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"main-news\">\n    <div class=\"container\">\n         <h2>Son Haberler</h2>\n        <div class=\"row\">\n            <div class=\"col-lg-9\">\n                <div class=\"row\">\n");
#nullable restore
#line 13 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Components\HaberGrid\Default.cshtml"
                     foreach (var item in Model)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Components\HaberGrid\Default.cshtml"
                   Write(await Html.PartialAsync(@"~/Views/Home/PartialViews/GridHaber.cshtml", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Components\HaberGrid\Default.cshtml"
                                                                                                     
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n              ");
#nullable restore
#line 19 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Components\HaberGrid\Default.cshtml"
         Write(await Component.InvokeAsync(@"ReadMeMore"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n</div>");
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