using JetBrains.Annotations;
using Lykke.Quintessence.Settings;

namespace Lykke.BilJob.EthereumClassic.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class EthereumClassicJobSettings : JobSettings
    {
        public bool IsMainNet { get; set; }
    }
}