using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace tarun_test.EntityFrameworkCore
{
    public static class tarun_testDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<tarun_testDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<tarun_testDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
