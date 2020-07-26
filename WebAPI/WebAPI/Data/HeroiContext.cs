using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class HeroiContext : DbContext
    {
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
    }
}
