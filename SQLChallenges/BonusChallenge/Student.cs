using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.BonusChallenge
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey(nameof(Advisor))] 
        public int AdvisorId { get; set; } // Allows to specify which advisor we want to connect to.  
        public virtual Professor Advisor { get; set; } // Navigational Property that creates a link between tables.  
        
        public List<StudentCourse> Courses { get; set; } = new List<StudentCourse>();
    }
}
