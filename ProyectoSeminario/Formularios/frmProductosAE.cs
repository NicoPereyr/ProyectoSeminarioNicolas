using Microsoft.Extensions.DependencyInjection;
using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using ProyectoSeminario.Windows.Helpers;

namespace ProyectoSeminario.Windows.Formularios
{
    public partial class frmProductosAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosProductos? _servicio;

        private string imagenNoDisponible = Environment.CurrentDirectory + @"\Imágenes\SinImagenDisponible.jpg";
        private string archivoNoEncontrado = Environment.CurrentDirectory + @"\Imágenes\ArchivoNoEncontrado.jpg";
        private string? archivoImagen = string.Empty;
        private string carpetaImagen = Environment.CurrentDirectory + @"\Imágenes\";

        private Producto? producto;
        private Categoria? categoriaSeleccionada;

        public frmProductosAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            if (serviceProvider == null)
            {
                throw new ApplicationException("Dependencias no cargadas");
            }
            _serviceProvider = serviceProvider;
            _servicio = _serviceProvider?.GetService<IServiciosProductos>()
                ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboCategorias(ref cboCategorias, _serviceProvider);
            // Si el objeto ya está en la grilla, toma los datos de ahí y los muestra en frmAE
            if (producto != null)
            {
                txtNombre.Text = producto.Nombre;
                txtDescripcion.Text = producto.Descripcion;
                txtPrecio.Text = producto.PrecioVenta.ToString();
                cboCategorias.SelectedValue = producto.CategoriaId;

                //Veo si el producto tiene alguna imagen asociada
                if (producto.Imagen != string.Empty)
                {
                    //Me aseguro que esa imagen exista
                    if (!File.Exists($"{carpetaImagen}{producto.Imagen}"))
                    {
                        //Si no existe, muestro la imagen de archivo no encontrado
                        picImagen.Image = Image.FromFile(archivoNoEncontrado);
                    }
                    else
                    {
                        //Caso contrario muestro la imagen
                        picImagen.Image = Image.FromFile($"{carpetaImagen}{producto.Imagen}");
                        archivoImagen = producto.Imagen;
                    }
                }
                else
                {
                    //Si no tiene imagen muestro Sin Imagen 
                    picImagen.Image = Image.FromFile(imagenNoDisponible);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (producto is null)
                {
                    producto = new Producto();
                }
                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.PrecioVenta = decimal.Parse(txtPrecio.Text);
                if (cboCategorias.SelectedValue is not null)
                {
                    producto.CategoriaId = (int)cboCategorias.SelectedValue;
                    producto.Categoria = (Categoria)cboCategorias.SelectedItem!;
                    producto.Categoria = categoriaSeleccionada;
                    producto.Activo = true;
                }

                //Veo si el producto tiene alguna imagen asociada
                if (producto.Imagen != string.Empty || producto.Imagen is not null)
                {
                    //Me aseguro que esa imagen exista
                    if (!File.Exists($"{carpetaImagen}{producto.Imagen}"))
                    {
                        //Si no existe, muestro la imagen de archivo no encontrado
                        picImagen.Image = Image.FromFile(archivoNoEncontrado);
                    }
                    else
                    {
                        //Caso contrario muestro la imagen
                        picImagen.Image = Image.FromFile($"{carpetaImagen}{producto.Imagen}");
                        archivoImagen = producto.Imagen;
                    }
                }
                else
                {
                    //Si no tiene imagen muestro Sin Imagen 
                    picImagen.Image = Image.FromFile(imagenNoDisponible);
                }

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
                errorProvider1.SetError(txtNombre, "Nombre de producto es requerido");
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtPrecio.Text)
                || !decimal.TryParse(txtPrecio.Text, out var precio)
                || precio < 0)
            {
                valido = false;
                errorProvider1.SetError(txtPrecio, "Precio no válido");
            }
            if (cboCategorias.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboCategorias, "Debe seleccionar una categoría");
            }
            return valido;
        }

        public void SetProducto(Producto producto)
        {
            this.producto = producto;
        }
        public Producto? GetProducto()
        {
            return producto;
        }

        public void SetProductoDto(ProductoListDto productoDto)
        {
            this.producto = new Producto
            {
                ProductoId = productoDto.ProductoId,
                Nombre = productoDto.Nombre,
                Descripcion = productoDto.Descripcion,
                PrecioVenta = productoDto.PrecioVenta,
                Activo = true,
                Imagen = productoDto.Imagen?.ToString() ?? string.Empty,
                CategoriaId = productoDto.CategoriaId
            };
        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            //Seteo del openFileDialog
            openFileDialog1.Multiselect = false;
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory + @"\Imágenes\";
            openFileDialog1.Filter = @"Archivos jpg (*.jpg) | *.jpg | 
            Archivos png (*.png)  | *.png | 
            Archivos jfif (*.jfif) | *.jfif | 
            Todos (.) | .";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            DialogResult dr = openFileDialog1.ShowDialog(this);//muestro el openFileDialog

            if (dr == DialogResult.OK)
            {
                //Veo si tengo algun imagen seleccionada
                if (openFileDialog1.FileName == null)
                {
                    return;//sino me voy
                }
                //Tomo el nombre del archivo de imagen con su ruta
                //archivoNombreConRuta = openFileDialog1.FileName;
                picImagen.Image = Image.FromFile(openFileDialog1.FileName);
                archivoImagen = openFileDialog1.FileName;//Tomo la ruta y el nombre del archivo
            }
        }


    }
}