using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.EntityLayer.Concrete
{
    public class Writer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string ImageUrl { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public List<Blog> Blogs { get; set; }

        public virtual ICollection<MessageBox> WriterSender { get; set; }
        public virtual ICollection<MessageBox> WriterReceiver { get; set; }
    }
}
