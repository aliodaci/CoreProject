using CoreProject.BusinessLayer.Concrete;
using CoreProject.BusinessLayer.ValidationRules;
using CoreProject.DataAccessLayer.Concrete.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;
using System.Collections.Generic;
using CoreProject.DataAccessLayer.Concrete;

namespace CoreProject.UI.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        Context context = new Context();
        public IActionResult Index()
        {
            var values = blogManager.GetBlogListWithCategory();
            return View(values);
        }
        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            ViewBag.i = id;
            var values = blogManager.GetBlogById(id);
            return View(values);
        }

        public IActionResult BlogListWriter()
        {
            var username = User.Identity.Name;
            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = context.Writers.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();
            var values = blogManager.GetListWithCategoryByWriter(writerId);
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            
            List<SelectListItem> categoryValues = (from x in categoryManager.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text=x.CategoryName,
                                                       Value=x.Id.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            return View();
        }

        [HttpPost]
        public IActionResult Add(Blog entity)
        {
            var username = User.Identity.Name;
            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = context.Writers.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();

            var blogValidator = new BlogValidator();
            ValidationResult result = blogValidator.Validate(entity);
            if (result.IsValid)
            {
                entity.Status = true;
                entity.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                entity.WriterId = writerId;
                blogManager.Add(entity);
                return RedirectToAction("BlogListWriter", "Blog");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var blogValue=blogManager.GetById(id);
            blogManager.Remove(blogValue);
            return RedirectToAction("BlogListWriter");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var blogValue= blogManager.GetById(id);
            List<SelectListItem> categoryValues = (from x in categoryManager.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.Id.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            return View(blogValue);
        }
        [HttpPost]
        public IActionResult Edit(Blog entity)
        {
            var username = User.Identity.Name;
            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = context.Writers.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();
            entity.Id = writerId;
            entity.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            entity.Status =true;
            blogManager.Update(entity);
            return RedirectToAction("BlogListWriter");
        }
    }
}
