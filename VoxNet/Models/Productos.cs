using System.ComponentModel.DataAnnotations;

namespace VoxNet.Models
{
    public class Productos
    {
        [Key]
        public int IdProductos { get; set; }

        public string? NombreProducto { get; set; }
        public string? DescripcionProducto { get; set; }
        public float PrecioProdcuto { get; set; }
        public int DisponibilidadProdcuto { get; set; }
        public int IdCategoriaProducto { get; set; }

    }
}
