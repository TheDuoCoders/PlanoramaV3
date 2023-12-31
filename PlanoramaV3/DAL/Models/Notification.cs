using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Notification
    {
        public int Id { get; set; }

        [Required]
        public string NotificationMessage { get; set; }

        [Required]
        [ForeignKey("User")]
        public string NotifiedUser { get; set; }    

        [Required]
        public DateTime NotificationTime { get; set; }

        public virtual User User { get; set; }
    }
}