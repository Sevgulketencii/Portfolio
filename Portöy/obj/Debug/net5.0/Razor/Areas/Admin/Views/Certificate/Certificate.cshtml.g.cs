#pragma checksum "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Certificate\Certificate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecad24ba8f3b0df6155c92e6cc414916ae5c56ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Certificate_Certificate), @"mvc.1.0.view", @"/Areas/Admin/Views/Certificate/Certificate.cshtml")]
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
#line 7 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Certificate\Certificate.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecad24ba8f3b0df6155c92e6cc414916ae5c56ee", @"/Areas/Admin/Views/Certificate/Certificate.cshtml")]
    public class Areas_Admin_Views_Certificate_Certificate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Certificate>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Certificate\Certificate.cshtml"
  
    ViewData["Title"] = "Certificate";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""table-responsive m-b-40"" style=""margin-top:100px"">
    <table class=""table table-borderless table-data3"">
        <thead>
            <tr>
                <th>Sertifika Id</th>
                <th>Sertifika Adı</th>
                <th>Sertifika Alınan Kurum</th>
                <th>Yeterlilik URL</th>
                <th>Statü</th>
                <th>Güncelle</th>
                <th>Sil</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 24 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Certificate\Certificate.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Certificate\Certificate.cshtml"
               Write(item.CertificateId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Certificate\Certificate.cshtml"
               Write(item.CertificateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Certificate\Certificate.cshtml"
               Write(item.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Certificate\Certificate.cshtml"
               Write(item.CertificateUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 31 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Certificate\Certificate.cshtml"
                 if (item.CertificateStatus == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"process\">Aktif</td>\r\n");
#nullable restore
#line 34 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Certificate\Certificate.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"denied\">Pasif</td>\r\n");
#nullable restore
#line 38 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Certificate\Certificate.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td><a");
            BeginWriteAttribute("href", " href=\"", 1180, "\"", 1232, 2);
            WriteAttributeValue("", 1187, "/Admin/Certificate/Update/", 1187, 26, true);
#nullable restore
#line 39 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Certificate\Certificate.cshtml"
WriteAttributeValue("", 1213, item.CertificateId, 1213, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\">Güncelle</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1306, "\"", 1358, 2);
            WriteAttributeValue("", 1313, "/Admin/Certificate/Delete/", 1313, 26, true);
#nullable restore
#line 40 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Certificate\Certificate.cshtml"
WriteAttributeValue("", 1339, item.CertificateId, 1339, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\">Sil</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Certificate\Certificate.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </tbody>
    </table><br />

    <a href=""/Admin/Certificate/CertificateAdd"" class=""btn btn-success btn-block"">Ekle</a>

</div>

<div class=""main-content"">
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">
            <div class=""row"">
");
#nullable restore
#line 55 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Certificate\Certificate.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4\">\r\n                        <div class=\"card\">\r\n                            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 1946, "\"", 1975, 1);
#nullable restore
#line 59 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Certificate\Certificate.cshtml"
WriteAttributeValue("", 1952, item.CertificateImgUrl, 1952, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                            <div class=\"card-body\">\r\n                                <h4 class=\"card-title mb-3\">");
#nullable restore
#line 61 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Certificate\Certificate.cshtml"
                                                       Write(item.CertificateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p class=\"card-text\">\r\n                                    ");
#nullable restore
#line 63 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Certificate\Certificate.cshtml"
                               Write(item.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 68 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Certificate\Certificate.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
