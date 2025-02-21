using CoreProject.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProject.UI.Controllers
{
    public class DashboardController : Controller
    {
        Context context=new Context();

        public IActionResult Index()
        {
            var username = User.Identity.Name;
            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId=context.Writers.Where(x=>x.Email==usermail).Select(y=>y.Id).FirstOrDefault();
            ViewBag.v1 = context.Blogs.Count().ToString();
            ViewBag.v2 = context.Blogs.Where(x => x.WriterId == writerId).Count();
            ViewBag.v3=context.Categories.Count().ToString();
            return View();
        }
    }
}
