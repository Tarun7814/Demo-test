using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using tarun_test.Authorization.Roles;
using tarun_test.Authorization.Users;
using tarun_test.MultiTenancy;
using tarun_test.Models;

namespace tarun_test.EntityFrameworkCore
{
    public class tarun_testDbContext : AbpZeroDbContext<Tenant, Role, User, tarun_testDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Countries> countries { get; set; }
        public DbSet<States> states { get; set; }

        public tarun_testDbContext(DbContextOptions<tarun_testDbContext> options)
            : base(options)
        {
        }
    }
}
