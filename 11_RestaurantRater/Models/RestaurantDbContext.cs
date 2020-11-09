using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _11_RestaurantRater.Models
{
    public class RestaurantDbContext : DbContext
    {
        // Inherits from DbContext in EntityFramework - this translates between SQL and C#
        public RestaurantDbContext() : base("DefaultConnection") { }


        // Defines our Restaurants - EntityFramework will convert our SQL db table into a collection of C# objects
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}