#pragma checksum "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\BlogLast3Post\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f0e912891594de97488a03facc952b043622bce1b14aab140b14d9b05415e69a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Shared_Components_BlogLast3Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
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
#line 1 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\BlogLast3Post\Default.cshtml"
 using CoreProject.EntityLayer.Concrete

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f0e912891594de97488a03facc952b043622bce1b14aab140b14d9b05415e69a", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e1d697866003d689d1d07aae15d21a18933dedeab4fb9c8d81fcd9115712be6c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Shared_Components_BlogLast3Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 2 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\BlogLast3Post\Default.cshtml"
       List<Blog>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/images/4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n\t\r\n");
#nullable restore
#line 6 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\BlogLast3Post\Default.cshtml"
  foreach (var item in Model)
	{

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t<h3>");
            Write(
#nullable restore
#line 8 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\BlogLast3Post\Default.cshtml"
       item.Title

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h3>\r\n\t\t<div class=\"blog-grids row mb-3\">\r\n\t\t\t<div class=\"col-md-5 blog-grid-left\">\r\n\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 233, "\"", 262, 2);
            WriteAttributeValue("", 240, "/blog/details/", 240, 14, true);
            WriteAttributeValue("", 254, 
#nullable restore
#line 11 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                            item.Id

#line default
#line hidden
#nullable disable
            , 254, 8, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f0e912891594de97488a03facc952b043622bce1b14aab140b14d9b05415e69a6041", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t</a>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-md-7 blog-grid-right\">\r\n\r\n\t\t\t\t<h5>\r\n\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 424, "\"", 453, 2);
            WriteAttributeValue("", 431, "/blog/details/", 431, 14, true);
            WriteAttributeValue("", 445, 
#nullable restore
#line 18 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                             item.Id

#line default
#line hidden
#nullable disable
            , 445, 8, false);
            EndWriteAttribute();
            WriteLiteral(">");
            Write(
#nullable restore
#line 18 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                       item.Content.Substring(0,item.Content.Substring(0,10).LastIndexOf(" "))

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("...</a>\r\n\t\t\t\t</h5>\r\n\t\t\t\t<div class=\"sub-meta\">\r\n\t\t\t\t\t<span>\r\n\t\t\t\t\t\t<i class=\"far fa-clock\"></i> ");
            Write(
#nullable restore
#line 22 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                     ((DateTime)item.CreateDate).ToString("MM/dd/yyyy")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n\t\t\t\t\t</span>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\r\n\t\t</div>\r\n");
#nullable restore
#line 28 "D:\source\repos\CoreProject\CoreProject.UI\Views\Shared\Components\BlogLast3Post\Default.cshtml"
	}

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\r\n</div>");
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
