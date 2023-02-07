using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarun_test.Models
{
    public class States : AuditedEntity<Guid>
    {
        public System.String Name { get; set; }
        public System.String Country_name { get; set; }
        public System.String Country_id { get; set; }

    }
}
