#pragma checksum "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Components\KategoriHaber\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99cc7dd50b75f66566ff7e358cf956c48bca2039"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_KategoriHaber_Default), @"mvc.1.0.view", @"/Views/Home/Components/KategoriHaber/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99cc7dd50b75f66566ff7e358cf956c48bca2039", @"/Views/Home/Components/KategoriHaber/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ec17b8587ebf8af156a3cf16d64a661a1e695df", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_KategoriHaber_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Haber>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n<h2>");
#nullable restore
#line 5 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Components\KategoriHaber\Default.cshtml"
Write(Model[0].Kategori);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<div class=\"cn-slider\">\n");
#nullable restore
#line 7 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Components\KategoriHaber\Default.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Components\KategoriHaber\Default.cshtml"
   Write(await Html.PartialAsync(@"~/Views/Home/PartialViews/Haber.cshtml", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Components\KategoriHaber\Default.cshtml"
                                                                                 
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n\n");
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
