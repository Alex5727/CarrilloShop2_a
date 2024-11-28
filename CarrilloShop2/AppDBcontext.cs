using CarrilloShop2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrilloShop2
{
    public class AppDBcontext: DbContext
    {
        public AppDBcontext(DbContextOptions<AppDBcontext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.CliCorreo); // Clave primaria
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
