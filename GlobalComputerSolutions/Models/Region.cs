using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalComputerSolutions.Models
{
    public class Region
    {
        public int RegionId { get; set; }
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}
