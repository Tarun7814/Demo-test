using System.Threading.Tasks;
using Abp.Application.Services;
using tarun_test.Authorization.Accounts.Dto;

namespace tarun_test.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
