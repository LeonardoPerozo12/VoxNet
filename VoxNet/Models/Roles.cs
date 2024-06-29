using System.ComponentModel.DataAnnotations;

namespace VoxNet.Models
{
    public class Roles
    {
        [Key]
        public int IdRol { get; set; }
        public string? NombreRol { get; set; }
    }
}
