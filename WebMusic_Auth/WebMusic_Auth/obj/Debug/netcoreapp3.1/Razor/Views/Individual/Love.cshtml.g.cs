#pragma checksum "D:\MusicFramework\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\Individual\Love.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "769efafb854c1215931c8f5aee267d29ea46448f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Individual_Love), @"mvc.1.0.view", @"/Views/Individual/Love.cshtml")]
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
#line 1 "D:\MusicFramework\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\_ViewImports.cshtml"
using WebMusic_Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MusicFramework\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\_ViewImports.cshtml"
using WebMusic_Auth.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"769efafb854c1215931c8f5aee267d29ea46448f", @"/Views/Individual/Love.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf8be773f59b112d43771346aa58eef6b2780a56", @"/Views/_ViewImports.cshtml")]
    public class Views_Individual_Love : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\MusicFramework\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\Individual\Love.cshtml"
  
    ViewData["Title"] = "Listened";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "769efafb854c1215931c8f5aee267d29ea46448f3329", async() => {
                WriteLiteral(@"
    <section class=""pt-5 pl-5"">
        <div class=""container px-xl-0"">
            <!-- Page Features-->
            <div class=""row gx-xl-0 justify-content-center"">
                <div class=""col-lg-4 col-xl-4 ml-0 text-center"">
                    <img id=""avatar"" src=""../../images/c2.jpg"" alt=""Photo"" width=""40%"">
                </div>
            </div>
            <div class=""row gx-xl-0 justify-content-center"">
                <div class=""col-lg-8  col-xl-8 mt-3 text-center"">
                    <h2>tên user</h2>
                </div>
            </div>
            <div class=""row gx-xl-3 justify-content-center mt-5"">
                <div class=""col-lg-2 text-center"">
                    <a href=""/Individual/Playlist""><button class=""btn btn-success"">Playlist của tôi</button></a>
                </div>
                <div class=""col-lg-2 text-center"">
                    <a href=""/Individual/Listened""><button class=""btn btn-success"">Đã nghe</button></a>
                </div>
  ");
                WriteLiteral(@"              <div class=""col-lg-2 text-center"">
                    <button class=""btn btn-success"">Yêu thích</button>
                </div>
            </div>

            <div class=""row gx-xl-3 justify-content-center mt-5"">
                <div class=""col-lg-8 col-xl-8 mb-5 text-center"">
                    <div class=""card border-left-info shadow h-100 py-0"">
                        <div class=""card-body text-center p-4 p-lg-0 pt-0 pt-lg-4"">
                            <div class=""table-responsive"">
                                <table class=""table table-hover text-left"">
                                    <tbody id=""table_1"">
                                        <tr>
                                            <td class=""Anh"">
                                                <img class=""avatar_table"" src=""../../images/avata.jpg"" alt=""BH"">
                                            </td>
                                            <td class=""name"">
                                ");
                WriteLiteral(@"                <dl>
                                                    <dt>BH 1</dt>
                                                    <dd class=""TacGia"">Nguyễn Văn Quyết</dd>
                                                </dl>

                                            </td>
                                            <td>

                                                <span id=""Control1"">
                                                    <Button onclick=""Play(1)"" class=""btn btn-primary""><i class=""bi bi-play""></i></Button>
                                                </span>


                                            </td>
                                            <td>
                                                <Button class=""btn btn-danger"">Xoá</Button>


                                            </td>
                                        </tr>
                                        <tr>
                                            <td class=""Anh"">
       ");
                WriteLiteral(@"                                         <img class=""avatar_table"" src=""../../images/avata.jpg"" alt=""BH"">
                                            </td>
                                            <td class=""name"">
                                                <dl>
                                                    <dt>BH 1</dt>
                                                    <dd class=""TacGia"">Nguyễn Văn Quyết</dd>
                                                </dl>

                                            </td>
                                            <td>

                                                <span id=""Control2"">
                                                    <Button onclick=""Play(2)"" class=""btn btn-primary""><i class=""bi bi-play""></i></Button>
                                                </span>

                                            </td>
                                            <td>
                                                <Button cla");
                WriteLiteral(@"ss=""btn btn-danger"">Xoá</Button>


                                            </td>
                                        </tr>
                                        <tr>
                                            <td class=""Anh"">
                                                <img class=""avatar_table"" src=""../../images/avata.jpg"" alt=""BH"">
                                            </td>
                                            <td class=""name"">
                                                <dl>
                                                    <dt>BH 1</dt>
                                                    <dd class=""TacGia"">Nguyễn Văn Quyết</dd>
                                                </dl>

                                            </td>
                                            <td>

                                                <span id=""Control3"">
                                                    <Button onclick=""Play(3)"" class=""btn btn-primary""><i cl");
                WriteLiteral(@"ass=""bi bi-play""></i></Button>
                                                </span>

                                            </td>
                                            <td>
                                                <Button class=""btn btn-danger"">Xoá</Button>
                                            </td>
                                        </tr>

                                    </tbody>

                                </table>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </section>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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