#pragma checksum "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Project\ProjectAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6d27922845e87ea35e5066bc8665b408c452739"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Project_ProjectAdd), @"mvc.1.0.view", @"/Areas/Admin/Views/Project/ProjectAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6d27922845e87ea35e5066bc8665b408c452739", @"/Areas/Admin/Views/Project/ProjectAdd.cshtml")]
    public class Areas_Admin_Views_Project_ProjectAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Project\ProjectAdd.cshtml"
  
    ViewData["Title"] = "ProjectAdd";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12"" style=""margin-block:225px"">
    <div class=""card"">
        <div class=""card-header"">Proje</div>
        <div class=""card-body"">
            <div class=""card-title"">
                <h3 class=""text-center title-2"">Eklenen Proje</h3>
            </div>
            <hr>
            <form action=""/Admin/Project/ProjectAdd"" method=""post"">
                <div class=""form-group"">
                    <label for=""cc-payment"" class=""control-label mb-1"">Proje Adı</label>
                    <input name=""ProjectName"" type=""text"" class=""form-control"">
                </div>
                <div class=""form-group"">
                    <label for=""cc-payment"" class=""control-label mb-1"">Proje Başlık</label>
                    <input name=""ProjectTitle"" type=""text"" class=""form-control"">
                </div>
                <div class=""form-group"">
                    <label for=""cc-payment"" class=""control-label mb-1"">Proje Açıklama</label>
                    <input name=""Projec");
            WriteLiteral(@"tDesciription"" type=""text"" class=""form-control"">
                </div>
                <div class=""form-group"">
                    <label for=""cc-payment"" class=""control-label mb-1"">Proje Img Url</label>
                    <input name=""ProjectImgUrl"" type=""text"" class=""form-control"">
                </div>
                <div class=""form-group"">
                    <label for=""cc-payment"" class=""control-label mb-1"">Proje Githup Url</label>
                    <input name=""ProjectUrl"" type=""text"" class=""form-control"">
                </div>
                <div class=""form-group"">
                    <label for=""cc-payment"" class=""control-label mb-1"">Proje Oluşturulma Tarihi </label>
                    <input name=""Date"" type=""date"" class=""form-control"">
                </div>
                <div>
                    <button id=""payment-button"" type=""submit"" class=""btn btn-lg btn-success btn-block"" style=""margin-block :20px"">
                        <i class=""fa fa-save fa-lg""></i>&nbsp;");
            WriteLiteral("\n                        <span id=\"payment-button-amount\">Ekle</span>\r\n                    </button>\r\n                </div>\r\n            </form>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
