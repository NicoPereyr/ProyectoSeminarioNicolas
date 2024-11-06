using Microsoft.Extensions.DependencyInjection;
using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ProyectoSeminario.Windows.Formularios
{
    public partial class frmEmpleadosAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosEmpleados? _servicio;

        private Empleado? empleado;

        public frmEmpleadosAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            if (serviceProvider == null)
            {
                throw new ApplicationException("Dependencias no cargadas");
            }
            _serviceProvider = serviceProvider;
            _servicio = _serviceProvider?.GetService<IServiciosEmpleados>()
                ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (empleado is null)
                {
                    empleado = new Empleado();
                }
                empleado.Nombre = txtNombre.Text;
                empleado.Apellido = txtApellido.Text;
                empleado.Documento = int.Parse(txtDocumento.Text);
                empleado.PorcentajeComision = int.Parse(txtPorcentajeComision.Text);
                empleado.Activo = true;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtNombre.Text) 
                || !System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z]+(?:\s[a-zA-Z]+$^"))
            {
                valido = false;
                errorProvider1.SetError(txtNombre, "Nombre del empleado es requerido");
            }
            if (string.IsNullOrEmpty(txtApellido.Text) 
                || !System.Text.RegularExpressions.Regex.IsMatch(txtApellido.Text, @"^[a-zA-Z]+(?:\s[a-zA-Z]+$^"))
            {
                valido = false;
                errorProvider1.SetError(txtApellido, "Apellido del empleado es requerido");
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDocumento.Text,@"\d{8}$") 
                || !int.TryParse(txtDocumento.Text, out _))
            {
                valido = false;
                errorProvider1.SetError(txtDocumento, "Documento inválido");
            }
            if (string.IsNullOrEmpty(txtPorcentajeComision.Text)
                || !int.TryParse(txtPorcentajeComision.Text, out var comision)
                || comision<0 || comision>100)
            {
                valido = false;
                errorProvider1.SetError(txtPorcentajeComision, "Porcentaje de comisión es requerido");
            }


            return valido;
        }

        public void SetEmpleado(Empleado empleado)
        {
            this.empleado = empleado;
        }
        public Empleado? GetEmpleado()
        {
            return empleado;
        }

        public void SetEmpleadoDto(EmpleadoListDto empleadoDto)
        {
            this.empleado = new Empleado
            {
                EmpleadoId = empleadoDto.EmpleadoId,
                Nombre = empleadoDto.Nombre,
                Apellido = empleadoDto.Apellido,
                Documento = empleadoDto.Documento,
                PorcentajeComision = empleadoDto.PorcentajeComision,
                Activo = true // O toma el valor correspondiente si lo tienes en el DTO
            };
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Si el objeto ya está en la grilla, toma los datos de ahí y los muestra en frmAE
            if (empleado != null)
            {
                txtNombre.Text = empleado.Nombre;
                txtApellido.Text = empleado.Apellido;
                txtDocumento.Text = empleado.Documento.ToString();
                txtPorcentajeComision.Text = empleado.PorcentajeComision.ToString();
            }
        }
    }
}
