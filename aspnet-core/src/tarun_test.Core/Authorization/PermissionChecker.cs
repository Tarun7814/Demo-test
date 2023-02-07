using Abp.Authorization;
using tarun_test.Authorization.Roles;
using tarun_test.Authorization.Users;

namespace tarun_test.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
