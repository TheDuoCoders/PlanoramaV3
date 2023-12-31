﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Food
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]

        public string Name { get; set; }

        [ForeignKey("FoodsCategory")]
        public int FoodCategory {  get; set; }

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

        public virtual FoodsCategory FoodsCategory { get; set; }
    }
}