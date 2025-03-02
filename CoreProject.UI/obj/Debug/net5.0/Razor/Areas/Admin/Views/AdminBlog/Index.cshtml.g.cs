#pragma checksum "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\AdminBlog\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f3d30a61f6fe3c974d4a12dde471d32af104e73216c4248e26bfabbd132cdedb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Areas_Admin_Views_AdminBlog_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminBlog/Index.cshtml")]
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
#line 1 "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\AdminBlog\Index.cshtml"
 using CoreProject.EntityLayer.Concrete

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f3d30a61f6fe3c974d4a12dde471d32af104e73216c4248e26bfabbd132cdedb", @"/Areas/Admin/Views/AdminBlog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"eba340c0d91299a7d875c6f6663fe4fdc1fce1e9e7ef54e8c0cd3af91c510eb0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Areas_Admin_Views_AdminBlog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 2 "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\AdminBlog\Index.cshtml"
       List<Blog>

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
#line 3 "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\AdminBlog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 12 "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\AdminBlog\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <div class=\"col-md-3\">\r\n            <div class=\"ibox\">\r\n                <div class=\"ibox-content product-box\">\r\n\r\n                    <div>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 398, "\"", 415, 1);
            WriteAttributeValue("", 404, 
#nullable restore
#line 19 "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                   item.Image

#line default
#line hidden
#nullable disable
            , 404, 11, false);
            EndWriteAttribute();
            WriteLiteral(" height=\"225\" width=\"240\" />\r\n                    </div>\r\n                    <div class=\"product-desc\">\r\n                        <span class=\"product-price\">\r\n                            ");
            Write(
#nullable restore
#line 23 "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\AdminBlog\Index.cshtml"
                              ((DateTime)item.CreateDate).ToString("MM/dd/yyyy")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                        </span>\r\n                        <small class=\"text-muted\">");
            Write(
#nullable restore
#line 25 "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                                   item.Category.CategoryName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</small>\r\n                        <a href=\"#\" class=\"product-name\"> ");
            Write(
#nullable restore
#line 26 "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                                           item.Title

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</a>\r\n\r\n\r\n\r\n                        <div class=\"small m-t-xs\">\r\n                            ");
            Write(
#nullable restore
#line 31 "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\AdminBlog\Index.cshtml"
                             item.Content.Substring(0,item.Content.Substring(0,20).LastIndexOf(" "))

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("...\r\n                        </div>\r\n                        <div class=\"m-t text-righ\">\r\n\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1134, "\"", 1163, 2);
            WriteAttributeValue("", 1141, "/blog/details/", 1141, 14, true);
            WriteAttributeValue("", 1155, 
#nullable restore
#line 35 "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                                    item.Id

#line default
#line hidden
#nullable disable
            , 1155, 8, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-xs btn-outline btn-primary\">Detaylar <i class=\"fa fa-long-arrow-right\"></i> </a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 41 "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\AdminBlog\Index.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("    \r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
