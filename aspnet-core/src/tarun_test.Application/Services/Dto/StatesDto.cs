using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarun_test.Models;

namespace tarun_test.Services
{
    [AutoMapFrom(typeof(States))]
    public class StatesDto : AuditedEntityDto<Guid>
    {
        public System.String Name { get; set; }
        public System.String Country_name { get; set; }
        public System.String Country_id { get; set; }
    }
}
