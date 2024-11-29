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
                CliNombre = cliente.CliNombre,
                CliEmail = cliente.CliEmail,
                CliPassword = cliente.CliPassword,
                CliCelular = cliente.CliCelular,
                CliDir = cliente.CliDir,
                CliFechReg = DateTime.Now,
                
            };
            _context.Clientes.Add(_cliente);
            _context.SaveChanges();

            var _carrito = new Carrito()
            {
                CliID = _cliente.CliID,
            };

            _context.Carritos.Add(_carrito);

            _context.SaveChanges();
        }



        public List<Cliente> GetAllClt() => _context.Clientes.ToList();

    }
}
