using Volo.Abp.Bundling;

namespace Demo.Salons.Blazor
{
    public class SalonsBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {
        }

        public void AddStyles(BundleContext context)
        {
            context.Add("main.css", true);
        }
    }
}