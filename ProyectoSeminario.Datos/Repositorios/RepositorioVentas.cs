
using Microsoft.EntityFrameworkCore;
using ProyectoSeminario.Datos.DbContext;
using ProyectoSeminario.Datos.Interfaces;
using ProyectoSeminario.Entidades.Entidades;

namespace ProyectoSeminario.Datos.Repositorios
{
    public class RepositorioVentas : IRepositorioVentas
    {
        private readonly ProyectoSeminarioDbContext _context;

        public RepositorioVentas(ProyectoSeminarioDbContext context)
        {
            _context = context;
        }

        public void Agregar(Venta venta)
        {
            _context.Ventas.Add(venta);
            _context.SaveChanges();
        }

        public Venta? GetVentaPorId(int ventaId)
        {
            return _context.Ventas
                .AsNoTracking()
                .Include(v => v.Empleado)
                .Include(v => v.Detalles)
                    .ThenInclude(d => d.Producto)
                .FirstOrDefault(v => v.VentaId == ventaId);
        }

        public List<Venta> GetLista()
        {
            return _context.Ventas
                .AsNoTracking()
                .Include(v => v.Empleado)
                .OrderByDescending(v => v.FechaVenta)
                .ThenByDescending(v => v.VentaId)
                .ToList();
        }

        public void Anular(int ventaId)
        {
            var venta = _context.Ventas.Find(ventaId);

            if (venta == null)
            {
                throw new Exception("No se encontró la venta");
            }

            if (venta.Anulada)
            {
                throw new Exception("La venta ya se encuentra anulada");
            }

            venta.Anulada = true;
            _context.SaveChanges();
        }
    }
}
