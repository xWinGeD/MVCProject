using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Project.Domain.Abstract;

namespace Project.Persistence.Ef
{
     public class Repository<T> : IRepository<T> where T :  Info 
     {
         private EfContext _context;
         private IDbSet<T> entities;
         
         public Repository(EfContext context)
         {
             _context = context;
             entities = _context.Set<T>();
         }

         public T Get(Expression<Func<T, bool>> predicate)
         {
             IQueryable<T> table = entities;
             return table.FirstOrDefault(predicate);
         }

         public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate)
         {
             IQueryable<T> table = entities;
             return table.Where(predicate).ToList();
         }

         public void InserOrUpdate(T entity)
         {
             _context.Entry(entity).State = entity.Id == 0 ? EntityState.Added : EntityState.Modified;
         }

         public void Delete(object id)
         {
             T entity = entities.Find(id);
             entities.Remove(entity);

         }
    }
}

