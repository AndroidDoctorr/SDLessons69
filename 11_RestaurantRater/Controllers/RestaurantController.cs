using _11_RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace _11_RestaurantRater.Controllers
{
    public class RestaurantController : ApiController
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();

        // Create

        // POST
        [HttpPost]
        public async Task<IHttpActionResult> PostRestaurant(Restaurant model)
        {
            if (ModelState.IsValid)
            {
                _context.Restaurants.Add(model);
                await _context.SaveChangesAsync();

                return Ok();
            }

            return BadRequest(ModelState); // 400
        }

        // Read

        // GET ALL
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            // Select is kind of like a conversion
            List<RestaurantListItem> restaurants = await _context.Restaurants.Select(r => new RestaurantListItem() {
                Name = r.Name,
                Id = r.Id,
                Rating = r.Rating
            }).ToListAsync();
            return Ok(restaurants);

            // I can also convert my list of Restaurants into a list of strings
            // List<string> restaurantNames = _context.Restaurants.Select(r => r.Name).ToList();

            // FirstOrDefault
            Restaurant restaurant = _context.Restaurants.FirstOrDefault(r => r.Name.StartsWith("B"));

            List<bool> bRestaurants = _context.Restaurants.Select(r => r.Name.StartsWith("B")).ToList();
        }

        // GET BY ID
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            Restaurant restaurant = await _context.Restaurants.FindAsync(id);

            if (restaurant != null)
            {
                return Ok(restaurant); // 200
            }

            return NotFound(); // 404
        }

        // Update
        [HttpPut]
        public async Task<IHttpActionResult> UpdateRestaurant([FromUri] int id, [FromBody] Restaurant model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400
            }

            Restaurant restaurant = await _context.Restaurants.FindAsync(id);

            if (restaurant == null)
            {
                return NotFound(); // 404
            }

            restaurant.Name = model.Name;
            restaurant.Address = model.Address;
            // restaurant.Rating = model.Rating;

            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok(); // 200
            }

            return InternalServerError(); // 500

            // 403 = ?? Forbidden (not authorized)

            // 418 = I'm a teapot (misc. or unknown error)
        }

        // Delete

        [HttpDelete]
        public async Task<IHttpActionResult> DeleteRestaurantById(int id)
        {
            Restaurant restaurant = await _context.Restaurants.FindAsync(id);

            if (restaurant == null)
            {
                return NotFound(); // 404
            }

            _context.Restaurants.Remove(restaurant);

            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok(); // 200
            }

            return InternalServerError(); // 500
        }
    }
}