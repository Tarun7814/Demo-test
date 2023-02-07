using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using tarun_test.Models;

namespace tarun_test.Services
{
    [AutoMapFrom(typeof(Countries))]
    public class CountriesDto :AuditedEntityDto<Guid>
    {
        public System.Int32 CountryId { get; set; }

        public System.String Name { get; set; }
    }
}