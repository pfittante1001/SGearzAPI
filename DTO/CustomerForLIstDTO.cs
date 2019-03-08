using System.Collections.Generic;

namespace SGearzAPI.API.DTO
{
    public class CustomerForLIstDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public int Neck { get; set; }
        public double Waist { get; set; }
        public double Height { get; set; }
        public double Chest { get; set; }
        public double Hip { get; set; }
        public double Sleeve { get; set; }
        public double Shoulders { get; set; }
         public ICollection<CustAddressDTO> CustAddresses { get; set; }
    }
}