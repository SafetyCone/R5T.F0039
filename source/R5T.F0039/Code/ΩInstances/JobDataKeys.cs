using System;


namespace R5T.F0039
{
    public class JobDataKeys : IJobDataKeys
    {
        #region Infrastructure

        public static IJobDataKeys Instance { get; } = new JobDataKeys();


        private JobDataKeys()
        {
        }

        #endregion
    }
}
