using CarrilloShop2.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrilloShop2.Data
{
    public class AppDBcontext : DbContext
    {
        public AppDBcontext(DbContextOptions<AppDBcontext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
        .HasKey(c => c.CliID); 

            modelBuilder.Entity<Cliente>()
                .Property(c => c.CliID)
                .ValueGeneratedOnAdd(); 

            modelBuilder.Entity<Producto>()
                .HasKey(p => p.ID); 

            modelBuilder.Entity<Producto>()
                .Property(p => p.ID)
                .ValueGeneratedOnAdd(); 

            modelBuilder.Entity<Carrito>()
                .HasKey(c => c.CarritoID); 

            modelBuilder.Entity<Carrito>()
                .Property(c => c.CarritoID)
                .ValueGeneratedOnAdd(); 

            modelBuilder.Entity<Cliente>()
                .HasOne(c => c.Carrito) 
                .WithOne(c => c.Cliente)
                .HasForeignKey<Carrito>(c => c.CliID); 
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Carrito> Carritos { get; set; }
    }
}
