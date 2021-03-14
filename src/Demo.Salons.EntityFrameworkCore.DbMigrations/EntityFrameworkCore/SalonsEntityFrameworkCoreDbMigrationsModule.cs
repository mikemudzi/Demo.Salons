using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Demo.Salons.EntityFrameworkCore
{
    [DependsOn(
        typeof(SalonsEntityFrameworkCoreModule)
        )]
    public class SalonsEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<SalonsMigrationsDbContext>();
        }
    }
}
