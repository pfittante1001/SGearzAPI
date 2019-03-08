using System.Collections.Generic;
using System.Threading.Tasks;
using SGearzAPI.API.Model;

namespace SGearzAPI.API.Data
{
    public interface ISGearzRepository
    {
         void Add<T>(T entity) where T: class ;
         void Delete<T>(T entity) where T: class;

         Task<bool> SaveAll();
         Task<IEnumerable<Customer>> GetCustomers();
         Task<Customer> GetCustomer(int id);
        
    }
}