using System;

using R5T.T0131;


namespace R5T.F0039
{
    [ValuesMarker]
    public partial interface IJobDataKeys : IValuesMarker
    {
        public string ExecutableFilePath => "ExecutableFilePath";
    }
}
