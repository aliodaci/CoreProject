using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CoreProject.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminMessageController : Controller
    {
        MessageBoxManager messageBoxManager = new MessageBoxManager(new EfMessageBoxDal());
        Context context = new Context();
        public IActionResult Inbox()
        {
            var username = User.Identity.Name;
            var useremail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var Id = context.Writers.Where(x => x.Email == useremail).Select(y => y.Id).FirstOrDefault();
            var values = messageBoxManager.GetInboxListByWriter(Id);
            return View(values);
        }

        public IActionResult SendBox()
        {
            var username = User.Identity.Name;
            var useremail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var Id = context.Writers.Where(x => x.Email == useremail).Select(y => y.Id).FirstOrDefault();
            var values = messageBoxManager.GetSendBoxListByWriter(Id);
            return View(values);
        }

        [HttpGet]
        public IActionResult ComposeMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ComposeMessage(MessageBox messageBox)
        {
            var username = User.Identity.Name;
            var useremail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var Id = context.Writers.Where(x => x.Email == useremail).Select(y => y.Id).FirstOrDefault();
            messageBox.SenderId = Id;
            messageBox.ReceiverId = 2;
            messageBox.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            messageBox.Status = true;
            messageBoxManager.Add(messageBox);
            return RedirectToAction("SendBox");
        }
        public PartialViewResult MailMenuPartial()
        {
            return PartialView();
        }
    }
}
