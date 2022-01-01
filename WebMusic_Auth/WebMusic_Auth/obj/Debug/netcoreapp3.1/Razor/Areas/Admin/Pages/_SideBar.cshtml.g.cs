#pragma checksum "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Areas\Admin\Pages\_SideBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebcc6a72346a203135da0bae2da86789c34d81ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Pages__SideBar), @"mvc.1.0.view", @"/Areas/Admin/Pages/_SideBar.cshtml")]
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
#line 1 "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Areas\Admin\Pages\_SideBar.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Areas\Admin\Pages\_SideBar.cshtml"
using WebMusic_Auth.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebcc6a72346a203135da0bae2da86789c34d81ec", @"/Areas/Admin/Pages/_SideBar.cshtml")]
    public class Areas_Admin_Pages__SideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Rac\New folder (20)\framework_IS220.M11_15\WebMusic_Auth\WebMusic_Auth\Areas\Admin\Pages\_SideBar.cshtml"
  
    var hasExternalLogins = (await SignInManager.GetExternalAuthenticationSchemesAsync()).Any();
    string activePage = System.IO.Path.GetFileNameWithoutExtension(ViewContext.ActionDescriptor.DisplayName);
    Func<string, string, string> ActiveClass = (string activePage, string page) => {
        return (activePage == page) ? "active" : "";
    };

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<ul class=""navbar-nav bg-gradient-primary sidebar sidebar-dark accordion"" id=""accordionSidebar"">

            <!-- Sidebar - Brand -->
            <a class=""sidebar-brand d-flex align-items-center justify-content-center""
            asp-action=""Index"" asp-controller=""Home""");
            BeginWriteAttribute("asp-area", " asp-area=\"", 754, "\"", 765, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""sidebar-brand-icon rotate-n-15"">
                </div>
                <div class=""sidebar-brand-text mx-5 text-white""><b><h3>WebMusic</h3></b></div>
            </a>

            <!-- Divider -->
            <hr class=""sidebar-divider my-0"">

            <!-- Heading -->
            <div class=""sidebar-heading mt-2"">
                Quản lý người dùng
            </div>

            <!-- Nav Item - Pages Collapse Menu -->
            <li class=""nav-item"">
                <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseUserManage"" aria-expanded=""true"" aria-controls=""collapseTwo"">
                    
                    <span>Quản lý thành viên</span>
                </a>
                <div id=""collapseUserManage"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                    <div class=""bg-white py-2 collapse-inner rounded"">
                        <h6 class=""collapse-header"">Chức nă");
            WriteLiteral(@"ng</h6>
                        <a class=""collapse-item"" href=""/admin/taikhoan/thanhvien/"">Thành viên</a>                        
                        <a class=""collapse-item"" href=""/commentsadmin/"">Bình luận</a>
                        <a class=""collapse-item"" href=""/admin/taikhoan/chan/"">Danh sách chặn</a>
                    </div>
                </div>
            </li>
            <!-- Nav Item - Pages Collapse Menu -->
            <li class=""nav-item"">
                <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapsePhanquyen"" aria-expanded=""true"" aria-controls=""collapseTwo"">
                    <span>Phân quyền</span>
                </a>
                <div id=""collapsePhanquyen"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                    <div class=""bg-white py-2 collapse-inner rounded"">
                        <a class=""collapse-item "" href=""/admin/Role/"" asp-area=""Admin"">Vai trò - Role</a>
                ");
            WriteLiteral(@"        <a class=""collapse-item "" href=""/admin/role/users/"" asp-area=""Admin"">Gán vai trò</a>
                    </div>
                </div>
            </li>

            <!-- Divider -->
            <hr class=""sidebar-divider d-none d-md-block"">

            <!-- Heading -->
            <div class=""sidebar-heading mt-2"">
                Quản lý dữ liệu
            </div>
               <!-- Nav Item - Pages Collapse Menu -->
            <li class=""nav-item"">
                <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapsePosts"" aria-expanded=""true"" aria-controls=""collapseTwo"">
                    <span>Quản lý bài hát</span>
                </a>
                <div id=""collapsePosts"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                    <div class=""bg-white py-2 collapse-inner rounded"">
                        <a class=""collapse-item"" href=""/songadmin/""> Bài hát</a>
                        <a class=""colla");
            WriteLiteral(@"pse-item"" href=""/singeradmin/""> Ca sĩ</a>
                        <a class=""collapse-item"" href=""/albumadmin/""> Album</a>
                        <a class=""collapse-item"" href=""/categoryadmin/""> Thể loại</a>

                    </div>
                </div>
            </li>
          


            <!-- Divider -->
            <hr class=""sidebar-divider d-none d-md-block"">

            <!-- Sidebar Toggler (Sidebar) -->
        </ul>
        <!-- End of Sidebar -->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUser> SignInManager { get; private set; }
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
