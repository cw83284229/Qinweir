using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Qinweir.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(QinweirHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class QinweirConsoleApiClientModule : AbpModule
    {
        
    }
}
