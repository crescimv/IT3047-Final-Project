using Final_Project_Hobbies.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Final_Project_Hobbies.Data
{
    public class HobbyContext : DbContext
    {
        public HobbyContext(DbContextOptions<HobbyContext> options) : base(options) { }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed data
            modelBuilder.Entity<Game>().HasData(
                new Game { Id = 1, Title = "Apex Legends", Genre = "Battle Royale" },
                new Game { Id = 2, Title = "Bloons TD", Genre = "Strategy" },
                new Game { Id = 3, Title = "Elden Ring", Genre = "Action-RPG" },
                new Game { Id = 4, Title = "Hollow Knight", Genre = "Metroidvania" },
                new Game { Id = 5, Title = "Hollow Knight: Silksong", Genre = "Metroidvania" },
                new Game { Id = 6, Title = "Minecraft", Genre = "Sandbox" },
                new Game { Id = 7, Title = "Subnautica", Genre = "Open World" },
                new Game { Id = 8, Title = "Subnautica: Below Zero", Genre = "Open World" },
                new Game { Id = 9, Title = "Super Mario Galaxy", Genre = "Platformer" },
                new Game { Id = 10, Title = "Super Mario Galaxy 2", Genre = "Platformer" },
                new Game { Id = 11, Title = "Super Paper Mario", Genre = "Platformer" },
                new Game { Id = 12, Title = "Sekiro", Genre = "Action" },
                new Game { Id = 13, Title = "Stardew Valley", Genre = "Simulation" },
                new Game { Id = 14, Title = "Terraria", Genre = "Sandbox" },
                new Game { Id = 15, Title = "The Legend of Zelda: Breath of the Wild", Genre = "Action-Adventure" },
                new Game { Id = 16, Title = "The Legend of Zelda: Skyward Sword", Genre = "Action-Adventure" },
                new Game { Id = 17, Title = "The Legend of Zelda: Windwaker", Genre = "Action-Adventure" },
                new Game { Id = 18, Title = "PowerWash Simulator", Genre = "Simulation" },
                new Game { Id = 19, Title = "PGA Tour", Genre = "Sports" },
                new Game { Id = 20, Title = "Pokemon", Genre = "RPG" },
                new Game { Id = 21, Title = "Halo", Genre = "First-Person Shooter" },
                new Game { Id = 22, Title = "Call of Duty", Genre = "First-Person Shooter"
                }
            );

        }
    }
}