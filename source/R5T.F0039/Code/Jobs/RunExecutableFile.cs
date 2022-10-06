using System;
using System.Threading.Tasks;

using Quartz;


namespace R5T.F0039
{
    public class RunExecutableFile : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            var executableFilePath = context.JobDetail.JobDataMap.GetString("ExecutableFilePath");

            return F0000.CommandLineOperator.Instance.Run(executableFilePath);
        }
    }
}
