#pragma checksum "C:\Users\Sevgül KETENCİ\Source\Repos\Portföy\Portöy\Areas\Admin\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b6601ff7daed5f4ef9ad63221af24d4e4883221"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b6601ff7daed5f4ef9ad63221af24d4e4883221", @"/Areas/Admin/Views/Admin/Index.cshtml")]
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
            WriteLiteral(@"
                </div>
            </div><br />

            <br />
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""au-card au-card--no-shadow au-card--no-pad m-b-40"">
                        <div class=""au-card-title"" style=""background-image:url('images/bg-title-02.jpg');"">
                            <div class=""bg-overlay bg-overlay--blue""></div>
                            <h3>
                                <i class=""zmdi zmdi-comment-text""></i>Son Gelen Mesajlar
                            </h3>

                        </div>
                        <div class=""au-inbox-wrap js-inbox-wrap"">
                            <div class=""au-message js-list-load"">
                                <div class=""au-message__noti"">
                                    <p>
                                        Okunmamış
                                        <span>2</span>

                                        adet mesaj
              ");
            WriteLiteral(@"                      </p>
                                </div>
                                <div class=""au-message-list"">
                                    <div class=""au-message__item unread"">
                                        <div class=""au-message__item-inner"">
                                            <div class=""au-message__item-text"">
                                                <div class=""avatar-wrap"">
                                                    <div class=""avatar"">
                                                        <img src=""images/icon/avatar-02.jpg"" alt=""John Smith"">
                                                    </div>
                                                </div>
                                                <div class=""text"">
                                                    <h5 class=""name"">John Smith</h5>
                                                    <p>Have sent a photo</p>
                                                </");
            WriteLiteral(@"div>
                                            </div>
                                            <div class=""au-message__item-time"">
                                                <span>12 Min ago</span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""au-message__item unread"">
                                        <div class=""au-message__item-inner"">
                                            <div class=""au-message__item-text"">
                                                <div class=""avatar-wrap online"">
                                                    <div class=""avatar"">
                                                        <img src=""images/icon/avatar-03.jpg"" alt=""Nicholas Martinez"">
                                                    </div>
                                                </div>
                                           ");
            WriteLiteral(@"     <div class=""text"">
                                                    <h5 class=""name"">Nicholas Martinez</h5>
                                                    <p>You are now connected on message</p>
                                                </div>
                                            </div>
                                            <div class=""au-message__item-time"">
                                                <span>11:00 PM</span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""au-message__item"">
                                        <div class=""au-message__item-inner"">
                                            <div class=""au-message__item-text"">
                                                <div class=""avatar-wrap online"">
                                                    <div class=""avatar"">
                          ");
            WriteLiteral(@"                              <img src=""images/icon/avatar-04.jpg"" alt=""Michelle Sims"">
                                                    </div>
                                                </div>
                                                <div class=""text"">
                                                    <h5 class=""name"">Michelle Sims</h5>
                                                    <p>Lorem ipsum dolor sit amet</p>
                                                </div>
                                            </div>
                                            <div class=""au-message__item-time"">
                                                <span>Yesterday</span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""au-message__item"">
                                        <div class=""au-message__item-inner"">
                        ");
            WriteLiteral(@"                    <div class=""au-message__item-text"">
                                                <div class=""avatar-wrap"">
                                                    <div class=""avatar"">
                                                        <img src=""images/icon/avatar-05.jpg"" alt=""Michelle Sims"">
                                                    </div>
                                                </div>
                                                <div class=""text"">
                                                    <h5 class=""name"">Michelle Sims</h5>
                                                    <p>Purus feugiat finibus</p>
                                                </div>
                                            </div>
                                            <div class=""au-message__item-time"">
                                                <span>Sunday</span>
                                            </div>
                                      ");
            WriteLiteral(@"  </div>
                                    </div>
                                    <div class=""au-message__item js-load-item"">
                                        <div class=""au-message__item-inner"">
                                            <div class=""au-message__item-text"">
                                                <div class=""avatar-wrap online"">
                                                    <div class=""avatar"">
                                                        <img src=""images/icon/avatar-04.jpg"" alt=""Michelle Sims"">
                                                    </div>
                                                </div>
                                                <div class=""text"">
                                                    <h5 class=""name"">Michelle Sims</h5>
                                                    <p>Lorem ipsum dolor sit amet</p>
                                                </div>
                                           ");
            WriteLiteral(@" </div>
                                            <div class=""au-message__item-time"">
                                                <span>Yesterday</span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""au-message__item js-load-item"">
                                        <div class=""au-message__item-inner"">
                                            <div class=""au-message__item-text"">
                                                <div class=""avatar-wrap"">
                                                    <div class=""avatar"">
                                                        <img src=""images/icon/avatar-05.jpg"" alt=""Michelle Sims"">
                                                    </div>
                                                </div>
                                                <div class=""text"">
                              ");
            WriteLiteral(@"                      <h5 class=""name"">Michelle Sims</h5>
                                                    <p>Purus feugiat finibus</p>
                                                </div>
                                            </div>
                                            <div class=""au-message__item-time"">
                                                <span>Sunday</span>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>

                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
</div>
");
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
