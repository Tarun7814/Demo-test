using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarun_test.Models
{
    public class Countries : AuditedEntity<Guid>
    {
        public System.Int32 CountryId { get; set; }

        public System.String Name { get; set; }
    }
}
