using System;

namespace CarrilloShop2.Data.Models
{
    public class Cliente
    {
        public string CliCorreo { get; set; }
        public string CliNombre { get; set; }
        public string CliApellidos { get; set; }
        public string CliTelefono { get; set; }
        public string CliCelular { get; set; }
        public string CliDir { get; set; }
        public DateTime CliFechReg { get; set; }
        public int CliAntiguedad { get; set; } // Propiedad calculada

        public Carrito Carrito { get; set; }
    }
}