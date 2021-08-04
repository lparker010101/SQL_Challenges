using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.BonusChallenge
{
    public class Professor
    {
        [Key]
        public int ProfessorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsTenured { get; set; }
        public List<Course> Course { get; set; } = new List<Course>();
    }
}
