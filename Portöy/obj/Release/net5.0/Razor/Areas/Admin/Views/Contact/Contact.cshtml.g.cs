#pragma checksum "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Contact\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c78dc38648cc16c6f32cc24ae96b00b1c801a88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Contact_Contact), @"mvc.1.0.view", @"/Areas/Admin/Views/Contact/Contact.cshtml")]
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
#line 6 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Contact\Contact.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c78dc38648cc16c6f32cc24ae96b00b1c801a88", @"/Areas/Admin/Views/Contact/Contact.cshtml")]
    public class Areas_Admin_Views_Contact_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Contact\Contact.cshtml"
  
    ViewData["Title"] = "Contact";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""table-responsive m-b-40"" style=""margin-top:100px"">
    <table class=""table table-borderless table-data3"">
        <thead>
            <tr>
                <th>Mesaj Id</th>
                <th>Ad-Soyad</th>
                <th>Mail</th>
                <th>Mesaj Başlık</th>
                <th>Alınan Mesaj</th>
                <th>Okunma Bilgisi</th>
                <th>Okundu İşaretle</th>
                <th>Sil</th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 24 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Contact\Contact.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Contact\Contact.cshtml"
                   Write(item.ContactId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Contact\Contact.cshtml"
                   Write(item.ContactName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Contact\Contact.cshtml"
                                     Write(item.ContactSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Contact\Contact.cshtml"
                   Write(item.ContactMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Contact\Contact.cshtml"
                   Write(item.ContactTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Contact\Contact.cshtml"
                   Write(item.ContactMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 32 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Contact\Contact.cshtml"
                     if (item.ContactStatus == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"denied\">OKUNMADI</td>\r\n");
#nullable restore
#line 35 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Contact\Contact.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"process\">OKUNDU</td>\r\n");
#nullable restore
#line 39 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Contact\Contact.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1318, "\"", 1360, 2);
            WriteAttributeValue("", 1325, "/Admin/Contact/Read/", 1325, 20, true);
#nullable restore
#line 40 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Contact\Contact.cshtml"
WriteAttributeValue("", 1345, item.ContactId, 1345, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success btn-sm\">Okundu Olarak İşaretle</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1452, "\"", 1496, 2);
            WriteAttributeValue("", 1459, "/Admin/Contact/Delete/", 1459, 22, true);
#nullable restore
#line 41 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Contact\Contact.cshtml"
WriteAttributeValue("", 1481, item.ContactId, 1481, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\">Mesajı Sil</a></td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Contact\Contact.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </tbody>
    </table><br />



</div>

<h1 style=""text-align:center"">iLETİŞİM KURANLAR</h1>
<div class=""main-content"">
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">
            <div class=""row"">
");
#nullable restore
#line 58 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Contact\Contact.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-4"">
                        <div class=""card"">
                            <img class=""card-img-top"" src=""/Admin/images/icon/user.png"" alt=""Card image cap"">
                            <div class=""card-body"">
                                <h4 class=""card-title mb-3"">");
#nullable restore
#line 64 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Contact\Contact.cshtml"
                                                       Write(item.ContactName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 64 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Contact\Contact.cshtml"
                                                                         Write(item.ContactSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p class=\"card-text\">\r\n                                    ");
#nullable restore
#line 66 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Contact\Contact.cshtml"
                               Write(item.ContactMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 71 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Contact\Contact.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
