using Microsoft.EntityFrameworkCore.Query.Internal;

namespace CarrilloShop2.Data.Models
{
    public class DetalleCarrito
    {
        public int DetID { get; set; }
        public int CarID { get; set; }
        public int ID {  get; set; }
        public int Cantidad { get; set; }
        public int Cantidade { get; set; }
    }
}
