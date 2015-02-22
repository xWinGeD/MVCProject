using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Abstract;

namespace Project.Persistence.Ef
{
    public class UnitOfWork : IUnitOfWork
    {
        private EfContext context;
        private Dictionary<string, object> repositories; 
        public UnitOfWork()
        {
            context =  new EfContext();
        }
        public IRepository<T> Repository<T>() where T : Info
        {
            if (repositories == null)
            {
                repositories = new Dictionary<string, object>();
            }

            var type = typeof(T).Name;

            if (!repositories.ContainsKey(type))
            {
                var repositoryType = typeof(Repository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), context);
                repositories.Add(type, repositoryInstance);
            }
            return (Repository<T>)repositories[type];
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
