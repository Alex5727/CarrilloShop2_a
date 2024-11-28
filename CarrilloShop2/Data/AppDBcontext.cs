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
                .HasKey(c => c.CliCorreo); // Clave primaria

            modelBuilder.Entity<Producto>()
              .HasKey(c => c.ID);

            modelBuilder.Entity<Cliente>()
           .HasOne(c => c.Carrito) 
           .WithOne(c => c.Cliente) 
           .HasForeignKey<Carrito>(c => c.CliCorreo);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Carrito> Carritos { get; set; }
    }
}
