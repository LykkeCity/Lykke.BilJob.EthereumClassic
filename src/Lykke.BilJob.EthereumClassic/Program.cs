using System.Threading.Tasks;
using Lykke.BilJob.EthereumClassic.Settings;
using Lykke.Quintessence;

namespace Lykke.BilJob.EthereumClassic
{
    internal static class Program
    {
        #if DEBUG
        
        private const bool IsDebug = true;
        
        #else

        private const bool IsDebug = false;

        #endif
        
        private static Task Main()
        {
            return JobStarter
                .StartAsync<Startup, EthereumClassicJobSettings>(IsDebug);
        }
    }
}