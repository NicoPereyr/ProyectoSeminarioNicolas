using Microsoft.Extensions.DependencyInjection;
using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using ProyectoSeminario.Windows.Helpers;

namespace ProyectoSeminario.Windows.Formularios
{
    public partial class frmProductos : Form
    {
        private List<ProductoListDto> lista = null!;
        private readonly IServiciosProductos? _servicio;
        private readonly IServiceProvider? _serviceProvider;

        private int currentPage = 1;//pagina actual
        private int totalPages = 0;//total de paginas
        private int pageSize = 14;//registros por página
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
            frmProductosAE frm = new frmProductosAE(_serviceProvider)
            { Text = "Agregar producto" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            try
            {
                Producto producto = frm.GetProducto();

                if (!_servicio!.Existe(producto))
                {
                    _servicio!.Guardar(producto);
                    totalRecords = _servicio?.GetCantidad() ?? 0;
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    //Preguntar a Carlos sobre línea de abajo
                    currentPage = 1;
                    LoadData();

                    MessageBox.Show("Registro agregado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Registro Duplicado!!!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmFiltroTexto frm = new frmFiltroTexto() { Text = "Ingresar texto para buscar por producto" };
            DialogResult dr = frm.ShowDialog(this);
            try
            {
                var textoFiltro = frm.GetTexto();
                if (textoFiltro is null || textoFiltro == string.Empty)
                {
                    return;
                }
                filter = (e => e.Nombre.ToUpper()

                    .Contains(textoFiltro.ToUpper()) || (e.NombreCategoria.ToUpper().Contains(textoFiltro.ToUpper())));
                totalRecords = _servicio!.GetCantidad(filter);
                currentPage = 1;
                if (totalRecords > 0)
                {
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    tsbBuscar.Enabled = false;
                    LoadData(filter);
                }
                else
                {
                    MessageBox.Show("No se encontraron registros!!!", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    filter = null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void tsbRefrescar_Click(object sender, EventArgs e)
        {
            filter = null;
            currentPage = 1;
            tsbBuscar.Enabled = true;
            tsbFiltrar.Enabled = true;
            RecargarGrilla();
        }

        private void tsbDesactivar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag is null) return;
            var producto = (ProductoListDto)r.Tag;

            try
            {
                DialogResult dr = MessageBox.Show($@"¿Desea desactivar el producto {producto.Nombre}?",
                        "Confirmar desactivación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    _servicio!.Desactivar(producto.ProductoId);
                    LoadData();
                    MessageBox.Show("Registro desactivado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

            }
        }

        private void tsbActivar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag is null) return;
            var producto = (ProductoListDto)r.Tag;

            try
            {
                DialogResult dr = MessageBox.Show($@"¿Desea activar el producto {producto.Nombre}?",
                        "Confirmar activación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    _servicio!.Activar(producto.ProductoId);
                    LoadData();
                    MessageBox.Show("Registro activado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            try
            {
                var r = dgvDatos.SelectedRows[0];
                if (r.Tag != null)
                {
                    var productoDto = (ProductoListDto)r.Tag;

                    frmProductosAE frm = new frmProductosAE(_serviceProvider) { Text = "Editar producto" };
                    frm.SetProductoDto(productoDto);
                    DialogResult dr = frm.ShowDialog(this);

                    if (dr == DialogResult.Cancel)
                    {
                        return;
                    }

                    var productoEditado = frm.GetProducto();

                    if (productoEditado == null)
                    {
                        throw new Exception("Error al recuperar la categoría editada.");
                    }

                    productoEditado.Nombre = productoEditado.Nombre;

                    if (!_servicio!.Existe(productoEditado))
                    {
                        _servicio.Editar(productoEditado);

                        GridHelper.SetearFila(r, productoDto);
                        LoadData();
                        MessageBox.Show("Producto editado",
                            "Mensaje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro existente\nEdición denegada",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar el producto: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


    }
}