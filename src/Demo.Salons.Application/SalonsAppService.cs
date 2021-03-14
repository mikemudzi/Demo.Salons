using System;
using System.Collections.Generic;
using System.Text;
using Demo.Salons.Localization;
using Volo.Abp.Application.Services;

namespace Demo.Salons
{
    /* Inherit your application services from this class.
     */
    public abstract class SalonsAppService : ApplicationService
    {
        protected SalonsAppService()
        {
            LocalizationResource = typeof(SalonsResource);
        }
    }
}
