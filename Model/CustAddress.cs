using System.ComponentModel.DataAnnotations.Schema;

namespace SGearzAPI.API.Model
{
    public class CustAddress
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
        public Customer Customer { get; set; }
        public int CustomerID { get; set; }
        
       
    }
}