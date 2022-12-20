using System;
using System.Threading.Tasks;

using Quartz;

using R5T.T0142;


namespace R5T.F0039
{
    [UtilityTypeMarker]
    public class RunDotnetExecutableAssembly : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            var executableFilePath = context.JobDetail.JobDataMap.GetString(
                JobDataKeys.Instance.ExecutableFilePath);

            return F0000.CommandLineOperator.Instance.Run(
                "dotnet",
                executableFilePath);
        }
    }
}
