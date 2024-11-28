using Microsoft.AspNetCore.Builder;
using static System.Reflection.Metadata.BlobBuilder;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using CarrilloShop2.Models;

namespace CarrilloShop2
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBcontext>();

                if (!context.Clientes.Any())
                {
                    context.Clientes.AddRange(new Cliente()
                    {
                        CliCorreo = "j@gmail.com",
                        CliNombre = "Jorge",
                        CliApellidos = "Grijalva",
                        CliTelefono = "6666666666",
                        CliCelular = "77676677",
                        CliDir = "conocida",
                        CliFechReg = DateTime.Now,

                    },
                      new Cliente()
                      {
                          CliCorreo = "s@gmail.com",
                          CliNombre = "Alex",
                          CliApellidos = "Soqui",
                          CliTelefono = "666446666",
                          CliCelular = "77623677",
                          CliDir = "conocida",
                          CliFechReg = DateTime.Now,

                      });
                    context.SaveChanges();
                }
            }
        }
    }
}
