using CarrilloShop2.Data.Models;
using CarrilloShop2.Data.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System;

namespace CarrilloShop2.Data.Services
{
    public class ProductoService
    {
        private AppDBcontext _context;

        public ProductoService(AppDBcontext context)
        {
            _context = context;
        }

        public void AddProducto(ProductoVM producto)
        {
            var _producto = new Producto()
            {
                ID = producto.ID,
                Nombre = producto.Nombre,
                Descripccion = producto.Descripccion,
                Precio = producto.Precio,
                Stock = producto.Stock
            };
            _context.Productos.Add(_producto);
            _context.SaveChanges();
        }

        public List<Producto> GetAllProductos() => _context.Productos.ToList();

    }
}
