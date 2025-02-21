﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.DataAccessLayer.Abstract
{
    public interface IGenericRepository<T> where T : class,new()
    {
        List<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T Get (int id);
        List<T> GetAll(Expression<Func<T, bool>> filter);
    }
}
