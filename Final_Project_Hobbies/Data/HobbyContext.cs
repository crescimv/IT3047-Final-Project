using Final_Project_Hobbies.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Final_Project_Hobbies.Data
{
    public class HobbyContext : DbContext
    {
        public HobbyContext(DbContextOptions<HobbyContext> options) : base(options) { }

        public DbSet<Game> Games { get; set; }
    }
}