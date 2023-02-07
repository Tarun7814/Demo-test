using System.Threading.Tasks;
using tarun_test.Configuration.Dto;

namespace tarun_test.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
