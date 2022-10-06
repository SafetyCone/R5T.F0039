using System;

using Quartz;

using R5T.T0132;


namespace R5T.F0039
{
	[FunctionalityMarker]
	public partial interface ITriggerGenerator : IFunctionalityMarker
	{
		public ITrigger OncePerDayAtTimeOfDate(DateTimeOffset startTime)
		{
			var trigger = TriggerBuilder.Create()
				.StartAt(startTime)
				.WithCalendarIntervalSchedule(calendarIntervalScheduleBuilder => calendarIntervalScheduleBuilder.WithIntervalInDays(1))
				.Build();

			return trigger;
		}

		public ITrigger OncePerDayAtTimeOfDate_Local(DateTime localStartTime)
        {
			var utcTime = Instances.DateTimeOperator.ToUtc(localStartTime);

			var trigger = this.OncePerDayAtTimeOfDate_Utc(utcTime);
			return trigger;
        }

		public ITrigger OncePerDayAtTimeOfDate_Utc(DateTime utcStartTime)
		{
			var utcStartTimeDateTimeOffset = F0000.DateTimeOffsetOperator.Instance.FromDateTime_Utc(utcStartTime);

			var trigger = this.OncePerDayAtTimeOfDate(utcStartTimeDateTimeOffset);
			return trigger;
		}
	}
}