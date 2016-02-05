using Quartz;
using Quartz.Spi;
using Microsoft.Practices.Unity;

namespace Spread.Betting.Scheduler
{
    public class JobFactory : IJobFactory
    {
        private readonly IUnityContainer _container;

        public JobFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
        {
            return (IJob)_container.Resolve(bundle.JobDetail.JobType);
        }

        public void ReturnJob(IJob job)
        {
        }
    }
}
