using CoreProject.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProject.UI.Areas.Admin.ViewComponents.Statistic
{
    public class StatisticFour:ViewComponent
    {
        Context context=new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.admin = context.Admins.Where(x => x.Id == 1).Select(x => x.Name).FirstOrDefault();
            ViewBag.admintwo=context.Admins.Where(x=>x.Id==1).Select(x=>x.ImageUrl).FirstOrDefault();
            ViewBag.admintree=context.Admins.Where(x=>x.Id==1).Select(x=>x.Description).FirstOrDefault();
            return View();
        }
    }
}
