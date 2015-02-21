using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Abstract;

namespace Project.Domain.Models
{
    public class Product : Info
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
