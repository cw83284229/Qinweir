using Qinweir.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Qinweir.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(QinweirEntityFrameworkCoreDbMigrationsModule),
        typeof(QinweirApplicationContractsModule)
        )]
    public class QinweirDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
