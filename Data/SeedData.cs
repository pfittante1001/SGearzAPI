using System.Collections.Generic;
using Newtonsoft.Json;
using SGearzAPI.API.Model;

namespace SGearzAPI.API.Data
{
    public class SeedData
    {
        private readonly DataContext _context;
        
        public SeedData(DataContext context)
        {
            _context = context;
        }

        public void SeedUsers() {
            var custData = System.IO.File.ReadAllText("Data/UserSeedData.json");
            var customers = JsonConvert.DeserializeObject<List<Customer>>(custData);
            foreach (var cust in customers)
            {
                byte[] passwordHash, passwordSalt;
                CreatePasswordHash("password", out passwordHash, out passwordSalt);
                
                    cust.PasswordHash = passwordHash;
                    cust.PasswordSalt = passwordSalt;
                    cust.UserName = cust.UserName.ToLower();
                    
                    _context.Customers.Add(cust);
                
            }
            _context.SaveChanges();
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using(var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}