using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valkimia.Domain.Models
{
    public class Ciudad
    {
        public Ciudad()
        {
            Clientes = new HashSet<Cliente>();
        }

        public Guid Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
