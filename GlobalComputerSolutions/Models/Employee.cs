using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalComputerSolutions.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfHire { get; set; }

        public int RegionId { get; set; }
        public Region RegionLink { get; set; }

        //Implemented Unary Managers
        public int ManagerId { get; set; }
        public Employee Manager { get; set; }
        public ICollection<Employee> Employees { get; set; }

        public ICollection<Certification> Certifications { get; set; }

        public ICollection<Assignment> Assignments { get; set; }

        public ICollection<WorkLog> WorkLogs { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}
