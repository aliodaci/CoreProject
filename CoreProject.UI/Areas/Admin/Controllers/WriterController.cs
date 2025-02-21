using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete;
using CoreProject.DataAccessLayer.Concrete.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using CoreProject.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CoreProject.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class WriterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        Context context = new Context();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterList()
        {
            var value = context.Writers.ToList();
            var jsonwriters=JsonConvert.SerializeObject(value);
            return Json(jsonwriters);
        }

        public IActionResult GetWriterById(int writerid)
        {
            var findWriter = context.Writers.Where(x=>x.Id==writerid).FirstOrDefault();
            var jsonWriters=JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriters);
        }

        [HttpPost]
        public IActionResult AddWriter(WriterClass writerClass)
        {
            Writer writer = new Writer();
            if (writerClass.ImageUrl != null)
            {
                var extension = Path.GetExtension(writerClass.ImageUrl.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/writerimagefiles/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                writerClass.ImageUrl.CopyTo(stream);
                writer.ImageUrl = newimagename;
            }
            writer.Name = writerClass.Name;
            writer.Email = writerClass.Email;
            writer.Password = writerClass.Password;
            writer.Status = true;
            writer.About = writerClass.About;
            writerManager.Add(writer);
            var jsonWriters=JsonConvert.SerializeObject(writerClass);
            return Json(jsonWriters);
        }
        public IActionResult DeleteWriter(int id)
        {
            var writer=context.Writers.Where(x=>x.Id==id).FirstOrDefault();
            writerManager.Remove(writer);
            return Json(writer);
        }

        public IActionResult UpdateWriter(WriterClass writerClass)
        {
            var writer=context.Writers.Where(x=>x.Id==writerClass.Id).FirstOrDefault();
            writer.Name = writerClass.Name;
            var jsonwriter=JsonConvert.SerializeObject(writerClass);
            return Json(jsonwriter);

        }

    }


}
