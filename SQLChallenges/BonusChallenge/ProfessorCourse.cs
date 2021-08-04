using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.BonusChallenge
{
    public class ProfessorCourse
    {
        [ForeignKey(nameof(Professor))]
        public int ProfessorId { get; set; }
        public virtual Professor Professor { get; set; }

        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
