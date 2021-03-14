using Demo.Salons.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Demo.Salons.Permissions
{
    public class SalonsPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(SalonsPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(SalonsPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SalonsResource>(name);
        }
    }
}
