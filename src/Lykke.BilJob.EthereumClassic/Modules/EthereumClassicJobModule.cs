using Autofac;
using JetBrains.Annotations;
using Lykke.BilJob.EthereumClassic.Settings;
using Lykke.Quintessence.Core.DependencyInjection;
using Lykke.Quintessence.Core.Telemetry.DependencyInjection;
using Lykke.Quintessence.Settings;
using Lykke.SettingsReader;

namespace Lykke.BilJob.EthereumClassic.Modules
{
    [UsedImplicitly]
    public class EthereumClassicJobModule : Module
    {
        private readonly IReloadingManager<AppSettings<EthereumClassicJobSettings>> _appSettings;

        public EthereumClassicJobModule(
            IReloadingManager<AppSettings<EthereumClassicJobSettings>> appSettings)
        {
            _appSettings = appSettings;
        }

        protected override void Load(
            ContainerBuilder builder)
        {
            var chainId = _appSettings.CurrentValue.Job.IsMainNet ? 61 : 62;

            builder
                .UseAITelemetryConsumer()
                .UseChainId(chainId);
        }
    }
}