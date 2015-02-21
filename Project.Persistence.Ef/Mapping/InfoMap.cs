using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Abstract;

namespace Project.Persistence.Ef.Mapping
{
    public class InfoMap<T> : BaseMap<T> where T : Info
    {
        public InfoMap()
        {
            Property(t => t.CreatedDate).IsRequired();
            Property(t => t.ModifiedDate).IsOptional();
        }
    }
}
