using System;

using Quartz;

using R5T.T0132;


namespace R5T.F0039
{
	[FunctionalityMarker]
	public partial interface IJobGenerator : IFunctionalityMarker
	{
		public IJobDetail RunExecutable(string executableFilePath)
        {
			var job = JobBuilder.Create<RunExecutableFile>()
				.UsingJobData("ExecutableFilePath", executableFilePath)
				.Build();

			return job;
        }
	}
}