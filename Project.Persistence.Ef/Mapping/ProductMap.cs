using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Models;

namespace Project.Persistence.Ef.Mapping
{
    public class ProductMap<T> : InfoMap<T> where T : Product
    {
        public ProductMap()
        {
            Property(t => t.Name).IsRequired();
            Property(t => t.Description).IsRequired();
            Property(t => t.Price).IsRequired();
            Property(t => t.ImagePath).IsRequired();

            ToTable("Products");

            HasMany(t => t.Orders)
                .WithMany(t => (ICollection<T>) t.Products)
                .Map(t => t.ToTable("Order_Products").MapLeftKey("ProductId").MapRightKey("OrderId"));
        }
    }
}
