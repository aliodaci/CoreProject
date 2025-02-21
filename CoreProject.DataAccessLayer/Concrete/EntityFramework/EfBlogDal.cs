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
	public class EfBlogDal : GenericRepository<Blog>, IBlogDal
	{

        public List<Blog> GetListByWithCategory()
		{
			using (var context=new Context())
			{
				return context.Blogs.Include(x=> x.Category).ToList();
			}
		}

        public List<Blog> GetListWithCategoryByWriter(int id)
        {
			using (var context=new Context())
			{
				return context.Blogs.Include(x => x.Category).Where(x => x.WriterId == id).ToList();
			}
        }
    }
}
