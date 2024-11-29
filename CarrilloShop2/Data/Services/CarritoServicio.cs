using CarrilloShop2.Data.Models;
using CarrilloShop2.Data.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace CarrilloShop2.Data.Services
{
    public class CarritoServicio
    {
        private AppDBcontext _context;

        public CarritoServicio(AppDBcontext context)
        {
            _context = context;
        }

        public void AddCarrito(CarritoVM carrito)
        {
            var _carrito = new Carrito()
            {
                CarritoID = carrito.CarritoID,
                CliID = carrito.CliID,

            };
            _context.Carritos.Add(_carrito);
            _context.SaveChanges();
        }

        public List<Carrito> GetAllCarritos() => _context.Carritos.ToList();
    }
}
