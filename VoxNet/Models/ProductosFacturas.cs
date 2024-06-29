using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VoxNet.Models
{
    public class ProductosFacturas
    {
        public int IdFactura { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
    }
}
