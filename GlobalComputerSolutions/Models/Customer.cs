using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalComputerSolutions.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public int RegionId { get; set; }
        public Region RegionLink { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}
