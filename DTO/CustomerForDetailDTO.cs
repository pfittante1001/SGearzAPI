using System.Collections.Generic;

namespace SGearzAPI.API.DTO
{
    public class CustomerForDetailDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ICollection<CustAddressDTO> CustAddresses { get; set; }

    }
}