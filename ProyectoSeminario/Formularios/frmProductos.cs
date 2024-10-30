using Microsoft.Extensions.DependencyInjection;
using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Servicios.Interfaces;
using ProyectoSeminario.Windows.Helpers;
using System.Windows.Forms;

namespace ProyectoSeminario.Windows.Formularios
{
    public partial class frmProductos : Form
    {
        private List<ProductoListDto> lista = null!;
        private readonly IServiciosProductos? _servicio;
        private readonly IServiceProvider? _serviceProvider;

        private int currentPage = 1;//pagina actual
        private int totalPages = 0;//total de paginas
        private int pageSize = 10;//registros por página
        private int totalRecords = 0;//cantidad de registros

        private Func<ProductoListDto, bool>? filter = null;
        public frmProductos(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            if (serviceProvider == null)
            {
                throw new ApplicationException("Dependencias no cargadas");
            }
            _serviceProvider = serviceProvider;
            _servicio = serviceProvider?.GetService<IServiciosProductos>()
                ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                totalRecords = _servicio!.GetCantidad(filter);
                totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                LoadData(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MostrarDatosEnGrilla(List<ProductoListDto> lista)
        {
            GridHelper.LimpiarGrilla(dgvDatos);
            if (lista is not null)
            {
                foreach (var c in lista)
                {
                    var r = GridHelper.ConstruirFila(dgvDatos);
                    GridHelper.SetearFila(r, c);
                    GridHelper.AgregarFila(dgvDatos, r);
                }

            }
        }

        private void LoadData(Func<ProductoListDto, bool>? filter = null)
        {
            try
            {
                lista = _servicio!.GetLista(currentPage, pageSize, filter);
                if (lista.Count > 0)
                {
                    MostrarDatosEnGrilla(lista);
                    if (cboPaginas.Items.Count != totalPages)
                    {
                        CombosHelper.CargarComboPaginas(ref cboPaginas, totalPages);
                    }
                    txtCantidadPaginas.Text = totalPages.ToString();
                    cboPaginas.SelectedIndexChanged -= cboPaginas_SelectedIndexChanged;
                    cboPaginas.SelectedIndex = currentPage == 1 ? 0 : currentPage - 1;
                    cboPaginas.SelectedIndexChanged += cboPaginas_SelectedIndexChanged;

                }
                else
                {
                    MessageBox.Show("No se encontraron registros!!!", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("No hay registros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    currentPage = 1;
                    filter = null;
                    tsbFiltrar.Enabled = true;
                    tsbFiltrar.BackColor = SystemColors.Control;
                    RecargarGrilla();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cboPaginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = int.Parse(cboPaginas.Text);
            LoadData(filter);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData(filter);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData(filter);
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData(filter);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            LoadData(filter);
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            frmProductosAE frm = new frmProductosAE();
            frm.ShowDialog();
        }

        //private void tsbNuevo_Click(object sender, EventArgs e)
        //{

        //    frmEmpleadosAE frm = new frmEmpleadosAE(_serviceProvider) { Text = "Agregar Empleado" };
        //    DialogResult dr = frm.ShowDialog(this);
        //    if (dr == DialogResult.Cancel) return;
        //    Empleado? empleado = frm.GetEmpleado();
        //    if (empleado is null) return;
        //    try
        //    {
        //        if (_servicio is null)
        //        {
        //            throw new ApplicationException("Dependencias no cargadas");
        //        }
        //        _servicio.Guardar(empleado);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}


        //private void tsbActualizar_Click(object sender, EventArgs e)
        //{
        //    filter = null;
        //    currentPage = 1;
        //    tsbFiltrar.Enabled = true;
        //    tsbFiltrar.BackColor = SystemColors.Control;
        //    RecargarGrilla();
        //}


        //private void tsbFiltrar_Click(object sender, EventArgs e)
        //{
        //    frmFiltroTexto frm = new frmFiltroTexto() { Text = "Ingresar texto para buscar por apellido" };
        //    DialogResult dr = frm.ShowDialog(this);
        //    try
        //    {
        //        var textoFiltro = frm.GetTexto();
        //        if (textoFiltro is null || textoFiltro == string.Empty)
        //        {
        //            return;
        //        }
        //        filter = e => e.Apellido.ToUpper()
        //            .Contains(textoFiltro.ToUpper());
        //        totalRecords = _servicio!.GetCantidad(filter);
        //        currentPage = 1;
        //        if (totalRecords > 0)
        //        {
        //            totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
        //            tsbFiltrar.Enabled = false;
        //            tsbFiltrar.BackColor = Color.Orange;

        //            LoadData(filter);

        //        }
        //        else
        //        {

        //            MessageBox.Show("No se encontraron registros!!!", "Mensaje",
        //                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            filter = null;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
    }
}
