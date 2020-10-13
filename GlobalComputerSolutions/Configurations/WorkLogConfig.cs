using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalComputerSolutions.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GlobalComputerSolutions.Configurations
{
    public class WorkLogConfig : IEntityTypeConfiguration<WorkLog>
    {
        public void Configure(EntityTypeBuilder<WorkLog> builder)
        {
            builder.ToTable("WorkLog");
            builder.HasKey(d => d.WorkLogId);
            builder.Property(d => d.WorkLogId).ValueGeneratedOnAdd();

            builder.HasOne(c => c.EmployeeLink)
                .WithMany(c => c.WorkLogs)
                .HasForeignKey(c => c.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
