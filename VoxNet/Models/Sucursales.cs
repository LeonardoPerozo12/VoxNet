using System.ComponentModel.DataAnnotations;

namespace VoxNet.Models
{
    public class Sucursales
    {
        [Key]
        public int IdSucursal { get; set; }
        public string? NombreSucursal { get;set; }
        public string? DireccionSucursal { get; set ;}
        public string? TelefenoSucursal { get; set ; }
    }
}
