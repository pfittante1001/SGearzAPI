using System;
using System.Collections.Generic;

namespace SGearzAPI.API.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; } 
        public bool IsUsed { get; set; }
        public DateTime DateListed { get; set; }       
        public ICollection<ProductImage> ProductImages { get; set; }
        public Category Category { get; set; }
        public int CategoryID { get; set; }
        public Supplier Supplier { get; set; }
        public int SupplierID { get; set; }
    }
}