using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Qinweir.EntityFrameworkCore
{
    [DependsOn(
        typeof(QinweirEntityFrameworkCoreModule)
        )]
    public class QinweirEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<QinweirMigrationsDbContext>();
        }
    }
}
