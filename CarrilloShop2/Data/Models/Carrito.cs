namespace CarrilloShop2.Data.Models
{
    public class Carrito
    {
        public string CarritoID { get; set; }


        public string CliCorreo { get; set; }
        public Cliente Cliente { get; set; } 
    }
}
