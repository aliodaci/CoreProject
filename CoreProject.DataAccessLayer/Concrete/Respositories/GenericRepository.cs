using CoreProject.DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.DataAccessLayer.Concrete.Respositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        public void Add(T entity)
        {
            using (var context=new Context())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State=EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var context=new Context())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State=EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public T Get(int id)
        {
            using (var context=new Context())
            {
                return context.Set<T>().Find(id);
            }
        }

        public List<T> GetAll()
        {
            using (var context=new Context())
            {
                return context.Set<T>().ToList();
            }
        }

        public void Update(T entity)
        {
            using (var context=new Context())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State=EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
