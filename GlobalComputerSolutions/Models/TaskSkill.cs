using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalComputerSolutions.Models
{
    public class TaskSkill
    {
        public int TaskSkillId { get; set; }
        public int NumberOfEmployees { get; set; }

        public int SkillId { get; set; }
        public Skill SkillLink { get; set; }

        public int ScheduleId { get; set; }
        public Schedule ScheduleLink { get; set; }
    }
}
