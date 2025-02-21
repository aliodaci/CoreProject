using CoreProject.BusinessLayer.Concrete;
using CoreProject.BusinessLayer.ValidationRules;
using CoreProject.DataAccessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using CoreProject.UI.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.UI.Controllers
{
    [Authorize]
    public class WriterController : Controller
	{
		WriterManager writerManager = new WriterManager(new EfWriterDal());
        UserManager userManager = new UserManager(new EfUserDal());
        private readonly UserManager<AppUser> _userManager;

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        Context context = new Context();
		public IActionResult Index()
		{
			var userMail=User.Identity.Name;
			ViewBag.v=userMail;
            var writerName = context.Writers.Where(x => x.Email == userMail).Select(y => y.Name).FirstOrDefault();
			ViewBag.wn = writerName;
			return View();
		}

		public IActionResult Profile()
		{
			return View();
		}

		public IActionResult Mail()
		{
			return View();
		}

		public IActionResult Test()
		{
			return View();
		}

		public PartialViewResult WriterNavbarPartial()
		{
			return PartialView();
		}

		public PartialViewResult WriterFooterPartial()
		{
			return PartialView();
		}

		[HttpGet]
		public async Task<IActionResult> EditProfile()
		{
			// var username = User.Identity.Name;
			// var userMail=context.Users.Where(x=>x.UserName==username).Select(y=>y.Email).FirstOrDefault();
			//var Id = context.Users.Where(x => x.Email == userMail).Select(y=>y.Id).FirstOrDefault();
			//var values=userManager.GetById(Id);
			var values=await _userManager.FindByNameAsync(User.Identity.Name);
			UserUpdateViewModel model = new UserUpdateViewModel();
            model.mail = values.Email;
            model.namesurname = values.NameSurname;
            model.imageurl = values.ImageUrl;
            model.username = values.UserName;
            return View(model);
		}
		[HttpPost]
		public async Task<IActionResult> EditProfile(UserUpdateViewModel model)
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			values.NameSurname=model.namesurname;
			values.ImageUrl=model.imageurl;
			values.Email=model.mail;
			values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, model.password);
			var result=await _userManager.UpdateAsync(values);
			return RedirectToAction("Index", "Dashboard");

		}

		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Add(AddProfileImage file)
		{
			Writer writer=new Writer();
			if(file.ImageUrl!=null)
			{
				var extension=Path.GetExtension(file.ImageUrl.FileName);
				var newimagename = Guid.NewGuid() + extension;
				var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/writerimagefiles/", newimagename);
				var stream=new FileStream(location, FileMode.Create);
				file.ImageUrl.CopyTo(stream);
				writer.ImageUrl=newimagename;
			}
			writer.Name = file.Name;
			writer.Email = file.Email;
			writer.Password = file.Password;
			writer.Status = true;
			writer.About = file.About;
			writerManager.Add(writer);
			return RedirectToAction("Index", "Dashboard");
		}
	}
}
