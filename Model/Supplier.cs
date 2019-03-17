using System.Collections.Generic;

namespace SGearzAPI.API.Model
{
    public class Supplier
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string ContactFName { get; set; }
        public string ContactLName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string WebSiteUrl { get; set; }
        public string PaymentMethods { get; set; }
        public string DiscountType { get; set; }
        public bool CurrentOrder { get; set; }

        public ICollection<SupplierAddress> SupplierAddress { get; set; }
        
        public ICollection<Product> Products { get; set;}
    }
}