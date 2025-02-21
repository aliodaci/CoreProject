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
	public class ContactManager : IContactService
	{
		IContactDal _contactDal;

		public ContactManager(IContactDal contactDal)
		{
			_contactDal = contactDal;
		}

		public void Add(Contact entity)
		{
			_contactDal.Add(entity);
		}

		public List<Contact> GetAll()
		{
			throw new NotImplementedException();
		}

		public Contact GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void Remove(Contact entity)
		{
			throw new NotImplementedException();
		}

		public void Update(Contact entity)
		{
			throw new NotImplementedException();
		}
	}
}
