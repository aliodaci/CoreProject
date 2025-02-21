using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreProject.UI.Controllers
{
    
    public class MessageController : Controller
    {
        MessageBoxManager messageBoxManager = new MessageBoxManager(new EfMessageBoxDal());
        Context context = new Context();
        public IActionResult Inbox()
        {
            var username = User.Identity.Name;
            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = context.Writers.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();
            var values=messageBoxManager.GetInboxListByWriter(writerId);
            return View(values);
        }

        public IActionResult SendBox()
        {
            var username = User.Identity.Name;
            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var Id = context.Writers.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();
            var values = messageBoxManager.GetSendBoxListByWriter(Id);
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var values = messageBoxManager.GetById(id);
            return View(values);
        }
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMessage(MessageBox message)
        {
            var username = User.Identity.Name;
            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = context.Writers.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();
            message.SenderId = writerId;
            message.ReceiverId = 2;
            message.Status = true;
            message.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            messageBoxManager.Add(message);
            return RedirectToAction("Inbox");
        }
    }
}
