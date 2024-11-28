using CarrilloShop2.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrilloShop2.Data.ViewModel
{
    public class ClienteVM
    {
        public string CliCorreo { get; set; }
        public string CliNombre { get; set; }
        public string CliApellidos { get; set; }
        public string CliTelefono { get; set; }
        public string CliCelular { get; set; }
        public string CliDir { get; set; }
        public DateTime CliFechReg { get; set; }

        public Carrito Carrito { get; set; }
    }
}
