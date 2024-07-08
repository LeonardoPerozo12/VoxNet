using System.ComponentModel.DataAnnotations;

namespace VoxNet.Models
{
    public class Productos
    {
        [Key]
        public int IdProductos { get; set; }

        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal PrecioProducto { get; set; }
        public bool DisponibilidadProducto { get; set; } // Cambiado a booleano para reflejar tinyint(1) en MySQL

        public int IdCategoriaProducto { get; set; }
        // Puedes agregar una propiedad de navegación si lo deseas para la relación con la categoría
        // public Categoria Categoria { get; set; }
    }
}
