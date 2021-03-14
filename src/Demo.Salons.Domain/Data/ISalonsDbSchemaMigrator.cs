using System.Threading.Tasks;

namespace Demo.Salons.Data
{
    public interface ISalonsDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
