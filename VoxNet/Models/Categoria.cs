using System.ComponentModel.DataAnnotations;

namespace VoxNet.Models
{
    public class Categoria
    {
        [Key]
        public int IdCategoriaProducto { get; set; }
        public string? CategoriaProducto { get; set; }
    }
}
