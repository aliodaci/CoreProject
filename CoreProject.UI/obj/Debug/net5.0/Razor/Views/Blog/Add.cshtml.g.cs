#pragma checksum "D:\source\repos\CoreProject\CoreProject.UI\Views\Blog\Add.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "02168979d723db6bf112ce39ca24929420161ea78a4eb24f99a63ebbadf77fd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Blog_Add), @"mvc.1.0.view", @"/Views/Blog/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"02168979d723db6bf112ce39ca24929420161ea78a4eb24f99a63ebbadf77fd1", @"/Views/Blog/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e1d697866003d689d1d07aae15d21a18933dedeab4fb9c8d81fcd9115712be6c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Blog_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "D:\source\repos\CoreProject\CoreProject.UI\Views\Blog\Add.cshtml"
       CoreProject.EntityLayer.Concrete.Blog

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
#line 2 "D:\source\repos\CoreProject\CoreProject.UI\Views\Blog\Add.cshtml"
  
    ViewData["Title"] = "Add";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "D:\source\repos\CoreProject\CoreProject.UI\Views\Blog\Add.cshtml"
 using(Html.BeginForm("Add","Blog",FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 10 "D:\source\repos\CoreProject\CoreProject.UI\Views\Blog\Add.cshtml"
     Html.Label("Blog Başlığı")

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 11 "D:\source\repos\CoreProject\CoreProject.UI\Views\Blog\Add.cshtml"
     Html.TextBoxFor(x=>x.Title, new{@class="form-control"})

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 13 "D:\source\repos\CoreProject\CoreProject.UI\Views\Blog\Add.cshtml"
     Html.Label("Blog Görsel")

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 14 "D:\source\repos\CoreProject\CoreProject.UI\Views\Blog\Add.cshtml"
     Html.TextBoxFor(x => x.Image, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 16 "D:\source\repos\CoreProject\CoreProject.UI\Views\Blog\Add.cshtml"
     Html.Label("Blog küçük resim")

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 17 "D:\source\repos\CoreProject\CoreProject.UI\Views\Blog\Add.cshtml"
     Html.TextBoxFor(x => x.ThumbnailImage, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 19 "D:\source\repos\CoreProject\CoreProject.UI\Views\Blog\Add.cshtml"
     Html.Label("Kategori")

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 20 "D:\source\repos\CoreProject\CoreProject.UI\Views\Blog\Add.cshtml"
     Html.DropDownListFor(x => x.CategoryId,(List<SelectListItem>)ViewBag.cv, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 22 "D:\source\repos\CoreProject\CoreProject.UI\Views\Blog\Add.cshtml"
     Html.Label("Blog İçeriği")

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 23 "D:\source\repos\CoreProject\CoreProject.UI\Views\Blog\Add.cshtml"
     Html.TextAreaFor(x => x.Content,10,3, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("    <button class=\"btn btn-primary mt-2\">Kaydet</button>\r\n");
#nullable restore
#line 26 "D:\source\repos\CoreProject\CoreProject.UI\Views\Blog\Add.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreProject.EntityLayer.Concrete.Blog> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
