
using ProyectoSeminario.Datos.Interfaces;
using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using ProyectoSeminario.Servicios.Interfaces;

namespace ProyectoSeminario.Servicios.Servicios
{
    public class ServiciosProductos : IServiciosProductos
    {
        private readonly IRepositorioProductos _repositorioProductos;

        public ServiciosProductos(IRepositorioProductos repositorio)
        {
            _repositorioProductos = repositorio
                ?? throw new ArgumentNullException(nameof(repositorio));
        }

        public void Desactivar(int productoId)
        {
            _repositorioProductos.Desactivar(productoId);
        }

        public void Activar(int productoId)
        {
            _repositorioProductos.Activar(productoId);
        }

        public bool Existe(Producto producto)
        {
            return _repositorioProductos.Existe(producto);
        }

        public int GetCantidad(
            Func<ProductoListDto, bool>? filter = null)
        {
            return _repositorioProductos.GetCantidad(filter);
        }

        public List<ProductoListDto> GetLista(
            int currentPage,
            int pageSize,
            Func<ProductoListDto, bool>? filter = null)
        {
            return _repositorioProductos.GetLista(
                currentPage, pageSize, filter);
        }

        public Producto? GetProductoPorId(int productoId)
        {
            return _repositorioProductos.GetProductoPorId(productoId);
        }

        public void Guardar(Producto producto)
        {
            if (producto.ProductoId == 0)
            {
                _repositorioProductos.Agregar(producto);
            }
            else
            {
                _repositorioProductos.Editar(producto);
            }
        }

        public void Editar(Producto productoEditado)
        {
            if (productoEditado.ProductoId == 0)
            {
                _repositorioProductos.Agregar(productoEditado);
            }
            else
            {
                _repositorioProductos.Editar(productoEditado);
            }
        }
    }
}
