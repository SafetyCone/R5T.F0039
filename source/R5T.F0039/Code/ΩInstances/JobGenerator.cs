using System;


namespace R5T.F0039
{
	public class JobGenerator : IJobGenerator
	{
		#region Infrastructure

	    public static IJobGenerator Instance { get; } = new JobGenerator();

	    private JobGenerator()
	    {
        }

	    #endregion
	}
}