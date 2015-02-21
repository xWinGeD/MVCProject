using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using Project.Domain.Abstract;
using Project.Domain.Enum;

namespace Project.Domain.Models
{
    public class User : Info,IUser<int>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName   { get; set; }
        public Role Role { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
