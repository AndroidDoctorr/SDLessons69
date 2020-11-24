using _11_RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _11_RestaurantRater.Controllers
{
    public class RatingController : ApiController
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();
        // POST
        [HttpPost]
        public async Task<IHttpActionResult> PostRating(Rating model)
        {
            if (ModelState.IsValid)
            {
                Restaurant restaurant = await _context.Restaurants.FindAsync(model.RestaurantId);
                if (restaurant == null)
                {
                    return BadRequest("There is no restaurant with that ID");
                }

                _context.Ratings.Add(model);
                await _context.SaveChangesAsync();

                return Ok();
            }

            return BadRequest(ModelState); // 400
        }

        // GET ALL
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            List<RatingWithoutRestaurant> ratings = await _context.Ratings
                .Select(r => new RatingWithoutRestaurant() {
                    Id = r.Id,
                    FoodScore = r.FoodScore,
                    CleanlinessScore = r.CleanlinessScore,
                    EnvironmentScore = r.EnvironmentScore,
                    RestaurantId = r.RestaurantId,
                    // RestaurantName = r.Restaurant.Name,
                })
                .ToListAsync();
            return Ok(ratings);
        }

        // GET Ratings by restaurant
        [HttpGet]
        public async Task<IHttpActionResult> Get(int id)
        {
            List<Rating> ratings = await _context.Ratings.Where(
                r => r.RestaurantId == id
                ).ToListAsync();
            return Ok(ratings);
        }
    }
}
