using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _11_RestaurantRater.Models
{
    public class RatingWithoutRestaurant
    {
        public int Id { get; set; }
        public double FoodScore { get; set; }
        public double EnvironmentScore { get; set; }
        public double CleanlinessScore { get; set; }
        public double AverageRating => (FoodScore + EnvironmentScore + CleanlinessScore) / 3;
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
    }
}