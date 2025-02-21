using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.UI.ViewComponents.Blog
{
	public class BlogLast3Post:ViewComponent
	{
		BlogManager blogManager = new BlogManager(new EfBlogDal());
		public IViewComponentResult Invoke()
		{
			var values = blogManager.GetLast3Blog();
			return View(values);
		}
	}
}
