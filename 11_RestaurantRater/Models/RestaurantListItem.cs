using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _11_RestaurantRater.Models
{
    public class RestaurantListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
    }
}