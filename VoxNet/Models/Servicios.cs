using System.ComponentModel.DataAnnotations;

namespace VoxNet.Models
{
    public class Servicios
    {
        [Key]
        public int IdServicios { get; set; }
        public string? NombreServicios { get; set; }
        public string? DescripcionServicios { get; set; }
        public float PrecioServicios { get; set; }

    }
}
