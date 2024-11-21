using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;

namespace ProyectoSeminario.Servicios.Interfaces
{
    public interface IServiciosCategorias
    {
        void Desactivar(int categoriaId);
        void Activar(int categoriaId);
        bool Existe(Categoria categoria);
        List<Categoria> GetLista(int currentPage, int pageSize, Func<Categoria, bool>? filter = null);
        void Guardar(Categoria categoria);
        Categoria? GetCategoriaPorId(int categoriaId);
        int GetCantidad(Func<Categoria, bool>? filter = null);
        List<Categoria>GetCategoriasActivasComboBox();
        bool EstaRelacionada(int categoriaId);
        void Editar(Categoria categoriaEditada);
    }
}
