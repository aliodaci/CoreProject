using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace CoreProject.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        public IActionResult Index(int page=1)
        {
            var cm = categoryManager.GetAll().ToPagedList(page,10);
            return View(cm);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Category category)
        {
            category.Status = true;
            categoryManager.Add(category);
            return RedirectToAction("Index", "Category");
        }

        public IActionResult Delete(int id)
        {
            var values=categoryManager.GetById(id);
            categoryManager.Remove(values);
            return RedirectToAction("Index", "Category");
        }
    }
}
