#pragma checksum "D:\source\repos\CoreProject\CoreProject.UI\Views\About\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cbd5035073314a46ca86ee4b181575c7e065ae169fa95308fb2ab8af832d0e55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "D:\source\repos\CoreProject\CoreProject.UI\Views\About\Index.cshtml"
 using CoreProject.EntityLayer.Concrete

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"cbd5035073314a46ca86ee4b181575c7e065ae169fa95308fb2ab8af832d0e55", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e1d697866003d689d1d07aae15d21a18933dedeab4fb9c8d81fcd9115712be6c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 2 "D:\source\repos\CoreProject\CoreProject.UI\Views\About\Index.cshtml"
       List<About>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/images/b5.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "D:\source\repos\CoreProject\CoreProject.UI\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<section class=""main-content-w3layouts-agileits"">
	<div class=""container"">
		<h3 class=""tittle"">About</h3>
		<div class=""row inner-sec"">
			<!--left-->
			<div class=""col-lg-8 left-blog-info-w3layouts-agileits text-left"">
				<div class=""blog-grid-top"">
					<div class=""blog_info_left_grid"">
						<a href=""single.html"">
							");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cbd5035073314a46ca86ee4b181575c7e065ae169fa95308fb2ab8af832d0e555250", async() => {
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
            WriteLiteral("\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\r\n");
#nullable restore
#line 21 "D:\source\repos\CoreProject\CoreProject.UI\Views\About\Index.cshtml"
      foreach (var item in Model)
					{

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t\t\t\t\t<h3>\r\n\t\t\t\t\t\t\tAmet consectetur adipisicing\r\n\t\t\t\t\t\t</h3>\r\n\t\t\t\t\t\t<p>\r\n\t\t\t\t\t\t\t");
            Write(
#nullable restore
#line 27 "D:\source\repos\CoreProject\CoreProject.UI\Views\About\Index.cshtml"
        item.Details

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n\t\t\t\t\t\t</p>\r\n");
            WriteLiteral("\t\t\t\t\t\t<h3>\r\n\t\t\t\t\t\t\tAmet consectetur adipisicing\r\n\t\t\t\t\t\t</h3>\r\n\t\t\t\t\t\t<p>\r\n\t\t\t\t\t\t\t");
            Write(
#nullable restore
#line 34 "D:\source\repos\CoreProject\CoreProject.UI\Views\About\Index.cshtml"
        item.Details2

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n\t\t\t\t\t\t</p>\r\n");
#nullable restore
#line 36 "D:\source\repos\CoreProject\CoreProject.UI\Views\About\Index.cshtml"
					}

#line default
#line hidden
#nullable disable

            WriteLiteral(@"					
					<a href=""single.html"" class=""btn btn-primary read-m"">Read More</a>
				</div>
			</div>
			<!--//left-->
			<!--right-->
			<aside class=""col-lg-4 agileits-w3ls-right-blog-con text-right"">
				<div class=""right-blog-info text-left"">
					");
            Write(
#nullable restore
#line 45 "D:\source\repos\CoreProject\CoreProject.UI\Views\About\Index.cshtml"
      await Html.PartialAsync("~/Views/NewsLetter/SubscribeMail.cshtml")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n\t\t\t\t\t");
            Write(
#nullable restore
#line 46 "D:\source\repos\CoreProject\CoreProject.UI\Views\About\Index.cshtml"
      await Html.PartialAsync("~/Views/About/SocialMediaAbout.cshtml")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n\t\t\t\t\t\r\n\t\t\t\t\t<div class=\"tech-btm\">\r\n\t\t\t\t\t\t");
            Write(
#nullable restore
#line 49 "D:\source\repos\CoreProject\CoreProject.UI\Views\About\Index.cshtml"
       await Component.InvokeAsync("WriterLastBlog")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\r\n\t\t\t</aside>\r\n\t\t\t<!--//right-->\r\n\t\t</div>\r\n\t</div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<About>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
