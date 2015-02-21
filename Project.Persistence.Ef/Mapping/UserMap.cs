using Project.Domain.Models;

namespace Project.Persistence.Ef.Mapping
{
    public class UserMap<T> : InfoMap<T> where T : User
    {
        public UserMap()
        {
            Property(t => t.UserName).HasMaxLength(16).IsRequired();
            Property(t => t.Password).HasMaxLength(16).IsRequired();
            Property(t => t.FirstName).HasMaxLength(10).IsRequired();
            Property(t => t.LastName).HasMaxLength(10).IsRequired();
            Property(t => t.Email).HasMaxLength(16).IsRequired();
            Property(t => t.Role).IsRequired();

            ToTable("Users");
        }
    }
}
