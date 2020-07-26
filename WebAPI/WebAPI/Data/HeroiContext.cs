using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using Microsoft.Extensions.Configuration;

namespace WebAPI.Data
{
    public class HeroiContext : DbContext
    {
        
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public HeroiBatalha HeroisBatalhas { get; set; }
        public IdentidadeSecreta IdentidadesSecretas { get; set; }
        public HeroiContext(DbContextOptions options) : base(options){}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer("ConnectionString");        
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(entity => 
            {
                entity.HasKey(e => new { e.BatalhaId, e.HeroiId });
            });
        }

    }
}
