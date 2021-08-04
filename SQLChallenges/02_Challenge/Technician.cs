using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges._02_Challenge
{
    public class Technician
    {
        [Key]
        public int TechnicianId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public short CustomerRating { get; set; }

        [ForeignKey(nameof(Vehicle))]
        public Vehicle VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; } 
    }
}
