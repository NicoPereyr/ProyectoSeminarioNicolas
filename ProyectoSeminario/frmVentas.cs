
using Microsoft.Extensions.DependencyInjection;
using ProyectoSeminario.Servicios.Interfaces;
using ProyectoSeminario.Entidades.Entidades;
using System.Globalization;

namespace ProyectoSeminario.Windows
{
    public partial class frmVentas : Form
    {
        private readonly IServiciosEmpleados _servicioEmpleados;
        private readonly IServiciosProductos _servicioProductos;

        private readonly List<DetalleVenta> _detallesVenta = new();


        public frmVentas(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _servicioEmpleados = serviceProvider
                .GetRequiredService<IServiciosEmpleados>();
            _servicioProductos = serviceProvider
                .GetRequiredService<IServiciosProductos>();
        }

        private void CargarEmpleados()
        {
            var empleados = _servicioEmpleados
                .GetLista(1, 1000, e => e.Activo)
                .OrderBy(e => e.Apellido)
                .ThenBy(e => e.Nombre)
                .Select(e => new
                {
                    e.EmpleadoId,
                    NombreCompleto = $"{e.Apellido}, {e.Nombre}"
                })
                .ToList();

            cboEmpleados.DataSource = empleados;
            cboEmpleados.DisplayMember = "NombreCompleto";
            cboEmpleados.ValueMember = "EmpleadoId";
            cboEmpleados.SelectedIndex = -1;
        }

        private void CargarProductos()
        {
            var productos = _servicioProductos
                .GetLista(1, 1000, p => p.Activo)
                .OrderBy(p => p.Nombre)
                .Select(p => new
                {
                    p.ProductoId,
                    NombreProducto = $"{p.Nombre} - ${p.PrecioVenta:N2}"
                })
                .ToList();

            cboProductos.DataSource = productos;
            cboProductos.DisplayMember = "NombreProducto";
            cboProductos.ValueMember = "ProductoId";
            cboProductos.SelectedIndex = -1;
        }



        private void frmVentas_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            CargarProductos();

            dtpFechaVenta.Value = DateTime.Now;
            lblTotal.Text = "$0,00";
        }


        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cboProductos.SelectedValue is not int productoId)
            {
                MessageBox.Show(
                    "Seleccioná un producto.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int cantidad = (int)nudCantidad.Value;

            var producto = _servicioProductos.GetProductoPorId(productoId);

            if (producto == null || !producto.Activo)
            {
                MessageBox.Show(
                    "El producto no está disponible.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var detalleExistente = _detallesVenta
                .FirstOrDefault(d => d.ProductoId == productoId);

            if (detalleExistente != null)
            {
                detalleExistente.Cantidad += cantidad;
                detalleExistente.Subtotal =
                    detalleExistente.Cantidad * detalleExistente.PrecioUnitario;
            }
            else
            {
                var detalle = new DetalleVenta
                {
                    ProductoId = producto.ProductoId,
                    Producto = producto,
                    Cantidad = cantidad,
                    PrecioUnitario = producto.PrecioVenta,
                    Subtotal = cantidad * producto.PrecioVenta
                };

                _detallesVenta.Add(detalle);
            }

            ActualizarDetalleVenta();

            cboProductos.SelectedIndex = -1;
            nudCantidad.Value = 1;
        }

        private void ActualizarDetalleVenta()
        {
            dgvDetalleVenta.Rows.Clear();

            foreach (var detalle in _detallesVenta)
            {
                dgvDetalleVenta.Rows.Add(
                    detalle.ProductoId,
                    detalle.Producto?.Nombre,
                    detalle.Cantidad,
                    detalle.PrecioUnitario.ToString("N2"),
                    detalle.Subtotal.ToString("N2")
                );
            }

            decimal total = _detallesVenta.Sum(d => d.Subtotal);


            lblTotal.Text = total.ToString(
                "C2",
                CultureInfo.GetCultureInfo("es-AR"));

        }


        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            if (dgvDetalleVenta.CurrentRow == null ||
                dgvDetalleVenta.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Seleccioná un producto para quitar.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int productoId = Convert.ToInt32(
                dgvDetalleVenta.CurrentRow.Cells["colProductoId"].Value);

            var detalle = _detallesVenta
                .FirstOrDefault(d => d.ProductoId == productoId);

            if (detalle == null)
            {
                MessageBox.Show(
                    "No se encontró el producto seleccionado.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            _detallesVenta.Remove(detalle);

            ActualizarDetalleVenta();
        }

    }

}
