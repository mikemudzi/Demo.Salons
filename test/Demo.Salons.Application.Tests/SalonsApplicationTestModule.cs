using Volo.Abp.Modularity;

namespace Demo.Salons
{
    [DependsOn(
        typeof(SalonsApplicationModule),
        typeof(SalonsDomainTestModule)
        )]
    public class SalonsApplicationTestModule : AbpModule
    {

    }
}