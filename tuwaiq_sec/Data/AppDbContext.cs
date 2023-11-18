using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using tuwaiq_sec.Areas.Identity.Data;
using tuwaiq_sec.Models;

namespace tuwaiq_sec.Data
{
    public class AppDbContext : IdentityDbContext<tuwaiq_secUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomDetail> RoomDetail { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<CART> Carts { get; set; }
    }
}