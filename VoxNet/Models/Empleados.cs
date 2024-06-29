using System.ComponentModel.DataAnnotations;

namespace VoxNet.Models
{
    public class Empleados
    {
        [Key]
        public int IdEmpleado { get; set; }
        public string? NombreEmpleado { get; set; }
        public string? ApellidoEmpleado { get; set; }
        public string? PasswordEmpleado { get; set; }
        public int IdRol { get; set; }
    }
}
