#pragma checksum "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Shared\Components\_Certificate\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf47e398e50ab8c9fedcfef37d8cb0f0f669ffcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components__Certificate_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/_Certificate/Default.cshtml")]
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
#line 1 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Shared\_ViewImports.cshtml"
using Portöy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Shared\_ViewImports.cshtml"
using Portöy.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Shared\Components\_Certificate\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf47e398e50ab8c9fedcfef37d8cb0f0f669ffcd", @"/Areas/Admin/Views/Shared/Components/_Certificate/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a80561c492117c244725fa2284b49bd74b9cc43b", @"/Areas/Admin/Views/Shared/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components__Certificate_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Certificate>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"au-card au-card--bg-blue au-card-top-countries m-b-40\">\r\n    <div class=\"au-card-inner\">\r\n        <div class=\"table-responsive\">\r\n            <table class=\"table table-top-countries\">\r\n\r\n                <tbody>\r\n");
#nullable restore
#line 10 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Shared\Components\_Certificate\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 13 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Shared\Components\_Certificate\Default.cshtml"
                           Write(item.CertificateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 15 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Shared\Components\_Certificate\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Certificate>> Html { get; private set; }
    }
}
#pragma warning restore 1591
