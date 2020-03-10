using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Qinweir.Data
{
    /* This is used if database provider does't define
     * IQinweirDbSchemaMigrator implementation.
     */
    public class NullQinweirDbSchemaMigrator : IQinweirDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}