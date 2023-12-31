using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Coupon
    {
        public int Id { get; set; }

        [Required]
        public string CouponText { get; set; }

        [Required]
        public int DiscountPercentage { get; set; }    

        [Required]
        public DateTime Validity { get; set; }

    }
}