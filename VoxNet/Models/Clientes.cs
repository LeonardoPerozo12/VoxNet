using System.ComponentModel.DataAnnotations;

namespace VoxNet.Models
{
    public class Clientes
    {
        [Key]
        public int IdCliente { get; set; }
        public string? NombreCliente { get; set; }
        public string? DireccionCliente { get; set; }
        public string? TelefonoCliente { get; set; }
        public string? CorreoCliente { get; set; }
        public string? CedulaCliente { get; set; }
        public string? PasswordCliente { get; set; }
    }
}
