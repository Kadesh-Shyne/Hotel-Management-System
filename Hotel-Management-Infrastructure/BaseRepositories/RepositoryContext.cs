using Hotel_Management_System.Models;
using Hotel_Mgt_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Management_Infrastructure.BaseRepositories
{
    public class RepositoryContext: DbContext
    {
       public RepositoryContext(DbContextOptions<RepositoryContext> options): base(options)
        {
            
        }
        public DbSet<CustomerDetails>? CustomerDetail { get; set; }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Bookings>? Bookings { get; set; }
        public DbSet<Room>? Rooms { get; set; }
        public DbSet<Payment>? Payments { get; set; }
        public DbSet<Hostel>? Hostel { get; set; }
    }
}
