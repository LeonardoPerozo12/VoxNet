using System.ComponentModel.DataAnnotations;

namespace VoxNet.Models
{
    public class Facturas
    {
        [Key]
        public int IdFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public string? MetodoPagoFactura { get; set; }
        public float ImpuestosFactura { get; set; }
        public float TotalFactura { get; set; }
        public int CantidadFactura { get; set; }
        public int IdSucursal { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public int IdTipoComprobante { get; set; }
    }
}
