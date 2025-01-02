using CoreProject.DataAccessLayer.Abstract;
using CoreProject.DataAccessLayer.Concrete.Respositories;
using CoreProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.DataAccessLayer.Concrete.EntityFramework
{
    public class EfContactDal:GenericRepository<Contact>,IContactDal
    {
    }
}
