using System;

namespace SGearzAPI.API.Model
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OderDate { get; set; }
        public string OrderNumber { get; set; }//set to sequencial
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public float Frieght { get; set; }
        public string TransactionStatus { get; set; }//maybe another table for dropdown
        public Customer Customer { get; set; }
        public int? CustomerID { get; set; }


    }
}