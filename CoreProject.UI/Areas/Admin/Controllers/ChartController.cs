using CoreProject.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreProject.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list=new List<CategoryClass>();
            list.Add(new CategoryClass
            {
                name = "Teknoloji",
                count = 10
                
            });
            list.Add(new CategoryClass
            {
                name = "Spor",
                count = 12
                
            });
            list.Add(new CategoryClass
            {
                name = "Yazılım",
                count = 8

            });
            list.Add(new CategoryClass
            {
                name = "Sinema",
                count = 11

            });

            return Json(new { jsonlist = list });
        }
    }

}
