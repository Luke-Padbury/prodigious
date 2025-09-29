using Microsoft.EntityFrameworkCore;

namespace Prodigious.Models
{
    public class DigimonDbContext : DbContext
    {
        public DbSet<Digimon> Digimon { get; set; }

        public string connectionString = @"./DigimonDB.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite($"Data Source={connectionString}");
        }
    }
}
