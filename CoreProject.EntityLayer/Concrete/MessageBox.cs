﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.EntityLayer.Concrete
{
    public class MessageBox
    {
        [Key]
        public int Id { get; set; }
        public int? SenderId { get; set; }
        public int? ReceiverId { get; set; }
        public string Subject { get; set; }
        public string Details { get; set; }
        public DateTime MessageDate { get; set; }
        public bool Status { get; set; }

        public Writer SenderUser { get; set; }
        public Writer ReceiverUser { get; set; }
    }
}
