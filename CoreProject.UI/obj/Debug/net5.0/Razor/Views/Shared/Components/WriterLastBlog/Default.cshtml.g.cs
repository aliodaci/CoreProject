#pragma checksum "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\WriterLastBlog\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b646314cb77f7021edc22e5341af2ac35d7e857e0fe652c312183311114c3d7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Shared_Components_WriterLastBlog_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterLastBlog/Default.cshtml")]
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
#line 1 "D:\source\repos\CoreProject\CoreProject.UI\Views\_ViewImports.cshtml"
using CoreProject.UI

#nullable disable
    ;
#nullable restore
#line 2 "D:\source\repos\CoreProject\CoreProject.UI\Views\_ViewImports.cshtml"
using CoreProject.UI.Models

#nullable disable
    ;
#nullable restore
#line 1 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\WriterLastBlog\Default.cshtml"
 using CoreProject.EntityLayer.Concrete

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b646314cb77f7021edc22e5341af2ac35d7e857e0fe652c312183311114c3d7a", @"/Views/Shared/Components/WriterLastBlog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e1d697866003d689d1d07aae15d21a18933dedeab4fb9c8d81fcd9115712be6c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Shared_Components_WriterLastBlog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 2 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\WriterLastBlog\Default.cshtml"
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
            WriteLiteral("<div class=\"tech-btm\">\r\n\t<h4>Yazarın diğer yazıları</h4>\r\n");
#nullable restore
#line 5 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\WriterLastBlog\Default.cshtml"
  foreach (var item in Model)
	{

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t<div class=\"blog-grids row mb-3\">\r\n\t\t\t<div class=\"col-md-5 blog-grid-left\">\r\n\t\t\t\t<a href=\"single.html\">\r\n\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 269, "\"", 286, 1);
            WriteAttributeValue("", 275, 
#nullable restore
#line 10 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\WriterLastBlog\Default.cshtml"
                item.Image

#line default
#line hidden
#nullable disable
            , 275, 11, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 305, "\"", 311, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t</a>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-md-7 blog-grid-right\">\r\n\r\n\t\t\t\t<h5>\r\n\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 398, "\"", 427, 2);
            WriteAttributeValue("", 405, "/Blog/Details/", 405, 14, true);
            WriteAttributeValue("", 419, 
#nullable restore
#line 16 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\WriterLastBlog\Default.cshtml"
                             item.Id

#line default
#line hidden
#nullable disable
            , 419, 8, false);
            EndWriteAttribute();
            WriteLiteral(">");
            Write(
#nullable restore
#line 16 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\WriterLastBlog\Default.cshtml"
                                       item.Title

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" </a>\r\n\t\t\t\t</h5>\r\n\t\t\t\t<div class=\"sub-meta\">\r\n\t\t\t\t\t<span>\r\n\t\t\t\t\t\t<i class=\"far fa-clock\"></i>");
            Write(
#nullable restore
#line 20 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\WriterLastBlog\Default.cshtml"
                                    ((DateTime)item.CreateDate).ToString("MM/dd/yyyy")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n\t\t\t\t\t</span>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\r\n\t\t</div>\r\n");
#nullable restore
#line 26 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\WriterLastBlog\Default.cshtml"
	}

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t\r\n</div>");
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
