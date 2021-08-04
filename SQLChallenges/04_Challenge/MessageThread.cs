using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges._04_Challenge
{
    public class MessageThread
    {
        [Key]
        public int MessageThreadId { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        public List<User> Users { get; set; } = new List<User>();
    }
}
