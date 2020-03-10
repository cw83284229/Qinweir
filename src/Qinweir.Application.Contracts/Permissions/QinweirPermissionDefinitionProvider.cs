using Qinweir.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Qinweir.Permissions
{
    public class QinweirPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(QinweirPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(QinweirPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<QinweirResource>(name);
        }
    }
}
