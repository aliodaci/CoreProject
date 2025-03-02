﻿using CoreProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.DataAccessLayer.Abstract
{
    public interface IMessageBoxDal:IGenericRepository<MessageBox>
    {
        List<MessageBox> GetInboxWithMessageByWriter(int id);
        List<MessageBox> GetSendBoxWithMessageByWriter(int id);

    }
}
