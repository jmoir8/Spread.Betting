using Microsoft.Practices.Unity;
using Quartz;
using Spread.Betting.Services.Interfaces;
using Spread.Betting.Services.Jobs;

namespace Spread.Betting.Services
{
    public class ServiceModule : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<ILogger, Logger>();
            Container.RegisterType<IJob, GetQuotes>();
        }
    }
}
