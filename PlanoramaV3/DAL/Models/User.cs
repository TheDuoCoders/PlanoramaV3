using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class User
    {
        [Key]
        public string Uname { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        [Required]
        public DateTime DOB { get; set; }    

        [Required]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }    

        [Required]
        public int Points { get; set; }

        [Required]
        public string UserType {get; set;}
    }
}