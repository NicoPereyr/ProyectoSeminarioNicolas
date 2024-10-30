using Microsoft.Extensions.DependencyInjection;
using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                empleado.Activo = true;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                valido = false;
                errorProvider1.SetError(txtNombre, "Nombre del empleado es requerido");
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
            }
        }
    }
}
