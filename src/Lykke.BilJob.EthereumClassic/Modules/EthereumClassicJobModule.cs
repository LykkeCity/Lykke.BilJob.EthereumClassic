using Autofac;
using JetBrains.Annotations;
using Lykke.BilJob.EthereumClassic.Settings;
using Lykke.Quintessence.Settings;
using Lykke.Quintessence.Utils;

namespace Lykke.BilJob.EthereumClassic.Modules
{
    [UsedImplicitly]
    public class EthereumClassicJobModule : Module
    {
        private readonly AppSettings<EthereumClassicJobSettings> _appSettings;

        public EthereumClassicJobModule(
            AppSettings<EthereumClassicJobSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        protected override void Load(
            ContainerBuilder builder)
        {
            
        }
    }
}