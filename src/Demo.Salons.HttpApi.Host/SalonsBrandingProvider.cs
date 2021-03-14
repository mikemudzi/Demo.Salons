using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Demo.Salons
{
    [Dependency(ReplaceServices = true)]
    public class SalonsBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Salons";
    }
}
