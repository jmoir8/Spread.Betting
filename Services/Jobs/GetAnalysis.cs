using Quartz;

namespace Spread.Betting.Services.Jobs
{
    [DisallowConcurrentExecution]
    public class GetAnalysis : IJob
    {
        public GetAnalysis()
        {
        }

        public void Execute(IJobExecutionContext context)
        {
        }
    }
}
