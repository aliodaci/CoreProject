using Microsoft.AspNetCore.Mvc;

namespace CoreProject.UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
