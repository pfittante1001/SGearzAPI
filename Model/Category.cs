using System.Collections.Generic;

namespace SGearzAPI.API.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Product> Products {get; set;}
    }
}