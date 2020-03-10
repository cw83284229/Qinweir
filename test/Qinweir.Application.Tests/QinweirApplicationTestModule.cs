using Volo.Abp.Modularity;

namespace Qinweir
{
    [DependsOn(
        typeof(QinweirApplicationModule),
        typeof(QinweirDomainTestModule)
        )]
    public class QinweirApplicationTestModule : AbpModule
    {

    }
}