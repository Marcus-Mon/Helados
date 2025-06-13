using Microsoft.EntityFrameworkCore;

namespace Helados.Server.Models
{
    public class HeladosContext : DbContext
    {
        //Marcus Montilla 2024-1783

        public HeladosContext(DbContextOptions<HeladosContext> options) : base(options)
        { 
        }

        public DbSet<Helado> Helados { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Helado>().HasIndex(h => h.Nombre).IsUnique();
        }

    }
}
