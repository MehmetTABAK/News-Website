// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace denemeV3.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 2 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Pages\Admin\_Imports.razor"
using denemeV3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Pages\Admin\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Pages\Admin\AdminLayout.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Pages\Admin\AdminLayout.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Pages\Admin\AdminLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\mtaba\OneDrive\Masaüstü\denemeV3\denemeV3\Pages\Admin\AdminLayout.razor"
  RadzenBody body0;
    IEnumerable<Haber> haberler;
    bool sidebarExpanded = true;
    RadzenSidebar sidebar0;
    bool bodyExpanded = false;
    void FilterPanelMenu(ChangeEventArgs args)
    {
        var term = args.Value.ToString();
    } 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
