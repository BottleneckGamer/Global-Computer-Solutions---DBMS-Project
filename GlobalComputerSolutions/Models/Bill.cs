using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalComputerSolutions.Models
{
    public class Bill
    {
        public int BillNumber { get; set; }
        public DateTime BillDate { get; set; }
        public int TotalAmount { get; set; }

        public ICollection<WorkLog> WorkLogs { get; set; }
    }
}
