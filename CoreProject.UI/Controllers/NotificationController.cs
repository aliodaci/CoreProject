using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.UI.Controllers
{
    [AllowAnonymous]
    public class NotificationController : Controller
    {
        NotificationManager notificationManager = new NotificationManager(new EfNotificationDal());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllNotification()
        {
            var notificationValues = notificationManager.GetAll();
            return View(notificationValues);
        }
    }
}
