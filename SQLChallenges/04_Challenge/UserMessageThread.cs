using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges._04_Challenge
{
    public class UserMessageThread
    {
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey(nameof(MessageThread))]
        public int MessageThreadId { get; set; }
        public virtual MessageThread MessageThread { get; set; }
    }
}
