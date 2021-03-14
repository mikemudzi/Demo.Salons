using Demo.Salons.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Demo.Salons.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(SalonsEntityFrameworkCoreDbMigrationsModule),
        typeof(SalonsApplicationContractsModule)
        )]
    public class SalonsDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
