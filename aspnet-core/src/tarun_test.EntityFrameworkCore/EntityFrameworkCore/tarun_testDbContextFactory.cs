using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using tarun_test.Configuration;
using tarun_test.Web;

namespace tarun_test.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class tarun_testDbContextFactory : IDesignTimeDbContextFactory<tarun_testDbContext>
    {
        public tarun_testDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<tarun_testDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            tarun_testDbContextConfigurer.Configure(builder, configuration.GetConnectionString(tarun_testConsts.ConnectionStringName));

            return new tarun_testDbContext(builder.Options);
        }
    }
}
