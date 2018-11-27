using JetBrains.Annotations;
using Lykke.BilJob.EthereumClassic.Modules;
using Lykke.BilJob.EthereumClassic.Settings;
using Lykke.Quintessence;
using Lykke.Sdk;

namespace Lykke.BilJob.EthereumClassic
{
    [UsedImplicitly]
    public class Startup : JobStartupBase<EthereumClassicJobSettings>
    {
        protected override string IntegrationName
            => "EthereumClassic";

        protected override void RegisterAdditionalModules(
            IModuleRegistration modules)
        {
            modules.RegisterModule<EthereumClassicJobModule>();
            
            base.RegisterAdditionalModules(modules);
        }
    }
}