using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using CarrilloShop2.Data.ViewModel;
using CarrilloShop2.Data.Services;

namespace CarrilloShop2.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        public ProductoService _productoService;

        public ProductoController(ProductoService productoService)
        {
            _productoService = productoService;
        }


        [HttpGet("get-all-Productos")]
        public IActionResult GetAllProductos()
        {
            var allbooks = _productoService.GetAllProductos();
            return Ok(allbooks);
        }

        [HttpPost("add-Producto")]
        public IActionResult AddProducto([FromBody] ProductoVM producto)
        {
            _productoService.AddProducto(producto);
            return Ok();
        }










    }
}