#pragma checksum "D:\Rac\New folder (17)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\SingerAdmin\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0723a602e84d5a261d35f2702dcc54883c69cad5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SingerAdmin__StatusMessage), @"mvc.1.0.view", @"/Views/SingerAdmin/_StatusMessage.cshtml")]
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
#line 1 "D:\Rac\New folder (17)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\_ViewImports.cshtml"
using WebMusic_Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rac\New folder (17)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\_ViewImports.cshtml"
using WebMusic_Auth.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Rac\New folder (17)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\SingerAdmin\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rac\New folder (17)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\SingerAdmin\_ViewImports.cshtml"
using WebMusic_Auth.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Rac\New folder (17)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\SingerAdmin\_ViewImports.cshtml"
using WebMusic_Auth.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Rac\New folder (17)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\SingerAdmin\_ViewImports.cshtml"
using WebMusic_Auth.Areas.Admin.Pages.Role;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0723a602e84d5a261d35f2702dcc54883c69cad5", @"/Views/SingerAdmin/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf8be773f59b112d43771346aa58eef6b2780a56", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27f1ededab469d98b6dbd2e1c2a173c30e955535", @"/Views/SingerAdmin/_ViewImports.cshtml")]
    public class Views_SingerAdmin__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Rac\New folder (17)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\SingerAdmin\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 144, "\"", 201, 4);
            WriteAttributeValue("", 152, "alert", 152, 5, true);
            WriteAttributeValue(" ", 157, "alert-", 158, 7, true);
#nullable restore
#line 6 "D:\Rac\New folder (17)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\SingerAdmin\_StatusMessage.cshtml"
WriteAttributeValue("", 164, statusMessageClass, 164, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 183, "alert-dismissible", 184, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        ");
#nullable restore
#line 8 "D:\Rac\New folder (17)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\SingerAdmin\_StatusMessage.cshtml"
   Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 10 "D:\Rac\New folder (17)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\SingerAdmin\_StatusMessage.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
