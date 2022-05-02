using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Job.Data.Entities
{
    [Table("JobView")]
    public class JobViewDB
    {
        [Key]
        public int JobViewID { get; set; }
        public int JobID { get; set; }
        public string ViewedBy { get; set; }
        public string ViewdIP { get; set; }
        public DateTime ViewedDate { get; set; }
        public virtual JobDB JobDB { get; set; }
    }
}
