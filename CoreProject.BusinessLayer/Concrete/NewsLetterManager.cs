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
	public class NewsLetterManager : INewsLetterService
	{
		INewsLetterDal _newsLetterDal;

		public NewsLetterManager(INewsLetterDal newsLetterDal)
		{
			_newsLetterDal = newsLetterDal;
		}

		public void Add(NewsLetter entity)
		{
			_newsLetterDal.Add(entity);
		}

		public List<NewsLetter> GetAll()
		{
			throw new NotImplementedException();
		}

		public NewsLetter GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void Remove(NewsLetter entity)
		{
			throw new NotImplementedException();
		}

		public void Update(NewsLetter entity)
		{
			throw new NotImplementedException();
		}
	}
}
