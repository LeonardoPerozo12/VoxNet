using System.ComponentModel.DataAnnotations;

namespace VoxNet.Models
{
    public class Contratos
    {
        [Key]
        public int IdContrato { get; set; }
        public DateTime FechaInicioContrato { get; set; }
        public DateTime FechaFinContrato { get; set; }
        public string? DescripcionContrato { get; set; }
        public int EstadoContrato { get; set; }
        public int IdCliente {  get; set; }
        public int IdServicio { get; set; }
    }
}
