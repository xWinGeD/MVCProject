using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Persistence.Ef
{
     public class Repository<T> : IRepository<T> where T : class
     {
         private EfContext _context;
         private IDbSet<T> entities; 

         public T Get(Expression<Func<T, bool>> predicate)
         {
             throw new NotImplementedException();
         }

         public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate)
         {
             throw new NotImplementedException();
         }

         public void InserOrUpdate(T entity)
         {
             throw new NotImplementedException();
         }

         public void Delete(int id)
         {
             throw new NotImplementedException();
         }
    }
}
