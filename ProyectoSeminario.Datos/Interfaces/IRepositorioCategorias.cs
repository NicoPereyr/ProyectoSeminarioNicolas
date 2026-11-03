
using ProyectoSeminario.Entidades.Entidades;

namespace ProyectoSeminario.Datos.Interfaces
{
    public interface IRepositorioCategorias
    {
        void Agregar(Categoria categoria);

        void Editar(Categoria categoria);

        void Activar(int categoriaId);

        void Desactivar(int categoriaId);

        bool Existe(Categoria categoria);

        int GetCantidad(
            Func<Categoria, bool>? filter = null);

        List<Categoria> GetLista(
            int currentPage,
            int pageSize,
            Func<Categoria, bool>? filter = null);

        int GetCategoriaIdIfExists(Categoria categoria);

        Categoria? GetCategoriaPorId(int categoriaId);

        List<Categoria> GetProductosPorCategoriaId(
            int categoriaId);

        bool EstaRelacionada(int categoriaId);

        List<Categoria> GetCategoriasActivasComboBox();
    }
}
