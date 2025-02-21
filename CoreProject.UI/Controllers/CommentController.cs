using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreProject.UI.Controllers
{
	[AllowAnonymous]
	public class CommentController : Controller
	{
		CommentManager commentManager = new CommentManager(new EfCommentDal());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult PartialAddComment(Comment comment)
		{
			comment.CommentDate=DateTime.Parse(DateTime.Now.ToShortDateString());
			comment.Status = true;
			comment.BlogId = 2;
			commentManager.Add(comment);
			Response.Redirect("/Blog/Index");
			return PartialView();
		}
		public PartialViewResult CommentListByBlog(int id)
		{
			var values = commentManager.GetListCommentById(id);
			return PartialView(values);
		}
	}
}
