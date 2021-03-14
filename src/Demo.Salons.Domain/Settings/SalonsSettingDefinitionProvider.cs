using Volo.Abp.Settings;

namespace Demo.Salons.Settings
{
    public class SalonsSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(SalonsSettings.MySetting1));
        }
    }
}
