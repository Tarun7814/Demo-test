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

    [AbpAuthorize(PermissionNames.Pages_States)]
    public class StatesAppService : AsyncCrudAppService<States, StatesDto, Guid>, IStatesAppService
    {
        public StatesAppService(IRepository<States, Guid> repository) : base(repository)
        {

        }
    }
}
