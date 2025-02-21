using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.UI.ViewComponents.Category
{
	public class CategoryList:ViewComponent
	{
		CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
		public IViewComponentResult Invoke()
		{
			var values = categoryManager.GetAll();
			return View(values);
		}
	}
}
