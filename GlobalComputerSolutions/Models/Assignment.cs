using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalComputerSolutions.Models
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int EmployeeId { get; set; }
        public Employee EmployeeLink { get; set; }

        public ICollection<WorkLog> WorkLogs { get; set; }

        public int ProjectId { get; set; }
        public Project ProjectLink { get; set; }

        public int ScheduleId { get; set; }
        public Schedule ScheduleLink { get; set; }


    }
}
