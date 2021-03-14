using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Demo.Salons.Data
{
    /* This is used if database provider does't define
     * ISalonsDbSchemaMigrator implementation.
     */
    public class NullSalonsDbSchemaMigrator : ISalonsDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}