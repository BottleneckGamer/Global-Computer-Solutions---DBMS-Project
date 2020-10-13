using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalComputerSolutions.Configurations;
using Microsoft.EntityFrameworkCore;

namespace GlobalComputerSolutions.Models
{
    public class GCSContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        
        public GCSContext(DbContextOptions options) : base(options)
        {
            if (options == null) throw new ArgumentException(nameof(options));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            modelBuilder.ApplyConfiguration(new CertificationConfig());
            modelBuilder.ApplyConfiguration(new AssignmentConfig());
            modelBuilder.ApplyConfiguration(new BillConfig());
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new ProjectConfig());
            modelBuilder.ApplyConfiguration(new RegionConfig());
            modelBuilder.ApplyConfiguration(new ScheduleConfig());
            modelBuilder.ApplyConfiguration(new SkillConfig());
            modelBuilder.ApplyConfiguration(new TaskSkillConfig());
            modelBuilder.ApplyConfiguration(new WorkLogConfig());
        }

    }
}
