﻿using Topshelf;
using Quartz;
using Topshelf.Quartz;
using Microsoft.Practices.Unity;
using Spread.Betting.Services;
using System.Configuration;
using Spread.Betting.Services.Jobs;

namespace Spread.Betting.Scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.AddNewExtension<ServiceModule>();

            var pickupInterval = int.Parse(ConfigurationManager.AppSettings["PickupInterval"] ?? "5");

            HostFactory.Run(
                x =>
                {
                    x.UsingQuartzJobFactory(() => new JobFactory(container));
                    x.ScheduleQuartzJobAsService(
                        q =>
                        q.WithJob(() => JobBuilder.Create<GetQuotes>()
                                                  .WithIdentity("GetQuotesProcessor")
                                                  .Build())
                         .AddTrigger(() => TriggerBuilder.Create()
                                                         .WithIdentity("GetQuotesProcessor")
                                                         .WithSimpleSchedule(builder => builder.WithIntervalInSeconds(pickupInterval)
                                                                                               .RepeatForever())
                                                         .Build()));
                    x.ScheduleQuartzJobAsService(
                         q =>
                         q.WithJob(() => JobBuilder.Create<GetAnalysis>()
                                                   .WithIdentity("GetAnalysisProcessor")
                                                   .Build())
                          .AddTrigger(() => TriggerBuilder.Create()
                                                          .WithIdentity("GetAnalysisProcessor")
                                                          .WithSimpleSchedule(builder => builder.WithIntervalInSeconds(pickupInterval)
                                                                                                .RepeatForever())
                                                          .Build()));

                    x.RunAsLocalSystem()
                        .DependsOnEventLog()
                        .StartAutomatically()
                        .EnableServiceRecovery(rc => rc.RestartService(1));

                    x.SetDescription("Create spread betting analysis for for ex");
                    x.SetDisplayName("Spread Betting Agent");
                    x.SetServiceName("SpreadBettingAgent");
                });
        }
    }
}
