#pragma checksum "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f4140ee900b91e2a4c0bf1bf323b510f883ac1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Admin_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f4140ee900b91e2a4c0bf1bf323b510f883ac1c", @"/Areas/Admin/Views/Admin/Index.cshtml")]
    public class Areas_Admin_Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Admin\Index.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-content"">
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""overview-wrap"">
                        <h2 class=""title-1"">Dash-Board</h2>
                    </div>
                </div>
            </div>
            ");
#nullable restore
#line 15 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Admin\Index.cshtml"
       Write(await Component.InvokeAsync("_Widgets"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div class=\"row\">\r\n                ");
#nullable restore
#line 18 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Admin\Index.cshtml"
           Write(await Component.InvokeAsync("_ProjectTable"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-lg-3\">\r\n                    <h2 class=\"title-1 m-b-25\">Sertifikalar</h2>\r\n                    ");
#nullable restore
#line 21 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Admin\Index.cshtml"
               Write(await Component.InvokeAsync("_Certificate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div><br />\r\n\r\n            <br />\r\n            ");
#nullable restore
#line 26 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Admin\Index.cshtml"
       Write(await Component.InvokeAsync("_HomeContact"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
