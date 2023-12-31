using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        public string ReviewText { get; set; }

        [Required]
        [ForeignKey("User")]
        public string PostedBy { get; set; }    

        [Required]
        public DateTime PostedTime { get; set; }

        public virtual User User { get; set; }
    }
}