using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProject.UI.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        NotificationManager notificationManager = new NotificationManager(new EfNotificationDal());
        public IViewComponentResult Invoke()
        {
            var values = notificationManager.GetAll().Where(x=>x.Status==true).OrderByDescending(x=>x.Id).TakeLast(3).ToList();
            return View(values);
        }
    }
}
