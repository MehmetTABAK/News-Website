#pragma checksum "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "580124b907ae31d0b7af36b096706e540ce71948"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Index.cshtml"
using denemeV3.Database;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"580124b907ae31d0b7af36b096706e540ce71948", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ec17b8587ebf8af156a3cf16d64a661a1e695df", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Haber>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Index.cshtml"
  
    var enums = Enum.GetValues(typeof(Kategoriler));
    var x = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Top News Start-->\n<div class=\"top-news\">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-md-6 tn-left\">\n                ");
#nullable restore
#line 15 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Index.cshtml"
           Write(await Html.PartialAsync(@"PartialViews\Slider.cshtml", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"col-md-6 tn-right\">\n                ");
#nullable restore
#line 18 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Index.cshtml"
           Write(Component.InvokeAsync(@"Tamplete").Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n<div class=\"cat-news container\">\n    <div class=\"row\">\n\n");
#nullable restore
#line 26 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Index.cshtml"
         foreach (var item in enums)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-6\">\n");
#nullable restore
#line 29 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Index.cshtml"
                  
                    var kat = (Kategoriler)item;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Index.cshtml"
                 if (Model.Any(x => (x.Kategori) == kat))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Index.cshtml"
               Write(await Component.InvokeAsync(@"KategoriHaber", (int)item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Index.cshtml"
                                                                             ;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n");
#nullable restore
#line 37 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</div>\n\n\n\n");
#nullable restore
#line 44 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync(@"HaberGrid"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- Tab News Start-->\n<!-- Main News Start-->\n");
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