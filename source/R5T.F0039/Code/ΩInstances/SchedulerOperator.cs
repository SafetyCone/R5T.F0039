using System;


namespace R5T.F0039
{
	public class SchedulerOperator : ISchedulerOperator
	{
		#region Infrastructure

	    public static ISchedulerOperator Instance { get; } = new SchedulerOperator();

	    private SchedulerOperator()
	    {
        }

	    #endregion
	}
}