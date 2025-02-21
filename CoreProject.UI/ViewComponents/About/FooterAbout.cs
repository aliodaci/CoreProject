using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.UI.ViewComponents.About
{
	public class FooterAbout:ViewComponent
	{
		AboutManager aboutManager = new AboutManager(new EfAboutDal());
		public IViewComponentResult Invoke()
		{
			var values=aboutManager.GetById(1);
			return View(values);
		}
	}
}
