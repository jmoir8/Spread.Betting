using Quartz;

namespace Spread.Betting.Services.Jobs
{
    [DisallowConcurrentExecution]
    public class GetQuotes : IJob
    {
        public GetQuotes()
        {
        }

        public void Execute(IJobExecutionContext context)
        {
        }
    }
}
