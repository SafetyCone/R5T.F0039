using System;
using System.Extensions;
using Quartz;

using R5T.T0132;


namespace R5T.F0039
{
	[FunctionalityMarker]
	public partial interface IJobGenerator : IFunctionalityMarker
	{
		public IJobDetail RunExecutable(
			string executableFilePath,
			string description = default)
        {
			var job = JobBuilder.Create<RunExecutableFile>()
				.UsingJobData(
					JobDataKeys.Instance.ExecutableFilePath,
					executableFilePath)
				.ModifyIf(
					description != default,
					x => x.WithDescription(description))
				.Build();

			return job;
        }

        public IJobDetail RunDotnetExecutableAssembly(
            string executableAssemblyFilePath,
            string description = default)
        {
            var job = JobBuilder.Create<RunDotnetExecutableAssembly>()
                .UsingJobData(
                    JobDataKeys.Instance.ExecutableFilePath,
                    executableAssemblyFilePath)
                .ModifyIf(
                    description != default,
                    x => x.WithDescription(description))
                .Build();

            return job;
        }
    }
}