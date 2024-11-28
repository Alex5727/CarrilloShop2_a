using CarrilloShop2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using CarrilloShop2.Services;
using CarrilloShop2.ViewModel;

namespace CarrilloShop2.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
      


        public ClienteService _clienteservice;

        public ClienteController(ClienteService clienteservice)
        {
            _clienteservice = clienteservice;
        }


        [HttpGet("get-all-Clientes")]
        public IActionResult GetAllBooks()
        {
            var allbooks = _clienteservice.GetAllClt();
            return Ok(allbooks);
        }

        [HttpPost("add-Cliente")]
        public IActionResult AddBook([FromBody] ClienteVM cliente)
        {
            _clienteservice.AddCliente(cliente);
            return Ok();
        }


    }
}