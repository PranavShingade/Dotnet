using Microsoft.EntityFrameworkCore;

namespace CodeFirstTest1.Models
{
    public class CustomerOrderDBContext:DbContext
    {
        public CustomerOrderDBContext(DbContextOptions options) : base(options)
        {
            
        }
        DbSet<Customer> Customers { get; set; }

        DbSet<Order> Orders { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Customers
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = Guid.Parse("481cf36a-fdb8-4911-853f-34ad26df4a2a"), 
                    FirstName = "Alice",
                    LastName = "Smith",
                    DOB = DateTime.Parse("1/1/1987")

                },
                new Customer
                {
                    CustomerID = Guid.Parse("1db7a052-91d5-43f0-8eeb-c852b504cd59"),
                    FirstName = "Bob",
                    LastName = "Smith",
                    DOB = DateTime.Parse("12/12/1986")
                }
            );

            // Seed data for Orders
            modelBuilder.Entity<Order>().HasData(
                new Order { OrderID = 1, CustomerID = "481cf36a-fdb8-4911-853f-34ad26df4a2a", ItemName = "NailPolish", ItemPrice = 100.00m },
                new Order { OrderID = 2, CustomerID = "481cf36a-fdb8-4911-853f-34ad26df4a2a", ItemName = "HairBrush", ItemPrice = 500.00m },
                new Order { OrderID = 3, CustomerID = "1db7a052-91d5-43f0-8eeb-c852b504cd59", ItemName = "ShavingCream", ItemPrice = 90.00m }
             );

            );

        }
    
}
