
using Microsoft.Extensions.DependencyInjection;
using ProyectoSeminario.Servicios.Interfaces;

namespace ProyectoSeminario.Windows.Formularios
{
    public partial class frmHistorialVentas : Form
    {
        private readonly IServiciosVentas _servicioVentas;

        public frmHistorialVentas(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _servicioVentas = serviceProvider
                .GetRequiredService<IServiciosVentas>();
        }

        private void CargarVentas()
        {
            var ventas = _servicioVentas.GetLista()
                .Select(v => new
                {
                    v.VentaId,
                    Fecha = v.FechaVenta.ToString("dd/MM/yyyy HH:mm"),
                    Empleado = v.Empleado != null
                        ? $"{v.Empleado.Apellido}, {v.Empleado.Nombre}"
                        : "Sin empleado",
                    v.Total,
                    Estado = v.Anulada ? "Anulada" : "Activa"
                })
                .ToList();

            dgvVentas.DataSource = null;
            dgvVentas.DataSource = ventas;

            // Ocultar identificador interno
            dgvVentas.Columns["VentaId"].Visible = false;

            // Encabezados
            dgvVentas.Columns["Fecha"].HeaderText = "Fecha y hora";
            dgvVentas.Columns["Empleado"].HeaderText = "Empleado";
            dgvVentas.Columns["Total"].HeaderText = "Total";
            dgvVentas.Columns["Estado"].HeaderText = "Estado";

            // Formato monetario
            dgvVentas.Columns["Total"].DefaultCellStyle.Format = "C2";
            dgvVentas.Columns["Total"].DefaultCellStyle.FormatProvider =
                System.Globalization.CultureInfo.GetCultureInfo("es-AR");

            dgvVentas.ClearSelection();
        }

        private void frmHistorialVentas_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }


        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow == null ||
                dgvVentas.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Seleccioná una venta para ver sus detalles.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int ventaId = Convert.ToInt32(
                dgvVentas.CurrentRow.Cells["VentaId"].Value);

            var venta = _servicioVentas.GetVentaPorId(ventaId);

            if (venta == null)
            {
                MessageBox.Show(
                    "No se encontró la venta seleccionada.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string mensaje = $"Venta N° {venta.VentaId}\n";
            mensaje += $"Fecha: {venta.FechaVenta:dd/MM/yyyy HH:mm}\n";
            mensaje += $"Empleado: {venta.Empleado?.Apellido}, {venta.Empleado?.Nombre}\n";
            mensaje += $"Estado: {(venta.Anulada ? "Anulada" : "Activa")}\n";
            mensaje += "\nPRODUCTOS VENDIDOS\n";
            mensaje += "--------------------------------\n";

            foreach (var detalle in venta.Detalles)
            {
                mensaje += $"{detalle.Producto?.Nombre}\n";
                mensaje += $"Cantidad: {detalle.Cantidad}\n";
                mensaje += $"Precio: ${detalle.PrecioUnitario:N2}\n";
                mensaje += $"Subtotal: ${detalle.Subtotal:N2}\n\n";
            }

            mensaje += "--------------------------------\n";
            mensaje += $"TOTAL: ${venta.Total:N2}";

            MessageBox.Show(
                mensaje,
                "Detalle de venta",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        private void btnAnularVenta_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow == null ||
                dgvVentas.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Seleccioná una venta para anular.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int ventaId = Convert.ToInt32(
                dgvVentas.CurrentRow.Cells["VentaId"].Value);

            var venta = _servicioVentas.GetVentaPorId(ventaId);

            if (venta == null)
            {
                MessageBox.Show(
                    "No se encontró la venta seleccionada.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (venta.Anulada)
            {
                MessageBox.Show(
                    "Esta venta ya se encuentra anulada.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var respuesta = MessageBox.Show(
                $"¿Estás seguro de anular la venta N° {ventaId}?",
                "Confirmar anulación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                _servicioVentas.Anular(ventaId);

                MessageBox.Show(
                    "La venta fue anulada correctamente.",
                    "Operación realizada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo anular la venta:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FiltrarVentas()
        {
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;

            if (desde > hasta)
            {
                MessageBox.Show(
                    "La fecha inicial no puede ser mayor que la fecha final.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var ventas = _servicioVentas.GetLista()
                .Where(v => v.FechaVenta.Date >= desde &&
                            v.FechaVenta.Date <= hasta)
                .Select(v => new
                {
                    v.VentaId,
                    Fecha = v.FechaVenta.ToString("dd/MM/yyyy HH:mm"),
                    Empleado = v.Empleado != null
                        ? $"{v.Empleado.Apellido}, {v.Empleado.Nombre}"
                        : "Sin empleado",
                    v.Total,
                    Estado = v.Anulada ? "Anulada" : "Activa"
                })
                .ToList();

            dgvVentas.DataSource = null;
            dgvVentas.DataSource = ventas;

            dgvVentas.Columns["VentaId"].Visible = false;
            dgvVentas.Columns["Fecha"].HeaderText = "Fecha y hora";
            dgvVentas.Columns["Empleado"].HeaderText = "Empleado";
            dgvVentas.Columns["Total"].HeaderText = "Total";
            dgvVentas.Columns["Estado"].HeaderText = "Estado";

            dgvVentas.Columns["Total"].DefaultCellStyle.Format = "C2";
            dgvVentas.Columns["Total"].DefaultCellStyle.FormatProvider =
                System.Globalization.CultureInfo.GetCultureInfo("es-AR");

            dgvVentas.ClearSelection();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarVentas();
        }

        private void btnMostrarTodas_Click(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo actualizar el historial:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }

}

