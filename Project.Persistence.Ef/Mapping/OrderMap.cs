using System.Collections.Generic;
using Project.Domain.Models;

namespace Project.Persistence.Ef.Mapping
{
    public class OrderMap<T> : InfoMap<T> where T : Order
    {
        public OrderMap()
        {
            Property(t => t.OrderAmount).IsRequired();
            Property(t => t.Status).IsRequired();
            Property(t => t.UserId).IsRequired();

            ToTable("Orders");

            HasRequired(t => t.User).WithMany(t => (ICollection<T>) t.Orders).HasForeignKey(t => t.UserId);
        }
    }
}
