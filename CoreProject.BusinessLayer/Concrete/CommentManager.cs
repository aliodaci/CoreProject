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
	public class CommentManager : ICommentService
	{
		ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

		public void Add(Comment entity)
		{
			_commentDal.Add(entity);
		}

		public List<Comment> GetAll()
		{
			throw new NotImplementedException();
		}

		public Comment GetById(int id)
		{
			throw new NotImplementedException();
		}

        public List<Comment> GetCommentWithBlog()
        {
			return _commentDal.GetListByWithBlog();
        }

        public List<Comment> GetListCommentById(int id)
		{
			return _commentDal.GetAll(x=>x.BlogId == id);
		}

		public void Remove(Comment entity)
		{
			throw new NotImplementedException();
		}

		public void Update(Comment entity)
		{
			throw new NotImplementedException();
		}
	}
}
