using System;
using System.Collections.Generic;
using System.Data.Entity;
using Project.Domain.Abstract;
using Project.Domain.Models;
using Project.Persistence.Ef.Mapping;

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
            modelBuilder.Configurations.Add(new UserMap<User>());
            modelBuilder.Configurations.Add(new OrderMap<Order>());
            modelBuilder.Configurations.Add(new ProductMap<Product>());
            base.OnModelCreating(modelBuilder);
        }
    }
}
