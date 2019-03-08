using System.Collections.Generic;

namespace SGearzAPI.API.Model
{
    public class Supplier
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }

        public ICollection<SupplierAddress> SupplierAddress { get; set; }
        
        public ICollection<Product> Products { get; set;}
    }
}