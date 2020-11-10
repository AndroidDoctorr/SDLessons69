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
    public class TransactionController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        [HttpPost]
        public async Task<IHttpActionResult> Create(Transaction transaction)
        {
            // return Unauthorized(); // 403
            if (ModelState.IsValid)
            {
                // Lazy loading does not work on the controller like this:
                // Product product = transaction.Product;

                // So we have to fetch the item by its ID from the context:
                Product product = await _context.Products.FindAsync(transaction.ProductID);
                Customer customer = await _context.Customers.FindAsync(transaction.CustomerID);

                if (product == null)
                {
                    return BadRequest("Invalid Product ID");
                }
                if (customer == null)
                {
                    return BadRequest("Invalid Customer ID");
                }

                if (transaction.Quantity > product.Quantity)
                {
                    return BadRequest($"There are only {product.Quantity} of {product.ProductName} left in stock");
                }

                product.Quantity -= transaction.Quantity;

                _context.Transactions.Add(transaction);
                await _context.SaveChangesAsync();
                return Ok();
            }

            return BadRequest(ModelState); // 400
        }

        // Read
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Transaction> transactions = await _context.Transactions.ToListAsync();
            return Ok(transactions);
        }
    }
}
