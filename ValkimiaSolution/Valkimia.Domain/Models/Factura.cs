#nullable disable

namespace Valkimia.Domain.Models
{
    public class Factura
    {
        public Guid Id { get; set; }
        public Guid IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalle { get; set; } = null!;
        
        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
