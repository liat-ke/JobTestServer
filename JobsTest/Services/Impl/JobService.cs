using Job.Data;
using Job.Data.Entities;
using Job.Data.SPEntities;
using JobHiring.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobHiring.Services.Impl
{
    public class JobService : BaseService, IJobService
    {
        public JobService(JobContext db) : base(db)
        {

        }

        public JobModel GetJobModel(int month, int year)
        {
            JobModel jobs;
            List<JobDetails> jobsDetails = new List<JobDetails>();
            SqlParameter param1 = new SqlParameter("@month", month);
            SqlParameter param2 = new SqlParameter("@year", year);

            jobsDetails = _db.JobData.FromSqlRaw("EXEC GetJobsData @month, @year", new[] { param1, param2 }).AsEnumerable()
                .Select(x => new JobDetails
                {
                    CurrentDate = x.ViewedDate,
                    ViewedJobsCount = x.CountViewJobs,
                    ActiveJobsCount = x.ActiveJobs,
                }).ToList();

            List<int[]> arrayList = new List<int[]>();
            if (jobsDetails.Count > 0)
            {
                foreach (var item in jobsDetails)
                {
                    int[] jobDetails = new[] { item.CurrentDay, item.ActiveJobsCount, item.ViewedJobsCount, item.PredictedJobCount };
                    arrayList.Add(jobDetails);
                }
            }

            jobs = new JobModel
            {
                JobsDetails = arrayList
            };

            return jobs;
        }
    }
}
