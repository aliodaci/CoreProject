using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace CoreProject.UI.Areas.Admin.ViewComponents.Statistic
{
    public class StatisticOne:ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogDal());
        Context context=new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.blog=blogManager.GetAll().Count;
            ViewBag.message = context.Contacts.Count();
            ViewBag.comment=context.Comments.Count();

            string api = "6a951efcb89809a1eb97e8d43f5fd4c3";
            string connectionapi = "https://api.openweathermap.org/data/2.5/weather?q=mersin&mode=xml&appid=" + api;
            XDocument xDocument=XDocument.Load(connectionapi);
            ViewBag.wone=xDocument.Descendants("coord").ElementAt(0).Attribute("lon").Value;
            ViewBag.cityname = xDocument.Descendants("city").ElementAt(0).Attribute("name").Value;
            return View();
        }
    }
}
