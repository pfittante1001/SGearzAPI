using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SGearzAPI.API.Data;
using SGearzAPI.API.Model;

namespace SGearzAPI.API.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;
        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
           _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<Product> GetProduct(int id)
        {
            //var user = await _context.Customers.FirstOrDefaultAsync(u => u.Id == id);
            var prod = await _context.Products.Include(p => p.ProductImages).FirstOrDefaultAsync(u => u.Id == id);
           return prod;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            //  var user = await _context.Customers.ToListAsync();
             var prod = await _context.Products.Include(p => p.ProductImages).ToListAsync();
             return prod;

        }
        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

    }
}