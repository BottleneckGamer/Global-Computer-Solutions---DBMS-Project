using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalComputerSolutions.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string BriefDescription { get; set; }
        public DateTime SignDate { get; set; }
        public DateTime EstStartDate { get; set; }
        public DateTime EstEndDate { get; set; }
        public DateTime ActualStartDate { get; set; }
        public DateTime ActualEndDate { get; set; }

        public int CustomerId { get; set; }
        public Customer CustomerLink { get; set; }

        public int ManagerId { get; set; }
        public Employee Manager { get; set; }

        public ICollection<Assignment> Assignments { get; set; }

        public ICollection<Schedule> Schedules { get; set; }
    }
}
