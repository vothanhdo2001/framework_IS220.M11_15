#pragma checksum "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\MusicPlayer\SingerDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1671575415050d5d818162e1ccb6304c6fc9c53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MusicPlayer_SingerDetail), @"mvc.1.0.view", @"/Views/MusicPlayer/SingerDetail.cshtml")]
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
#line 1 "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\_ViewImports.cshtml"
using WebMusic_Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\_ViewImports.cshtml"
using WebMusic_Auth.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1671575415050d5d818162e1ccb6304c6fc9c53", @"/Views/MusicPlayer/SingerDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf8be773f59b112d43771346aa58eef6b2780a56", @"/Views/_ViewImports.cshtml")]
    public class Views_MusicPlayer_SingerDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SongModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"singer-detail\">\r\n    <div class=\"info-singer\">\r\n        <div>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 115, "\"", 137, 1);
#nullable restore
#line 5 "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\MusicPlayer\SingerDetail.cshtml"
WriteAttributeValue("", 121, ViewBag.SiPhoto, 121, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"img-singer\">\r\n            <h1>");
#nullable restore
#line 6 "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\MusicPlayer\SingerDetail.cshtml"
           Write(ViewBag.SiName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n        <p>");
#nullable restore
#line 8 "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\MusicPlayer\SingerDetail.cshtml"
      Write(ViewBag.Story);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"listsong-singer\">\r\n");
#nullable restore
#line 11 "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\MusicPlayer\SingerDetail.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <button>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 408, "\"", 425, 1);
#nullable restore
#line 15 "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\MusicPlayer\SingerDetail.cshtml"
WriteAttributeValue("", 414, item.Photo, 414, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"img-song\">\r\n                </button>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 489, "\"", 496, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\MusicPlayer\SingerDetail.cshtml"
                      Write(item.Song);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n");
#nullable restore
#line 19 "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\MusicPlayer\SingerDetail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SongModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
