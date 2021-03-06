using Microsoft.EntityFrameworkCore;

namespace invoice_api.Models
{
    public class DataContext : DbContext
    {
        public DataContext
            (DbContextOptions<DataContext> options) : base(options)         
        {         
        }       
        public DbSet<User> Users { get; set; } 
        public DbSet<Business> Businesses { get; set; } 
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Driver> Drivers { get; set; }      

  
    } 
}