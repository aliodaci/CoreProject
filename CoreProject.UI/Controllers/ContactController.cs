using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;

namespace CoreProject.UI.Controllers
{
	[AllowAnonymous]
	public class ContactController : Controller
	{
		ContactManager contactManager = new ContactManager(new EfContactDal());

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Contact contact)
		{
			contact.ContactDate=DateTime.Parse(DateTime.Now.ToShortDateString());
			contact.Status = true;
			contactManager.Add(contact);
			return RedirectToAction("Index","Contact");
			
		}

		public PartialViewResult ContactDetails()
		{
			return PartialView();
		}
	}
}
