namespace SGearzAPI.API.DTO
{
    public class CustAddressDTO
    {
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public bool IsShipping { get; set; }
        public bool IsBilling { get; set; }
        
    }
}