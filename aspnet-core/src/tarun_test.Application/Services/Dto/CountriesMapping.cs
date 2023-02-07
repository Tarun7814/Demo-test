using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarun_test.Models;

namespace tarun_test.Services.Dto
{
    public class CountriesMapping : Profile
    {
        public CountriesMapping()
        {
            CreateMap<CountriesDto, Countries>();
        }
    }
}
