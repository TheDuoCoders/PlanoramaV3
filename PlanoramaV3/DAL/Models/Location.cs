﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]

        public string Name { get; set; }

        [ForeignKey("LocationsCategory")]
        public int LocationCategory { get; set; }

        [Required]
        [StringLength(20)]

        public string Picture { get; set; }

        [Required]
        [StringLength(200)]

        public string Description { get; set; }

        [Required]

        public double Price { get; set; }

        [Required]

        public int TimesSelected { get; set; }

        public virtual LocationsCategory LocationsCategory { get; set; }
    }
}