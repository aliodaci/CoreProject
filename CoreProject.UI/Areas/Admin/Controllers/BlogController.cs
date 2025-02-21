using ClosedXML.Excel;
using CoreProject.DataAccessLayer.Concrete;
using CoreProject.UI.Areas.Admin.Models;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CoreProject.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class BlogController : Controller
    {
        public IActionResult ExportStaticBlogList()
        {
            using (var workbook=new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog listesi");
                worksheet.Cell(1,1).Value= "Id";
                worksheet.Cell(1, 2).Value = "Blog Adı";

                int blogRowCount = 2;
                foreach (var item in GetBlogList())
                {
                    worksheet.Cell(blogRowCount,1).Value = item.Id;
                    worksheet.Cell(blogRowCount,2).Value = item.BlogName;
                    blogRowCount++;
                }

                using (var stream=new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content=stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "calisma1.xlsx");
                }
            }
        }

        public List<BlogModel> GetBlogList()
        {
            List<BlogModel> bm = new List<BlogModel>()
            {
                new BlogModel() {Id=1,BlogName="C# Proglamaya Girişi" },
                new BlogModel(){Id=2,BlogName="Tesle Fimasının Araçları"},
                new BlogModel(){Id=3,BlogName="2020 Olimpiyatları" }

            };
            return bm;
        }

        public IActionResult BlogListExcel()
        {
            return View();
        }


        public IActionResult ExportDynamicBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog listesi");
                worksheet.Cell(1, 1).Value = "Id";
                worksheet.Cell(1, 2).Value = "Blog Adı";

                int blogRowCount = 2;
                foreach (var item in BlogTitleList())
                {
                    worksheet.Cell(blogRowCount, 1).Value = item.Id;
                    worksheet.Cell(blogRowCount, 2).Value = item.BlogName;
                    blogRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "calisma1.xlsx");
                }
            }
        }
        public List<BlogModel> BlogTitleList()
        {
            List<BlogModel> bm=new List<BlogModel>();
            using (var context=new Context())
            {
                bm=context.Blogs.Select(x=>new BlogModel { Id=x.Id, BlogName=x.Title}).ToList();
            }
            return bm;
        }

        public IActionResult BlogTitleExcelList()
        {
            return View();
        }
    }
}
