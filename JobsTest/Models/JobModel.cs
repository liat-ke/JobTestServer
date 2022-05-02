using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobHiring.Models
{
    public class JobModel
    {
        public List<int[]> JobsDetails { get; set; }
        public string[] Title
        {
            get
            {
                return new string[] { "Day Of Date", "Active Jobs", "Viewed Jobs", "Predicted Views" };
            }
        }
    }

    public class JobDetails
    {
        public int JobID { get; set; }
        public int ActiveJobsCount { get; set; }
        public int ViewedJobsCount { get; set; }
        public DateTime CurrentDate { get; set; }

        //calc PredictedJobCount
        /// TODO: Calculate real PredictedJobCount
        public int PredictedJobCount
        {
            get
            {
                return ActiveJobsCount * 2;
            }
        }

        public int CurrentDay
        {
            get
            {
                return CurrentDate.Day;
            }
        }

        public int CurrentMonth
        {
            get
            {
                return CurrentDate.Month;
            }
        }

        public int CurrentYear
        {
            get
            {
                return CurrentDate.Year;
            }
        }

    }
}
