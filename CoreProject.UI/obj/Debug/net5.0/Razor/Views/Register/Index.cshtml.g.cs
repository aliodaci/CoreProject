#pragma checksum "D:\source\repos\CoreProject\CoreProject.UI\Views\Register\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "95f4ba4b155d78011c7f71d386c978253701a946b8e91210b3cc631b66da1c79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"95f4ba4b155d78011c7f71d386c978253701a946b8e91210b3cc631b66da1c79", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e1d697866003d689d1d07aae15d21a18933dedeab4fb9c8d81fcd9115712be6c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "D:\source\repos\CoreProject\CoreProject.UI\Views\Register\Index.cshtml"
       CoreProject.EntityLayer.Concrete.Writer

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\source\repos\CoreProject\CoreProject.UI\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95f4ba4b155d78011c7f71d386c978253701a946b8e91210b3cc631b66da1c794636", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95f4ba4b155d78011c7f71d386c978253701a946b8e91210b3cc631b66da1c795699", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<section class=\"main-content-w3layouts-agileits\">\r\n\t<div class=\"container\">\r\n\t\t<h3 class=\"tittle\">Register Now</h3>\r\n\t\t<div class=\"inner-sec\">\r\n\t\t\t<div class=\"login p-5 bg-light mx-auto mw-100\">\r\n");
#nullable restore
#line 14 "D:\source\repos\CoreProject\CoreProject.UI\Views\Register\Index.cshtml"
     using(Html.BeginForm("Index","Register",FormMethod.Post,ValidationSummary.All))
				{
					

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 16 "D:\source\repos\CoreProject\CoreProject.UI\Views\Register\Index.cshtml"
      Html.ValidationSummary()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\t\t\t\t\t<div class=\"form-row\">\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t\t<div class=\"col-md-6 mb-3\">\r\n\t\t\t\t\t\t\t<label for=\"validationCustom01\">Adınız ve Soyadınız</label>\r\n\t\t\t\t\t\t\t");
            Write(
#nullable restore
#line 21 "D:\source\repos\CoreProject\CoreProject.UI\Views\Register\Index.cshtml"
        Html.TextBoxFor(x=>x.Name,new{@class="form-control"})

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n");
            WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-md-6 mb-3\">\r\n\t\t\t\t\t\t\t<label for=\"validationCustom02\">Email Adress</label>\r\n\t\t\t\t\t\t\t");
            Write(
#nullable restore
#line 26 "D:\source\repos\CoreProject\CoreProject.UI\Views\Register\Index.cshtml"
        Html.TextBoxFor(x => x.Email, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n");
            WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"form-row\">\r\n\t\t\t\t\t\t<div class=\"form-group col-md-6\">\r\n\t\t\t\t\t\t\t<label for=\"exampleInputPassword1 mb-2\">Password</label>\r\n\t\t\t\t\t\t\t");
            Write(
#nullable restore
#line 33 "D:\source\repos\CoreProject\CoreProject.UI\Views\Register\Index.cshtml"
        Html.TextBoxFor(x => x.Password, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n");
            WriteLiteral("\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t<div class=\"form-group col-md-6\">\r\n\t\t\t\t\t\t\t<label for=\"exampleInputPassword1 mb-2\">Resim</label>\r\n\t\t\t\t\t\t\t");
            Write(
#nullable restore
#line 39 "D:\source\repos\CoreProject\CoreProject.UI\Views\Register\Index.cshtml"
        Html.TextBoxFor(x => x.ImageUrl, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n");
            WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
            WriteLiteral("\t\t\t\t\t<button type=\"submit\" class=\"btn btn-primary submit mb-4\">Kayıt Ol</button>\r\n\t\t\t\t\t<p>\r\n\t\t\t\t\t\t<a href=\"#\" id=\"btn1\">By clicking Signup, I agree to your terms</a>\r\n\t\t\t\t\t</p>\r\n");
#nullable restore
#line 50 "D:\source\repos\CoreProject\CoreProject.UI\Views\Register\Index.cshtml"
				}

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreProject.EntityLayer.Concrete.Writer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
