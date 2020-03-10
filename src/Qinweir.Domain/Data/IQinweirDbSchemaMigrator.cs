using System.Threading.Tasks;

namespace Qinweir.Data
{
    public interface IQinweirDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
