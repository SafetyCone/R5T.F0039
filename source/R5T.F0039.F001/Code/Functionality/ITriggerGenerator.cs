using System;

using Quartz;

using R5T.T0132;


namespace R5T.F0039.F001
{
	[FunctionalityMarker]
	public partial interface ITriggerGenerator : IFunctionalityMarker,
		F0039.ITriggerGenerator
	{
		public ITrigger OncePerDayAtTime(TimeOnly localTime)
		{
			var nextLocalTimeDateTimeOffset = Instances.TimeOnlyOperator.GetNextDateTimeOffset_Local(localTime);

			var trigger = this.OncePerDayAtTimeOfDate(nextLocalTimeDateTimeOffset);
			return trigger;
		}
	}
}