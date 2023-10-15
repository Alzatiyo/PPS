using Microsoft.EntityFrameworkCore;
using PPS.Shared.Entities;

namespace PPS.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 
        }
        public DbSet<EstadoServicio> estadoServicios { get; set; }
        public DbSet<Linea> lineas { get; set; }
        public DbSet<Liquidacion> liquidacions { get; set; }
        public DbSet<Lugar> lugars { get; set; }
        public DbSet<Marca> marcas { get; set; }
        public DbSet<Recorrido> recorridos { get; set; }
        public DbSet<Servicio> servicios { get; set; }
        public DbSet<TipoCarroceria> tipoCarrocerias { get; set; }
        public DbSet<Transito> transitos { get; set; }
        public DbSet<Vehiculo> vehiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EstadoServicio>().HasIndex(m => m.Estado).IsUnique();
            modelBuilder.Entity<Linea>().HasIndex(m => m.Nombre).IsUnique();
            modelBuilder.Entity<Liquidacion>().HasIndex(m => m.Facturar).IsUnique();
            modelBuilder.Entity<Lugar>().HasIndex(m => m.Nombre).IsUnique();
            modelBuilder.Entity<Marca>().HasIndex(m => m.Nombre).IsUnique();
            modelBuilder.Entity<Recorrido>().HasIndex(m => m.valor).IsUnique();
            modelBuilder.Entity<Servicio>().HasIndex(m => m.NumeroServicio).IsUnique();
            modelBuilder.Entity<TipoCarroceria>().HasIndex(m => m.Nombre).IsUnique();
            modelBuilder.Entity<Transito>().HasIndex(m => m.Nombre).IsUnique();
            modelBuilder.Entity<Vehiculo>().HasIndex(m => m.placa).IsUnique();

        }


    }
}
