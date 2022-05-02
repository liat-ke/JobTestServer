using Job.Data;
using Job.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobHiring.Services
{
    public class BaseService
    {
        protected readonly JobContext _db;

        protected BaseService(JobContext db)
        {
            _db = db;
        }
    }
}
