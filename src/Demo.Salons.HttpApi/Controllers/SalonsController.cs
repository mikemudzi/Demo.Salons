using Demo.Salons.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Demo.Salons.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class SalonsController : AbpController
    {
        protected SalonsController()
        {
            LocalizationResource = typeof(SalonsResource);
        }
    }
}