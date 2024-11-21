using Microsoft.Extensions.DependencyInjection;
using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using ProyectoSeminario.Servicios.Interfaces;

namespace ProyectoSeminario.Windows.Formularios
{

    public partial class frmCategoriasAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosCategorias? _servicio;

        private Categoria? categoria;

        public frmCategoriasAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            if (serviceProvider == null)
            {
                throw new ApplicationException("Dependencias no cargadas");
            }
            _serviceProvider = serviceProvider;
            _servicio = _serviceProvider?.GetService<IServiciosCategorias>()
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
                if (categoria is null)
                {
                    categoria = new Categoria();
                }
                categoria.NombreCategoria = txtNombreCategoria.Text;
                categoria.Activa = true;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtNombreCategoria.Text))
            {
                valido = false;
                errorProvider1.SetError(txtNombreCategoria, "Nombre de categoria es requerido");
            }
            return valido;
        }

        public void SetCategoria(Categoria categoria)
        {
            this.categoria = categoria;
        }
        public Categoria? GetCategoria()
        {
            return categoria;
        }

        public void SetCategoriaDto(Categoria categoriaDto)
        {
            this.categoria = new Categoria
            {
                CategoriaId = categoriaDto.CategoriaId,
                NombreCategoria = categoriaDto.NombreCategoria,
                Activa = true // O toma el valor correspondiente si lo tienes en el DTO
            };
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Si el objeto ya está en la grilla, toma los datos de ahí y los muestra en frmAE
            if (categoria != null)
            {
                txtNombreCategoria.Text = categoria.NombreCategoria;
            }
        }
    }
}
