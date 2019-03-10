using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using SGearzAPI.API.DTO;

namespace SGearzAPI.API.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string UserName { get; set; }    
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }  
        public DateTime Created { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }
        public int Neck { get; set; }
        public double Waist { get; set; }
        public double Height { get; set; }
        public double Chest { get; set; }
        public double Hip { get; set; }
        public double Sleeve { get; set; }
        public double Shoulders { get; set; }
        public ICollection<CustAddress> CustAddresses { get; set; }
    }
}