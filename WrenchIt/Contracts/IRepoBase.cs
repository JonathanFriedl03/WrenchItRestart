﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WrenchIt.Data.RepositoryBase.IRepository
{
    public interface IRepoBase<T> where T : class
    {
        T Get(int id);
        
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
            );
        T GetFirstOrDefault(
             Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );
        void Add(T entity);
        void Remove(T entity);
        void Remove(int id);
    }
}
