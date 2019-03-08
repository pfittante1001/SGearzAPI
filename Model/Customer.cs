using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGearzAPI.API.Model
{
    public class Customer
    {
        public int Id { get; set; }
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
        public int UserID { get; set; }
        public User User { get; set; }
    }
}