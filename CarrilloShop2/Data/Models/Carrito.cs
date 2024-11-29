namespace CarrilloShop2.Data.Models
{
    public class Carrito
    {
        public int CarritoID { get; set; }

        public int CliID { get; set; }
        public Cliente Cliente { get; set; } 
    }
}
