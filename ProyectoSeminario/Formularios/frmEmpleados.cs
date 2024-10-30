using Microsoft.Extensions.DependencyInjection;
using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using ProyectoSeminario.Windows.Helpers;

namespace ProyectoSeminario.Windows.Formularios
{
    public partial class frmEmpleados : Form
    {
        private List<EmpleadoListDto> lista = null!;
        private readonly IServiciosEmpleados? _servicio;
        private readonly IServiceProvider? _serviceProvider;

        private int currentPage = 1;//pagina actual
        private int totalPages = 0;//total de paginas
        private int pageSize = 10;//registros por página
        private int totalRecords = 0;//cantidad de registros

        private Func<EmpleadoListDto, bool>? filter = null;
        public frmEmpleados(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            if (serviceProvider == null)
            {
                throw new ApplicationException("Dependencias no cargadas");
            }
            _serviceProvider = serviceProvider;
            _servicio = serviceProvider?.GetService<IServiciosEmpleados>()
                ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
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

        private void LoadData(Func<EmpleadoListDto, bool>? filter = null)
        {
            try
            {
                lista = _servicio!.GetLista(currentPage, pageSize);
                if (lista.Count > 0)
                {
                    MostrarDatosEnGrilla(lista);
                    if (cboPaginas.Items.Count != totalPages)
                    {
                        CombosHelper.CargarComboPaginas(ref cboPaginas, totalPages);
                    }
                    txtCantidadPaginas.Text = totalPages.ToString();
                    cboPaginas.SelectedIndexChanged -= cboPaginas_SelectedIndexChanged!;
                    cboPaginas.SelectedIndex = currentPage == 1 ? 0 : currentPage - 1;
                    cboPaginas.SelectedIndexChanged += cboPaginas_SelectedIndexChanged!;

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

        private void MostrarDatosEnGrilla(List<EmpleadoListDto> lista)
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

        private void cboPaginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = int.Parse(cboPaginas.Text);
            LoadData(filter);
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData(filter);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData(filter);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData(filter);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            LoadData(filter);
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            frmCategoriasAE frm = new frmCategoriasAE(_serviceProvider);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                Categoria? categoria = frm.GetCategoria();
                if (categoria is null) return;
                if (!_servicio!.Existe(categoria))
                {
                    _servicio.Guardar(categoria);


                    totalRecords = _servicio?.GetCantidad() ?? 0;
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    //Preguntar a Carlos sobre línea 159
                    currentPage = 1;
                    LoadData();

                    MessageBox.Show("Registro agregado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro existente\nAlta denegada",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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

        private void tsbFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {//Consultar a Carlos
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            try
            {
                var r = dgvDatos.SelectedRows[0];
                if (r.Tag != null)
                {
                    var categoriaDto = (CategoriaListDto)r.Tag;

                    // Crea el formulario para editar la categoría
                    frmCategoriasAE frm = new frmCategoriasAE(_serviceProvider) { Text = "Editar categoria" };
                    frm.SetCategoriaDto(categoriaDto); // Pasa el DTO al formulario
                    DialogResult dr = frm.ShowDialog(this);

                    if (dr == DialogResult.Cancel)
                    {
                        return; // Si se cancela, no hacer nada
                    }

                    // Recupera el objeto actualizado desde el formulario
                    var categoriaEditada = frm.GetCategoria(); // Obtenemos el objeto Categoria

                    if (categoriaEditada == null)
                    {
                        throw new Exception("Error al recuperar la categoría editada.");
                    }

                    // Mapear los cambios de la entidad 'Categoria' al DTO 'CategoriaListDto'
                    categoriaDto.NombreCategoria = categoriaEditada.NombreCategoria;
                    // Aquí puedes mapear cualquier otro campo que necesites mostrar en la grilla

                    // Verifica si la categoría ya existe (probablemente por el nombre o algún otro criterio)
                    if (!_servicio!.Existe(categoriaEditada))
                    {
                        // Si no existe, guarda los cambios en la base de datos
                        _servicio.Editar(categoriaEditada);

                        // Actualiza la fila del DataGridView con el DTO actualizado
                        GridHelper.SetearFila(r, categoriaDto); // Usa el DTO para mostrar en la grilla

                        MessageBox.Show("Categoría editada",
                            "Mensaje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Si ya existe, muestra un error
                        MessageBox.Show("Registro existente\nEdición denegada",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar la categoría: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void tsbDesactivar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag is null) return;
            var categoria = (CategoriaListDto)r.Tag;

            try
            {
                DialogResult dr = MessageBox.Show($@"¿Desea desactivar la categoría {categoria.NombreCategoria}?",
                        "Confirmar desactivación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                if (!_servicio!.EstaRelacionada(categoria.CategoriaId))
                {
                    _servicio!.Desactivar(categoria.CategoriaId);
                    LoadData();
                    MessageBox.Show("Registro desactivado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Registro relacionado\nDesactivación denegada",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

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
            var categoria = (CategoriaListDto)r.Tag;

            try
            {
                DialogResult dr = MessageBox.Show($@"¿Desea activar la categoría {categoria.NombreCategoria}?",
                        "Confirmar activación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    _servicio!.Activar(categoria.CategoriaId);
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
    }
}
