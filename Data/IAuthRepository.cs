using System.Threading.Tasks;
using SGearzAPI.API.Model;

namespace SGearzAPI.API.Data
{
    public interface IAuthRepository
    {
         Task<Customer> Register(Customer customer, string password);
         Task<Customer> Login(string username, string password);
         Task<bool> CustomerExists(string username);
    }
}