using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalComputerSolutions.Models
{
    public class WorkLog
    {
        public int WorkLogId { get; set; }
        public int HoursWorked { get; set; }
        public DateTime Date { get; set; }

        public int BillNumber { get; set; }
        public Bill BillLink { get; set; }

        public int EmployeeId { get; set; }
        public Employee EmployeeLink { get; set; }

        public int AssignmentId { get; set; }
        public Assignment AssignmentLink { get; set; }

    }
}
