using CoreProject.BusinessLayer.Abstract;
using CoreProject.DataAccessLayer.Abstract;
using CoreProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.BusinessLayer.Concrete
{
	public class WriterManager : IWriterService
	{
		IWriterDal _writerDal;

		public WriterManager(IWriterDal writerDal)
		{
			_writerDal = writerDal;
		}

		public void Add(Writer entity)
		{
			_writerDal.Add(entity);
		}

		public List<Writer> GetAll()
		{
			throw new NotImplementedException();
		}


        public Writer GetById(int id)
		{
			return _writerDal.Get(id);
		}

        public List<Writer> GetFilter(string Email)
        {
            return _writerDal.GetAll(x=> x.Email == Email);
        }

        public List<Writer> GetWriterById(int id)
        {
			return _writerDal.GetAll(x => x.Id == id);
        }

        public void Remove(Writer entity)
		{
			throw new NotImplementedException();
		}

		public void Update(Writer entity)
		{
			_writerDal.Update(entity);
		}
	}
}
