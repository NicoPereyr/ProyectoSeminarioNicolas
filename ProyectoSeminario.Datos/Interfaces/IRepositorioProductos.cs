
using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;

namespace ProyectoSeminario.Datos.Interfaces
{
    public interface IRepositorioProductos
    {
        void Agregar(Producto producto);

        void Editar(Producto producto);

        void Activar(int productoId);

        void Desactivar(int productoId);

        bool Existe(Producto producto);

        Producto? GetProductoPorId(int productoId);

        List<ProductoListDto> GetLista(
            int currentPage,
            int pageSize,
            Func<ProductoListDto, bool>? filter = null);

        int GetCantidad(
            Func<ProductoListDto, bool>? filter = null);
    }
}
