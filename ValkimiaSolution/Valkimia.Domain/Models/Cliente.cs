#nullable disable

namespace Valkimia.Domain.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Domicilio { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public Guid IdCiudad { get; set; }
        public bool Habilitado { get; set; }

        public virtual Ciudad IdCiudadNavigation { get; set; }
    }
}
