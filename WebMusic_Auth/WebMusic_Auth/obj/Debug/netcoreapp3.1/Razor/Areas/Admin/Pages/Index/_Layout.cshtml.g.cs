#pragma checksum "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Areas\Admin\Pages\Index\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "949c2b873ed17e05bbc27cc65bbc6e2f93b47712"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Pages_Index__Layout), @"mvc.1.0.view", @"/Areas/Admin/Pages/Index/_Layout.cshtml")]
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
#line 1 "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Areas\Admin\Pages\Index\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Areas\Admin\Pages\Index\_ViewImports.cshtml"
using WebMusic_Auth.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Areas\Admin\Pages\Index\_ViewImports.cshtml"
using WebMusic_Auth.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Areas\Admin\Pages\Index\_ViewImports.cshtml"
using WebMusic_Auth.Areas.Admin.Pages.Role;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"949c2b873ed17e05bbc27cc65bbc6e2f93b47712", @"/Areas/Admin/Pages/Index/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27f1ededab469d98b6dbd2e1c2a173c30e955535", @"/Areas/Admin/Pages/Index/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_Index__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "/Areas/Admin/Pages/_SideBar.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Areas\Admin\Pages\Index\_Layout.cshtml"
  
    Layout = "/Views/Shared/Admin/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n");
#nullable restore
#line 5 "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Areas\Admin\Pages\Index\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("TopBar", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 7 "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Areas\Admin\Pages\Index\_Layout.cshtml"
Write(await Html.PartialAsync("/Views/Shared/Admin/_TopBar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("SideBar", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "949c2b873ed17e05bbc27cc65bbc6e2f93b477125149", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 15 "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Areas\Admin\Pages\Index\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
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
