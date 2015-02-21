using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Project.Domain.Abstract;

namespace Project.Persistence.Ef.Mapping
{
    public class BaseMap<T> : EntityTypeConfiguration<T> where T : Base
    {
        public BaseMap()
        {
            HasKey(t => t.Id);

            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
