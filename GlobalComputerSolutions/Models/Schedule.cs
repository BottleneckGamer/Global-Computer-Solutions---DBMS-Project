using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalComputerSolutions.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int ProjectId { get; set; }
        public Project ProjectLink { get; set; }

        public ICollection<TaskSkill> TaskSkills { get; set; }

        public ICollection<Assignment> Assignments { get; set; }

    }
}
