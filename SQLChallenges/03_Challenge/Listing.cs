using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges._03_Challenge
{
    public class Listing
    {
        [Key]
        public int ListingId { get; set; }

        public DateTime DateListed { get; set; }
        public bool IsRental { get; set; }

        [ForeignKey(nameof(House))]
        public House Houseld { get; set; }
        public virtual House House { get; set; }
    }
}
