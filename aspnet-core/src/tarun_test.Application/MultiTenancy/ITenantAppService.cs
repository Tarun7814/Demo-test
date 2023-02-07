using Abp.Application.Services;
using tarun_test.MultiTenancy.Dto;

namespace tarun_test.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

