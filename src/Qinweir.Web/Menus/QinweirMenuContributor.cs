using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Qinweir.Localization;
using Qinweir.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Qinweir.Web.Menus
{
    public class QinweirMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<QinweirResource>>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem("Qinweir.Home", l["Menu:Home"], "/"));
            //添加菜单地方
            context.Menu.AddItem(new ApplicationMenuItem("Qinweir", l["Menu:Qinweir"])
             .AddItem(new ApplicationMenuItem(" Qinweir.OrderMaterials", l["Menu:OrderMaterials"], url: "/OrderMaterials"))
             .AddItem(new ApplicationMenuItem("Qinweir.MaterialName",l["Menu:MaterialName"],url:"/MaterialName"))
           );

        }
    }
}
