using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarun_test.Services
{
    public interface IStatesAppService : IAsyncCrudAppService<StatesDto, Guid>
    {
    }
}
