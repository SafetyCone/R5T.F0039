using System;
using System.Threading.Tasks;

using Quartz;
using Quartz.Impl;

using R5T.T0132;


namespace R5T.F0039
{
	[FunctionalityMarker]
	public partial interface ISchedulerOperator : IFunctionalityMarker
	{
		public async Task<IScheduler> StartScheduler(Func<IScheduler, Task> configureSchedulerAction)
        {
			// Grab the Scheduler instance from the Factory
			StdSchedulerFactory factory = new StdSchedulerFactory();

			IScheduler scheduler = await factory.GetScheduler();

			await configureSchedulerAction(scheduler);

			await scheduler.Start();

			return scheduler;
		}
	}
}