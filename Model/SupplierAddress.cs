using System.ComponentModel.DataAnnotations.Schema;

namespace SGearzAPI.API.Model
{
    public class SupplierAddress
    {
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public bool IsMain  { get; set; }
        public Supplier Supplier { get; set; }
        public int? SupplierID { get; set; }
    }
}