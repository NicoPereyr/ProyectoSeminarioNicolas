
using ProyectoSeminario.Datos.Interfaces;
using ProyectoSeminario.Entidades.Entidades;
using ProyectoSeminario.Servicios.Interfaces;

namespace ProyectoSeminario.Servicios.Servicios
{
    public class ServiciosVentas : IServiciosVentas
    {
        private readonly IRepositorioVentas _repositorioVentas;
        private readonly IRepositorioProductos _repositorioProductos;
        private readonly IRepositorioEmpleados _repositorioEmpleados;

        public ServiciosVentas(
            IRepositorioVentas repositorioVentas,
            IRepositorioProductos repositorioProductos,
            IRepositorioEmpleados repositorioEmpleados)
        {
            _repositorioVentas = repositorioVentas;
            _repositorioProductos = repositorioProductos;
            _repositorioEmpleados = repositorioEmpleados;
        }

        public void Guardar(Venta venta)
        {
            if (venta == null)
                throw new ArgumentNullException(nameof(venta));

            if (venta.VentaId != 0)
                throw new Exception("No se puede registrar una venta existente.");

            // Validar empleado
            var empleado = _repositorioEmpleados
                .GetEmpleadoPorId(venta.EmpleadoId);

            if (empleado == null || !empleado.Activo)
                throw new Exception(
                    "Debe seleccionar un empleado activo.");

            // Validar detalles
            if (venta.Detalles == null || !venta.Detalles.Any())
                throw new Exception(
                    "La venta debe contener al menos un producto.");

            decimal total = 0;

            foreach (var detalle in venta.Detalles)
            {
                if (detalle.Cantidad <= 0)
                    throw new Exception(
                        "La cantidad debe ser mayor a cero.");

                var producto = _repositorioProductos
                    .GetProductoPorId(detalle.ProductoId);

                if (producto == null || !producto.Activo)
                    throw new Exception(
                        "El producto no existe o está inactivo.");

                // Obtener precio real del producto
                detalle.PrecioUnitario = producto.PrecioVenta;

                // Calcular subtotal
                detalle.Subtotal =
                    detalle.Cantidad * detalle.PrecioUnitario;

                total += detalle.Subtotal;
            }

            venta.FechaVenta = DateTime.Now;
            venta.Total = total;
            venta.Anulada = false;

            _repositorioVentas.Agregar(venta);
        }

        public Venta? GetVentaPorId(int ventaId)
        {
            return _repositorioVentas.GetVentaPorId(ventaId);
        }

        public List<Venta> GetLista()
        {
            return _repositorioVentas.GetLista();
        }

        public void Anular(int ventaId)
        {
            _repositorioVentas.Anular(ventaId);
        }
    }
}
