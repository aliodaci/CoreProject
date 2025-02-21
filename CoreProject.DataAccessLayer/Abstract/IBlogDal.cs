using CoreProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.DataAccessLayer.Abstract
{
    public interface IBlogDal:IGenericRepository<Blog>
    {
        List<Blog> GetListByWithCategory();
        List<Blog> GetListWithCategoryByWriter(int id);
    }
}
