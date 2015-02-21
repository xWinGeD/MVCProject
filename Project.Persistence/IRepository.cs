using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Project.Persistence
{
    public interface IRepository<T> where T : class
    {
        T Get(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetAll(Expression<Func<T,bool>> predicate);
        void InserOrUpdate(T entity);
        void Delete(int id);

    }
}
