using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalComputerSolutions.Models
{
    public class Certification
    {
        public int CertId { get; set; }
        public DateTime DateOfCertification { get; set; }

        public int EmployeeId { get; set; }
        public Employee EmployeeLink { get; set; }

        public int SkillId { get; set; }
        public Skill SkillLink { get; set; }
    }
}
