using Microsoft.EntityFrameworkCore;
using SGearzAPI.API.Model;

namespace SGearzAPI.API.Data
{
    public class DataContext: DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        
         public DbSet<Customer> Customers { get; set; }
         public DbSet<Product> Products { get; set; }

         public DbSet<Order> Orders { get; set; }
         public DbSet<OrderDetail> OrderDetails { get; set; }

         public DbSet<Supplier> Suppliers { get; set; }
         public DbSet<Category> Categories { get; set; }
         public DbSet<ProductImage> ProductImages { get; set; }
         public DbSet<CustAddress> CustAddresses { get; set; }
         public DbSet<SupplierAddress> SupplierAddresses { get; set; }
        //public DbSet<User> Users { get; set; }

        
    }
}