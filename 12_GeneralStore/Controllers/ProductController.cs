using _12_GeneralStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _12_GeneralStore.Controllers
{
    public class ProductController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // Create
        [HttpPost]
        public async Task<IHttpActionResult> Create(Product product)
        {
            // return Unauthorized(); // 403
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return Ok();
            }

            return BadRequest(ModelState); // 400
        }

        // Read
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        // Update
        [HttpPut]
        [ActionName("Update")]
        public async Task<IHttpActionResult> UpdateProduct([FromUri] int id, [FromBody] Product model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400
            }

            Product product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound(); // 404
            }

            product.ProductName = model.ProductName;
            product.Quantity = model.Quantity;
            product.Price = model.Price;
            product.UPC = model.UPC;

            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok(); // 200
            }

            return InternalServerError(); // 500
        }

        // I have to put ActionName here so I can have two Put requests on the same controller.
        // I don't have a Restock table, so it doesn't make sense to have a whole separate controller,
        // unless of course we wanted to keep track of when we restock separately
        [HttpPut]
        [ActionName("Restock")]
        public async Task<IHttpActionResult> RestockAProduct([FromUri] int id, [FromBody] Restock model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400
            }

            Product product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound(); // 404
            }

            product.Quantity += model.Quantity;

            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok(); // 200
            }

            return InternalServerError(); // 500
        }

        // Delete
        [HttpDelete]
        public async Task<IHttpActionResult> DeleteProduct(int id)
        {
            Product product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound(); // 404
            }

            _context.Products.Remove(product);

            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok(); // 200
            }

            return InternalServerError(); // 500
        }
    }
}
