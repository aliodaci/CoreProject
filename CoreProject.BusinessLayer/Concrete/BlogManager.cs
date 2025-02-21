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
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public void Add(Blog entity)
		{
			_blogDal.Add(entity);
		}

		public List<Blog> GetAll()
		{
			return _blogDal.GetAll();
		}

		public List<Blog> GetBlogListWithCategory()
		{
			return _blogDal.GetListByWithCategory();
		}

		public Blog GetById(int id)
		{
			return _blogDal.Get(id);
		}
		public List<Blog> GetBlogById(int id)
		{
			return _blogDal.GetAll(x=>x.Id==id).ToList();
		}

		public void Remove(Blog entity)
		{
			_blogDal.Delete(entity);
		}

		public void Update(Blog entity)
		{
			_blogDal.Update(entity);
		}

		public List<Blog> GetBlogListByWriter(int id)
		{
			return _blogDal.GetAll(x=> x.WriterId==id);
		}

		public List<Blog> GetLast3Blog()
		{
			return _blogDal.GetAll().TakeLast(3).ToList();
		}

		public List<Blog> GetListWithCategoryByWriter(int id)
		{
			return _blogDal.GetListWithCategoryByWriter(id);
		}
	}
}
