using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class RoomsContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
    }
}
