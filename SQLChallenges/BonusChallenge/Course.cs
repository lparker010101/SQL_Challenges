using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.BonusChallenge
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string CourseCode { get; set; }
        public List<Professor> Professors { get; set; } = new List<Professor>();
        public List<Student> Student { get; set; } = new List<Student>();
    }
}
