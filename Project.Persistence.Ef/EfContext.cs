using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Abstract;

namespace Project.Persistence.Ef
{
    public class EfContext : DbContext
    {
        public EfContext()
            : base("name=EfContext")
        {
            
        }
        public new DbSet<TEntity> Set<TEntity>() where TEntity : Info
        {
            return base.Set<TEntity>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
