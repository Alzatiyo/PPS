﻿using Microsoft.EntityFrameworkCore;
using PPS.Shared.Entities;

namespace PPS.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 
        }
        public DbSet<EstadoServicio> EstadoServicios { get; set; }
        public DbSet<Linea> Lineas { get; set; }
        public DbSet<Liquidacion> Liquidacions { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Recorrido> Recorridos { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<TipoCarroceria> TipoCarrocerias { get; set; }
        public DbSet<Transito> Transitos { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EstadoServicio>().HasIndex(m => m.Estado).IsUnique();
            modelBuilder.Entity<Linea>().HasIndex(m => m.Nombre).IsUnique();
            modelBuilder.Entity<Liquidacion>().HasIndex(m => m.Valor).IsUnique();
            modelBuilder.Entity<Marca>().HasIndex(m => m.Nombre).IsUnique();
            modelBuilder.Entity<Recorrido>().HasIndex(m => m.Nombre).IsUnique();
            modelBuilder.Entity<Servicio>().HasIndex(m => m.NumeroServicio).IsUnique();
            modelBuilder.Entity<TipoCarroceria>().HasIndex(m => m.Nombre).IsUnique();
            modelBuilder.Entity<Transito>().HasIndex(m => m.Nombre).IsUnique();
            modelBuilder.Entity<Vehiculo>().HasIndex(m => m.placa).IsUnique();

        }
    }
}
