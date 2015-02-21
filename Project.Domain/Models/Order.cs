using System.Collections.Generic;
using Project.Domain.Abstract;

namespace Project.Domain.Models
{
    public class Order : Info
    {
        public decimal OrderAmount { get; set; }
        public bool Status { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
