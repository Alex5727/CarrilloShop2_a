using CarrilloShop2.Data.Models;
using CarrilloShop2.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace CarrilloShop2.Data.Services
{
    public class ClienteService
    {
        private AppDBcontext _context;

        public ClienteService(AppDBcontext context)
        {
            _context = context;
        }

        public void AddCliente(ClienteVM cliente)
        {
            var _cliente = new Cliente()
            {
                CliCorreo = cliente.CliCorreo,
                CliNombre = cliente.CliNombre,
                CliApellidos = cliente.CliApellidos,
                CliTelefono = cliente.CliTelefono,
                CliCelular = cliente.CliCelular,
                CliDir = cliente.CliDir,
                CliFechReg = DateTime.Now,
                
            };
            _context.Clientes.Add(_cliente);
            _context.SaveChanges();

            var _carrito = new Carrito()
            {
                CliCorreo = _cliente.CliCorreo,
            };

            _context.Carritos.Add(_carrito);

            _context.SaveChanges();
        }



        public List<Cliente> GetAllClt() => _context.Clientes.ToList();

    }
}
