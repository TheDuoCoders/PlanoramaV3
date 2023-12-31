using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Booking
    {   //not done - need package
        public int Id { get; set; }

        [Required]
        public int PackageId { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        [ForeignKey("User")]
        public string OrderedBy { get; set; }    

        [Required]
        public DateTime OrderTime { get; set; }

        public virtual User User { get; set; }
    }
}