using Microsoft.EntityFrameworkCore;
using Valkimia.Domain.Models;
#nullable disable

namespace Valkimia.Persistence
{
    public class ValkimiaContext : DbContext
    {
        public ValkimiaContext()
        {
        }

        public ValkimiaContext(DbContextOptions<ValkimiaContext> options) : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Ciudad> Ciudades { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        //    modelBuilder.Entity<Cliente>(entity => 
        //    {
        //        entity.ToTable("Cliente");

        //        entity.Property<>
        //    })
        //}
    }
}