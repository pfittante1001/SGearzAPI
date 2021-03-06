using System;
using System.Collections.Generic;

namespace SGearzAPI.API.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; } 
        public string Size { get; set; }    
        public string Color { get; set; }
        public float UnitWeight { get; set; }
        public int ReOrderLevel { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int QuantityPerUnit { get; set; }
        public float MSRP { get; set; }
        public float UnitPrice { get; set; }
        public bool DiscountAvailable { get; set; }
        public bool ProductAvailable { get; set; }
        public string AvaiableSize { get; set; }
        public string AvailableColor { get; set; }
        public bool IsUsed { get; set; }
        public DateTime DateListed { get; set; }       
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<SupplierAddress> SupplierAddresses { get; set; }
        public Supplier Supplier { get; set; }
        public int? SupplierID { get; set; }
        
        public Category Category { get; set; } 
        public int? CateoryID { get; set; }
        
    }
}
