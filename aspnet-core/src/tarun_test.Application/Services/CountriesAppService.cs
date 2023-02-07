using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarun_test.Authorization;
using tarun_test.Models;

namespace tarun_test.Services
{
    [AbpAuthorize(PermissionNames.Pages_Countries)]
    public class CountriesAppService : AsyncCrudAppService<Countries,CountriesDto, Guid>, ICountriesAppService
    {
        public CountriesAppService(IRepository<Countries, Guid> repository) : base(repository)
        {

        }
    }
}
