#pragma checksum "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\CategoryList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7401e25febadcd9023d38a0ef00f8820b383cf0e78af63e314c3b0cd4a54cae7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
#line 3 "D:\source\repos\CoreProject\CoreProject.UI\Views\_ViewImports.cshtml"
using CoreProject.EntityLayer.Concrete

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7401e25febadcd9023d38a0ef00f8820b383cf0e78af63e314c3b0cd4a54cae7", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e1d697866003d689d1d07aae15d21a18933dedeab4fb9c8d81fcd9115712be6c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\CategoryList\Default.cshtml"
       IEnumerable<CoreProject.EntityLayer.Concrete.Category>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"tech-btm\">\r\n\t<h4>Categories</h4>\r\n\t<ul class=\"list-group single\">\r\n");
#nullable restore
#line 5 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\CategoryList\Default.cshtml"
   foreach (var item in Model)
		{

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t\t<li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n\t\t\t\t");
            Write(
#nullable restore
#line 8 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\CategoryList\Default.cshtml"
     item.CategoryName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n\t\t\t\t<span class=\"badge badge-primary badge-pill\">");
            Write(
#nullable restore
#line 9 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                  item.CategoryName.Count()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</span>\r\n\t\t\t</li>\r\n");
#nullable restore
#line 11 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\CategoryList\Default.cshtml"
		}

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t\r\n\t</ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreProject.EntityLayer.Concrete.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
