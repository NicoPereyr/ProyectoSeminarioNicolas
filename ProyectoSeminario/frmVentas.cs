
using Microsoft.Extensions.DependencyInjection;
using ProyectoSeminario.Servicios.Interfaces;

namespace ProyectoSeminario.Windows
{
    public partial class frmVentas : Form
    {
        private readonly IServiciosEmpleados _servicioEmpleados;
        private readonly IServiciosProductos _servicioProductos;

        public frmVentas(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _servicioEmpleados = serviceProvider
                .GetRequiredService<IServiciosEmpleados>();
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


        private void frmVentas_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            dtpFechaVenta.Value = DateTime.Now;
        }

    }

}
