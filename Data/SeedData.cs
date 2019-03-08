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

        public void SeedCustomers() {
            var custData = System.IO.File.ReadAllText("Data/CustomerSeedData.json");
            var customers = JsonConvert.DeserializeObject<List<Customer>>(custData);
            foreach (var customer in customers)
            {
                customer.FirstName = customer.FirstName;
                customer.LastName = customer.LastName;
                customer.Email = customer.Email;
                customer.Phone = customer.Phone;
                customer.UserID = customer.UserID;

                _context.Customers.Add(customer);
            }

            _context.SaveChanges();
        }
        public void SeedUsers() {
            var userData = System.IO.File.ReadAllText("Data/UserSeedData.json");
            var users = JsonConvert.DeserializeObject<List<User>>(userData);
            foreach (var user in users)
            {
                byte[] passwordHash, passwordSalt;
                CreatePasswordHash("password", out passwordHash, out passwordSalt);
                
                    user.PasswordHash = passwordHash;
                    user.PasswordSalt = passwordSalt;
                    user.UserName = user.UserName.ToLower();
                    user.Created = user.Created;

                    _context.Users.Add(user);
                
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