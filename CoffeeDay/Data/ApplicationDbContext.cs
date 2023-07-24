using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeDay.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<ReservationModel> Reservations { get; set; }
    }
}
