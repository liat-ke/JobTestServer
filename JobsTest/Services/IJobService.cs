using JobHiring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobHiring.Services
{
    public interface IJobService
    {
        #region Getter
        JobModel GetJobModel(int month, int year);
        #endregion
    }
}
