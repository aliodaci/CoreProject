using CoreProject.DataAccessLayer.Abstract;
using CoreProject.DataAccessLayer.Concrete.Repositories;
using CoreProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.DataAccessLayer.Concrete.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetListByWithBlog()
        {
            using (var context=new Context())
            {
                return context.Comments.Include(x => x.Blogs).ToList();
            }
        }
    }
}
