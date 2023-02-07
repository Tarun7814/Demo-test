using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using tarun_test.Configuration;

namespace tarun_test.Web.Host.Startup
{
    [DependsOn(
       typeof(tarun_testWebCoreModule))]
    public class tarun_testWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public tarun_testWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(tarun_testWebHostModule).GetAssembly());
        }
    }
}
