using Demo.Salons.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Demo.Salons.Blazor
{
    public abstract class SalonsComponentBase : AbpComponentBase
    {
        protected SalonsComponentBase()
        {
            LocalizationResource = typeof(SalonsResource);
        }
    }
}
