using Demo.Salons.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Demo.Salons
{
    [DependsOn(
        typeof(SalonsEntityFrameworkCoreTestModule)
        )]
    public class SalonsDomainTestModule : AbpModule
    {

    }
}