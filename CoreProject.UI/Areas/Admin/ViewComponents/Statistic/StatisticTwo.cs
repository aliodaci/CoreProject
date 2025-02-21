using CoreProject.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProject.UI.Areas.Admin.ViewComponents.Statistic
{
    public class StatisticTwo:ViewComponent
    {
        Context context=new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.bloglast = context.Blogs.OrderByDescending(x => x.Id).Select(x => x.Title).Take(1).FirstOrDefault();
            return View();
        }
    }
}
