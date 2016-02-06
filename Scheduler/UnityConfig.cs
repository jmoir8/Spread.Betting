using Microsoft.Practices.Unity;
using Spread.Betting.Data;
using Spread.Betting.Providers;
using Spread.Betting.Services;

namespace Spread.Betting.Scheduler
{
    public static class UnityConfig
    {
        public static UnityContainer Configure()
        {
            var container = new UnityContainer();
            container.AddNewExtension<DataModule>();
            container.AddNewExtension<ProvidersModule>();
            container.AddNewExtension<ServiceModule>();
            container.AddNewExtension<AnalyticsModule>();
            return container;
        }
    }
}
