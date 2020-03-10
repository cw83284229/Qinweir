using Qinweir.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Qinweir
{
    [DependsOn(
        typeof(QinweirEntityFrameworkCoreTestModule)
        )]
    public class QinweirDomainTestModule : AbpModule
    {

    }
}