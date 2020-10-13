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
    public class TaskSkillConfig : IEntityTypeConfiguration<TaskSkill>
    {
        public void Configure(EntityTypeBuilder<TaskSkill> builder)
        {
            builder.ToTable("TaskSkill");
            builder.HasKey(d => d.TaskSkillId);
            builder.Property(d => d.TaskSkillId).ValueGeneratedOnAdd();
        }
    }
}
