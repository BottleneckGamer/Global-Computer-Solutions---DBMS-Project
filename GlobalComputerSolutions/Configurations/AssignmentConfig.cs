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
    public class AssignmentConfig : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.ToTable("Assignment");
            builder.HasKey(d => d.AssignmentId);
            builder.Property(d => d.AssignmentId).ValueGeneratedOnAdd();

            builder.HasOne(c => c.ProjectLink)
                .WithMany(c => c.Assignments)
                .HasForeignKey(c => c.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.ScheduleLink)
                .WithMany(c => c.Assignments)
                .HasForeignKey(c => c.ScheduleId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
