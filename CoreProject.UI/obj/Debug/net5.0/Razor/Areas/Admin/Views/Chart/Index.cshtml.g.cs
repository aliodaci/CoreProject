#pragma checksum "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\Chart\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1b872bc0163fe7542a8992e7b38fab672fbaa97f59deddafaf25dcf6ab70b0c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Areas_Admin_Views_Chart_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Chart/Index.cshtml")]
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
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1b872bc0163fe7542a8992e7b38fab672fbaa97f59deddafaf25dcf6ab70b0c5", @"/Areas/Admin/Views/Chart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"eba340c0d91299a7d875c6f6663fe4fdc1fce1e9e7ef54e8c0cd3af91c510eb0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Areas_Admin_Views_Chart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\source\repos\CoreProject\CoreProject.UI\Areas\Admin\Views\Chart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <div id=""chartdiv"" style=""width:800px;height:600px"">

        </div>
    </div>
</div>

<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
<script type=""text/javascript"">
    google.charts.load('current', { 'packages': ['corechart'] });
    google.charts.setOnLoadCallback(DrawonLoad);

    function DrawonLoad() {
        $(function () {
            $.ajax({
                type: 'GET',
                url: '/Admin/Chart/CategoryChart/',
                success: function (chartsdata) {
                    var Data = chartsdata.jsonlist;
                    var data = new google.visualization.DataTable();

                    data.addColumn('string', 'name');
                    data.addColumn('number', 'count');

                    for (var i = 0; i < Data.length; i++) {
                        data.addRow([Data[i].name, Data[i].count]);
                    }

                    var chart");
            WriteLiteral(@" = new google.visualization.PieChart(document.getElementById('chartdiv'));

                    chart.draw(data,
                        {
                            title: ""Google Chart BloggEdu Projesi"",
                            position: ""top"",
                            fontsize: ""16px""

                        });
                }
            });
        })
    }
</script>
    

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
