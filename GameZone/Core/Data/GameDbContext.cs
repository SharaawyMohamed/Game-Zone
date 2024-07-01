using GameZone.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace GameZone.Core.Data
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions<GameDbContext> options) : base(options)
        {

        }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameDevice> GamesDevices { get; set; }
        public DbSet<Categorey> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameDevice>().HasKey(k => new { k.GameId, k.DeviceId });// create composit primary key
            modelBuilder.Entity<Categorey>().HasData(new Categorey[] {
            new Categorey { Id = 1, Name = "Action" },
            new Categorey { Id = 2, Name = "Adventure" },
            new Categorey { Id = 3, Name = "RPG" },
            new Categorey { Id = 4, Name = "Simulation" },
            new Categorey { Id = 5, Name = "Strategy" },
            new Categorey { Id = 6, Name = "Sports" },
            new Categorey { Id = 7, Name = "Puzzle" },
            new Categorey { Id = 8, Name = "Racing" },
            new Categorey { Id = 9, Name = "Shooter" },
            new Categorey { Id = 10, Name = "Horror" }

        });
            modelBuilder.Entity<Device>().HasData(new Device[]
            {
                new Device { Id = 1, Name = "PC", ICone = "pc_icon.png" },
            new Device { Id = 2, Name = "PlayStation", ICone = "ps_icon.png" },
            new Device { Id = 3, Name = "Xbox", ICone = "xbox_icon.png" },
            new Device { Id = 4, Name = "Nintendo Switch", ICone = "switch_icon.png" },
            new Device { Id = 5, Name = "Mobile", ICone = "mobile_icon.png" },
            new Device { Id = 6, Name = "Tablet", ICone = "tablet_icon.png" },
            new Device { Id = 7, Name = "VR Headset", ICone = "vr_icon.png" }
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
