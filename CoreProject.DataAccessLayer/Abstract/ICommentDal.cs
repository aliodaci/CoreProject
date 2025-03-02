﻿using CoreProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.DataAccessLayer.Abstract
{
    public interface ICommentDal:IGenericRepository<Comment>
    {
        List<Comment> GetListByWithBlog();
    }
}
