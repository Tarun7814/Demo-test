using System.Threading.Tasks;
using Abp.Application.Services;
using tarun_test.Sessions.Dto;

namespace tarun_test.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
