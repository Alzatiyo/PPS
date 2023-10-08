using Microsoft.EntityFrameworkCore;
//using PPS.s

namespace PPS.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //public DbSet<Lugares> Lugares { get; set; }
        //public DbSet<Investigador> Investigadores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Investigador>().HasIndex(m => m.Documento).IsUnique();
            //modelBuilder.Entity<ProyectoInvestigacion>().HasIndex(m => m.Nombre).IsUnique();
        }
    }
}
