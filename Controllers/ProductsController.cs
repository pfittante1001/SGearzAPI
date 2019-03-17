using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SGearzAPI.API.Data;
using SGearzAPI.API.DTO;
using SGearzAPI.API.Model;

namespace SGearzAPI.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        // private readonly DataContext _context;

        // public ProductController(DataContext context)
        // {
        //     _context = context;

        // }
        private readonly IProductRepository _repo;
        private readonly IMapper _mapper;

        public ProductsController(IProductRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _repo.GetProducts();
            var productsToReturn = _mapper.Map<IEnumerable<ProductForListDTO>>(products);
            return Ok(productsToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _repo.GetProduct(id);
            var productToReturn = _mapper.Map<ProductForListDTO>(product);

            return Ok(productToReturn);
        }

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