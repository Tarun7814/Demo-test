using System.Threading.Tasks;
using tarun_test.Models.TokenAuth;
using tarun_test.Web.Controllers;
using Shouldly;
using Xunit;

namespace tarun_test.Web.Tests.Controllers
{
    public class HomeController_Tests: tarun_testWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}