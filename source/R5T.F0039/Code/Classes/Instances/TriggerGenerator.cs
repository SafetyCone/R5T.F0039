using System;


namespace R5T.F0039
{
	public class TriggerGenerator : ITriggerGenerator
	{
		#region Infrastructure

	    public static ITriggerGenerator Instance { get; } = new TriggerGenerator();

	    private TriggerGenerator()
	    {
        }

	    #endregion
	}
}