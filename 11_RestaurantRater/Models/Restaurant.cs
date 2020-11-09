using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _11_RestaurantRater.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public double Rating
        {
            get
            {
                double totalRatingScore = 0;
                foreach(Rating rating in Ratings)
                {
                    totalRatingScore += rating.AverageRating;
                }
                if (Ratings.Count == 0)
                {
                    return 5;
                }
                else
                {
                    return totalRatingScore / Ratings.Count;
                }
            }
        }
        public virtual List<Rating> Ratings { get; set; } = new List<Rating>();
    }
}