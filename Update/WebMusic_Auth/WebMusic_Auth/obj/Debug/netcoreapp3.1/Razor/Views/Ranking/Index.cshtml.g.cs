#pragma checksum "D:\MusicFramework\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Views\Ranking\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "031643b9d7fe0f82e7665e8ae7dfe2fd9228c441"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ranking_Index), @"mvc.1.0.view", @"/Views/Ranking/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"031643b9d7fe0f82e7665e8ae7dfe2fd9228c441", @"/Views/Ranking/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf8be773f59b112d43771346aa58eef6b2780a56", @"/Views/_ViewImports.cshtml")]
    public class Views_Ranking_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/scripts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "031643b9d7fe0f82e7665e8ae7dfe2fd9228c4414533", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta2/css/all.min.css""
        integrity=""sha512-YWzhKL2whUzgiheMoBFwW8CKV4qpHQAEuvilg9FAn5VJUDwKZZxkJNuGM4XkWuk94WCrrwslk8yWNGmY1EduTA==""
        crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "031643b9d7fe0f82e7665e8ae7dfe2fd9228c4415274", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <title>BXH</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "031643b9d7fe0f82e7665e8ae7dfe2fd9228c4417187", async() => {
                WriteLiteral(@"
    <div class=""chart-section"">
        <div class=""chart-section__header"">
            <a href=""#"">
                Bảng Xếp Hạng
                <i class=""fas fa-chevron-right""></i>
            </a>
        </div>
        <div class=""chart-section__body"">
            <div class=""chart-list-song"">
                <div class=""chart-list-song__item"">
                    <div class=""chart-list-song__info"">
                        <div class=""number-rating top-1-rating"">
                            1
                        </div>
                        <div class=""line""></div>

                        <div class=""chart-item-info"">
                            <div class=""chart-item-info__imgBox"">
                                <img src=""https://photo-resize-zmp3.zadn.vn/w94_r1x1_webp/cover/a/f/2/a/af2a52d9784647085f1466075e96c009.jpg""
                                    alt=""song1"">
                            </div>
                            <div class=""chart-item-info__name"">
      ");
                WriteLiteral(@"                          <h4>Sau Này Nếu Có Yêu Ai</h4>
                                <div class=""chart-item-info__name-singer"">
                                    <a href=""#"">Tăng Phúc, </a>
                                    <a href=""#"">Ngô Kiến Huy</a>
                                </div>
                            </div>
                            <!-- Button play when hover item -->
                            <button class=""chart-item-play-btn"">
                                <i class=""fas fa-play""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""chart-item-album"">
                        <a href=""#"">
                            Sau Này Nếu Có Yêu Ai (Single)
                        </a>
                    </div>
                    <div class=""chart-item-time"">03:13</div>
                </div>

                <div class=""chart-list-song__item"">
                    <div class=""chart-list");
                WriteLiteral(@"-song__info"">
                        <div class=""number-rating top-2-rating"">
                            2
                        </div>
                        <div class=""line""></div>

                        <div class=""chart-item-info"">
                            <div class=""chart-item-info__imgBox"">
                                <img src=""https://photo-resize-zmp3.zadn.vn/w94_r1x1_webp/cover/3/a/1/a/3a1aad7f3f927dece72b0d57642f5c8a.jpg""
                                    alt=""song2"">
                            </div>
                            <div class=""chart-item-info__name"">
                                <h4>Là Ai Từ Bỏ, Là Ai Vô Tình</h4>
                                <div class=""chart-item-info__name-singer"">
                                    <a href=""#"">Hương Ly, </a>
                                    <a href=""#"">Jombie</a>
                                </div>
                            </div>
                            <!-- Button play when hover item -->
 ");
                WriteLiteral(@"                           <button class=""chart-item-play-btn"">
                                <i class=""fas fa-play""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""chart-item-album"">
                        <a href=""#"">
                            Là Ai Từ Bỏ, Là Ai Vô Tình (Single)
                        </a>
                    </div>
                    <div class=""chart-item-time"">03:37</div>
                </div>

                <div class=""chart-list-song__item"">
                    <div class=""chart-list-song__info"">
                        <div class=""number-rating top-3-rating"">
                            3
                        </div>
                        <div class=""line""></div>

                        <div class=""chart-item-info"">
                            <div class=""chart-item-info__imgBox"">
                                <img src=""https://photo-resize-zmp3.zadn.vn/w94_r1x1_");
                WriteLiteral(@"webp/cover/f/c/2/8/fc28119fe63bad8efc51cdb1f2d13a69.jpg""
                                    alt=""song3"">
                            </div>
                            <div class=""chart-item-info__name"">
                                <h4>Thay Lòng</h4>
                                <div class=""chart-item-info__name-singer"">
                                    <a href=""#"">DIMZ, </a>
                                    <a href=""#"">Tvk, </a>
                                    <a href=""#"">NH4T</a>
                                </div>
                            </div>
                            <!-- Button play when hover item -->
                            <button class=""chart-item-play-btn"">
                                <i class=""fas fa-play""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""chart-item-album"">
                        <a href=""#"">
                            Thay Lòng (Single)
    ");
                WriteLiteral(@"                    </a>
                    </div>
                    <div class=""chart-item-time"">04:36</div>
                </div>

                <div class=""chart-list-song__item"">
                    <div class=""chart-list-song__info"">
                        <div class=""number-rating top-default-rating"">
                            4
                        </div>
                        <div class=""line""></div>

                        <div class=""chart-item-info"">
                            <div class=""chart-item-info__imgBox"">
                                <img src=""https://photo-resize-zmp3.zadn.vn/w94_r1x1_webp/cover/1/7/d/f/17df138d6b0c38c8a07ee502a49573cd.jpg""
                                    alt=""song"">
                            </div>
                            <div class=""chart-item-info__name"">
                                <h4>Cưa là đổ</h4>
                                <div class=""chart-item-info__name-singer"">
                                    <a hre");
                WriteLiteral(@"f=""#"">Phát Hồ, </a>
                                    <a href=""#"">X2X</a>
                                </div>
                            </div>
                            <!-- Button play when hover item -->
                            <button class=""chart-item-play-btn"">
                                <i class=""fas fa-play""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""chart-item-album"">
                        <a href=""#"">
                            Cưa là đổ (Single)
                        </a>
                    </div>
                    <div class=""chart-item-time"">03:31</div>
                </div>

                <div class=""chart-list-song__item"">
                    <div class=""chart-list-song__info"">
                        <div class=""number-rating top-default-rating"">
                            5
                        </div>
                        <div class=""line""></div>");
                WriteLiteral(@"

                        <div class=""chart-item-info"">
                            <div class=""chart-item-info__imgBox"">
                                <img src=""https://photo-resize-zmp3.zadn.vn/w94_r1x1_webp/cover/b/6/9/d/b69dc87af076d5e022064e68fc0a81c1.jpg""
                                    alt=""song"">
                            </div>
                            <div class=""chart-item-info__name"">
                                <h4>Thì thôi</h4>
                                <div class=""chart-item-info__name-singer"">
                                    <a href=""#"">Tvk, </a>
                                    <a href=""#"">Nal, </a>
                                    <a href=""#"">93NEW-G</a>
                                </div>
                            </div>
                            <!-- Button play when hover item -->
                            <button class=""chart-item-play-btn"">
                                <i class=""fas fa-play""></i>
                            </b");
                WriteLiteral(@"utton>
                        </div>
                    </div>
                    <div class=""chart-item-album"">
                        <a href=""#"">
                            Thì thôi (Single)
                        </a>
                    </div>
                    <div class=""chart-item-time"">04:08</div>
                </div>
            </div>
        </div>
    </div>
    
");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "031643b9d7fe0f82e7665e8ae7dfe2fd9228c44116511", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
