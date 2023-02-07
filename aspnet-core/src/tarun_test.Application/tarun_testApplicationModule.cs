using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using tarun_test.Authorization;

namespace tarun_test
{
    [DependsOn(
        typeof(tarun_testCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class tarun_testApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<tarun_testAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(tarun_testApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
