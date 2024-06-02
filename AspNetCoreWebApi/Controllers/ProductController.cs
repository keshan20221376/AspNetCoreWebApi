using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ShopContext _context;

        public ProductController(ShopContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }
        //Get All Products
        [HttpGet]
        public async Task <ActionResult<IEnumerable<Product>>> getAllProducts()
        {
            return Ok(await _context.Products.ToArrayAsync());
        }
        //Get Selected Product 
        [HttpGet]
        [Route("{id}")]
        public async Task <ActionResult> getProduct(int id)
        {
            var Product = await _context.Products.FindAsync(id);
            if(Product == null)
            {
                return NotFound();
            }
            return Ok(Product);
        }
        //Get Available Products 
        [HttpGet]
        [Route("available")]
        public async Task<ActionResult<IEnumerable<Product>>> getAvailableProducts()
        {
            return Ok(await _context.Products.Where(p => p.IsAvailable).ToArrayAsync());
        }
    }
}
