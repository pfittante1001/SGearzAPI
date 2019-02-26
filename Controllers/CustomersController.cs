using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SGearzAPI.API.Data;

namespace SGearzAPI.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly DataContext _context;
        public CustomersController(DataContext context)
        {
            _context = context;

        }
        // GET api/values
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var customers = await _context.Customers.ToListAsync();

            return Ok(customers);
        }
        [AllowAnonymous]
        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
             var customer = await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);

             return Ok(customer);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}