using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProject.UI.ViewComponents.Blog
{
	public class WriterLastBlog:ViewComponent
	{
		BlogManager blogManager = new BlogManager(new EfBlogDal());

		public IViewComponentResult Invoke(int id)
		{
			var values = blogManager.GetBlogListByWriter(1);
			return View(values);
		}
	}
}
