using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Job.Data.Entities
{
    [Table("Job")]
    public class JobDB
    {
        [Key]
        public int JobID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
