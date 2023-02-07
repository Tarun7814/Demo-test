using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using tarun_test.EntityFrameworkCore;
using tarun_test.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace tarun_test.Web.Tests
{
    [DependsOn(
        typeof(tarun_testWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class tarun_testWebTestModule : AbpModule
    {
        public tarun_testWebTestModule(tarun_testEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(tarun_testWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(tarun_testWebMvcModule).Assembly);
        }
    }
}