using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace tarun_test.Controllers
{
    public abstract class tarun_testControllerBase: AbpController
    {
        protected tarun_testControllerBase()
        {
            LocalizationSourceName = tarun_testConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
