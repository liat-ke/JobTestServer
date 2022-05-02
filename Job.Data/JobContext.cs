using Job.Data.Entities;
using Job.Data.SPEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Job.Data
{
    public class JobContext : DbContext
    {
        public JobContext(DbContextOptions<JobContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        #region Entities
        public DbSet<JobDB> Jobs { get; set; }
        public DbSet<JobViewDB> JobViews { get; set; }
        #endregion

        #region SP Entities
        public DbSet<JobData> JobData { get; set; }
        #endregion
    }
}
