
namespace ProyectoSeminario.Entidades.Entidades
{
    public class Venta
    {
        public int VentaId { get; set; }

        public DateTime FechaVenta { get; set; }

        public int EmpleadoId { get; set; }

        public decimal Total { get; set; }

        public bool Anulada { get; set; }

        public Empleado? Empleado { get; set; }

        public List<DetalleVenta> Detalles { get; set; } = new();
    }
}
