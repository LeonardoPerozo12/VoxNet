using System.ComponentModel.DataAnnotations;

namespace VoxNet.Models
{
    public class Comprobante
    {
        [Key]
        public int IdTipoComprobante { get; set; }
        public string? tipoComprobante { get; set; }
    }
}
