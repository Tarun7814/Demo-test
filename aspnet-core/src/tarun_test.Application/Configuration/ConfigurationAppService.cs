using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using tarun_test.Configuration.Dto;

namespace tarun_test.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : tarun_testAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
