using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SGearzAPI.API.Data;
using SGearzAPI.API.DTO;

namespace SGearzAPI.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        // private readonly DataContext _context;

        private readonly ISGearzRepository _repo;
        private readonly IMapper _mapper;

        public CustomersController(ISGearzRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;

        }
        // public CustomersController(DataContext context)
        // {
        //     _context = context;

        // }
        // GET api/values

        // [HttpGet]
        // public async Task<IActionResult> Get()
        // {
        //     var customers = await _context.Customers.ToListAsync();

        //     return Ok(customers);
        // }


        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            var customers = await _repo.GetCustomers();
            var customersToReturn = _mapper.Map<IEnumerable<CustomerForListDTO>>(customers);

            return Ok(customersToReturn);
        }



        // GET api/values/5
        // [HttpGet("{id}")]
        // public async Task<IActionResult> Get(int id)
        // {
        //     var customer = await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);

        //     return Ok(customer);
        // }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer(int id)
        {
            var customer = await _repo.GetCustomer(id);
            var customerToReturn = _mapper.Map<CustomerForDetailDTO>(customer);

            return Ok(customerToReturn);
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