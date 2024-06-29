using Microsoft.EntityFrameworkCore;
using VoxNet.Models;

namespace VoxNet.Context
{
    public class VoxNetContext : DbContext
    {
        public VoxNetContext()
        {
        }
        public VoxNetContext(DbContextOptions<VoxNetContext> options) : base(options)
        {
        }

        public DbSet<Facturas> Facturas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Comprobante> Comprobantes { get; set; }
        public DbSet<Contratos> Contratos { get; set; }
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<ProductosFacturas> ProductosFacturas { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Servicios> Servicios { get; set; }
        public DbSet<Sucursales> Sucursales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductosFacturas>(entity =>
            {
                entity.HasKey(e => new
                {
                    e.IdFactura, e.IdProducto
                });
            });
        }
    }
}
