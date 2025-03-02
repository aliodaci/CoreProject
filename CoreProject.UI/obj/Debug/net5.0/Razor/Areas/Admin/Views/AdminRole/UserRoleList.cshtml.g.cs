#pragma checksum "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\AdminRole\UserRoleList.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3a0581e99073dd0e88c26cddf12b0a7a07b132b2ba489adac38ec026c4de2a47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Areas_Admin_Views_AdminRole_UserRoleList), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminRole/UserRoleList.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\_ViewImports.cshtml"
using CoreProject.UI.Areas.Admin

#nullable disable
    ;
#nullable restore
#line 2 "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\_ViewImports.cshtml"
using CoreProject.UI.Areas.Admin.Models

#nullable disable
    ;
#nullable restore
#line 1 "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
 using CoreProject.EntityLayer.Concrete

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3a0581e99073dd0e88c26cddf12b0a7a07b132b2ba489adac38ec026c4de2a47", @"/Areas/Admin/Views/AdminRole/UserRoleList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"eba340c0d91299a7d875c6f6663fe4fdc1fce1e9e7ef54e8c0cd3af91c510eb0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Areas_Admin_Views_AdminRole_UserRoleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 2 "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
       List<AppUser>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
  
    ViewData["Title"] = "UserRoleList";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>Kullanıcı Rolleri</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Kullanıcı</th>\r\n        <th>Rol Ata</th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\r\n            <td>");
            Write(
#nullable restore
#line 17 "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
                 item.UserName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 416, "\"", 459, 2);
            WriteAttributeValue("", 423, "/Admin/AdminRole/AssignRole/", 423, 28, true);
            WriteAttributeValue("", 451, 
#nullable restore
#line 18 "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
                                                      item.Id

#line default
#line hidden
#nullable disable
            , 451, 8, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Role Ata</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 20 "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</table>\r\n<a href=\"/admin/adminrole/index\" class=\"btn btn-primary\">Role Listesine Dön</a>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
