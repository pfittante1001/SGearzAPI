using System;

namespace SGearzAPI.API.Model
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }    
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }  
        public DateTime Created { get; set; } 
        public Customer Customer { get; set; }
    }
}