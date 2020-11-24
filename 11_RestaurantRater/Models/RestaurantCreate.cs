using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _11_RestaurantRater.Models
{
    public class RestaurantCreate
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
    }
}