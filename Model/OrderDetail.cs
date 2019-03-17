using System;

namespace SGearzAPI.API.Model
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public string OrderNumber { get;}//get this from orders table
        public float Price { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }
        public float Total { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public DateTime ShipDate { get; set; }
        public bool IsComplete { get; set; }
        public DateTime BillDate { get; set; }
        public Product Product { get; set; }
        public int? ProductID { get; set; }
        public Order Order { get; set; }
        public int? OrderID { get; set; }
        
    }
}