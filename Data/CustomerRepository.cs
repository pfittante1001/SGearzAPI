using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SGearzAPI.API.Model;

namespace SGearzAPI.API.Data
{
    public class CustomerRepository : ISGearzRepository
    {
        private readonly DataContext _context;
        public CustomerRepository(DataContext context)
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

        public async Task<Customer> GetCustomer(int id)
        {
            var user = await _context.Customers.FirstOrDefaultAsync(u => u.Id == id);
            // var user = await _context.Users.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Id == id);
           return user;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
             var user = await _context.Customers.ToListAsync();
             // var user = await _context.Users.Include(p => p.Photos).ToListAsync();
             return user;

        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}