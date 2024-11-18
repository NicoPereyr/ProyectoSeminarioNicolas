using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;

namespace ProyectoSeminario.Servicios.Interfaces
{
    public interface IServiciosProductos
    {
        void Desactivar(int productoId);
        void Activar(int productoId);
        void Editar(Producto productoEditado);
        bool Existe(Producto producto);
        List<ProductoListDto> GetLista(int currentPage, int pageSize, Func<ProductoListDto, bool>? filter = null);
        void Guardar(Producto producto);
        Producto? GetProductoPorId(int productoId);
        int GetCantidad(Func<ProductoListDto, bool>? filter = null);
    }
}
