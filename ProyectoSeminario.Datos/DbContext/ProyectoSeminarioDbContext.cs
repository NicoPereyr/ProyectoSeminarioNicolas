
using Microsoft.EntityFrameworkCore;
using ProyectoSeminario.Entidades.Entidades;

namespace ProyectoSeminario.Datos.DbContext
{
    public class ProyectoSeminarioDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ProyectoSeminarioDbContext(
            DbContextOptions<ProyectoSeminarioDbContext> options)
            : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // CATEGORIAS
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(c => c.CategoriaId);

                entity.Property(c => c.NombreCategoria)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsRequired();
            });

            // PRODUCTOS
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(p => p.ProductoId);

                entity.Property(p => p.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsRequired();

                entity.Property(p => p.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(p => p.PrecioVenta)
                    .HasColumnType("numeric(18,2)");

                entity.Property(p => p.Imagen)
                    .HasColumnType("nvarchar(max)");

                entity.HasOne(p => p.Categoria)
                    .WithMany()
                    .HasForeignKey(p => p.CategoriaId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            // EMPLEADOS
            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.EmpleadoId);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsRequired();

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsRequired();
            });

            // VENTAS
            modelBuilder.Entity<Venta>(entity =>
            {
                entity.HasKey(v => v.VentaId);

                entity.Property(v => v.FechaVenta)
                    .HasColumnType("datetime2");

                entity.Property(v => v.Total)
                    .HasColumnType("decimal(18,2)");

                entity.HasOne(v => v.Empleado)
                    .WithMany()
                    .HasForeignKey(v => v.EmpleadoId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            // DETALLE VENTAS
            modelBuilder.Entity<DetalleVenta>(entity =>
            {
                entity.HasKey(d => d.DetalleVentaId);

                entity.Property(d => d.PrecioUnitario)
                    .HasColumnType("decimal(18,2)");

                entity.Property(d => d.Subtotal)
                    .HasColumnType("decimal(18,2)");

                entity.HasOne(d => d.Venta)
                    .WithMany(v => v.Detalles)
                    .HasForeignKey(d => d.VentaId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Producto)
                    .WithMany()
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

        }
    }
}

