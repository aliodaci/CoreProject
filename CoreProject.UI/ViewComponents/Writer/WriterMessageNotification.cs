using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProject.UI.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        MessageBoxManager messageBoxManager = new MessageBoxManager(new EfMessageBoxDal());
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var Id = context.Writers.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();
            var values = messageBoxManager.GetInboxListByWriter(Id);
            return View(values);
        }
    }
}
