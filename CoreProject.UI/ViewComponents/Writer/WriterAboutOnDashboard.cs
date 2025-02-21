using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.UI.ViewComponents.Writer
{
    public class WriterAboutOnDashboard:ViewComponent
    {
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            ViewBag.v = username;
            var usermail=context.Users.Where(x=>x.UserName==username).Select(y=>y.Email).FirstOrDefault();
            var writerId = context.Writers.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();
            var writerValues = writerManager.GetWriterById(writerId);
            return View(writerValues);
        }
    }
}
