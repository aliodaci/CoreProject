﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.EntityLayer.Concrete
{
    public class Comment
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CommentDate { get; set; }
        public int BlogScore { get; set; }
        public bool Status { get; set; }
        public int BlogId { get; set; }
        public Blog Blogs { get; set; }
    }
}
