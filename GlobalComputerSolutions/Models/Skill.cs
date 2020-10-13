using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalComputerSolutions.Models
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string Name { get; set; }
        public int RateOfPay { get; set; }

        public ICollection<Certification> Certifications { get; set; }

        public ICollection<TaskSkill> TaskSkills { get; set; }
    }
}
