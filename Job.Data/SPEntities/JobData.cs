using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Job.Data.SPEntities
{
    public class JobData
    {
        [Key]
        public Guid ID { get; set; }
        public DateTime ViewedDate { get; set; }
        public int CountViewJobs { get; set; }
        public int ActiveJobs { get; set; }
    }
}
