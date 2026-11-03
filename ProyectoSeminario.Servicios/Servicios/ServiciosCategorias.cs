
using ProyectoSeminario.Datos.Interfaces;
using ProyectoSeminario.Entidades.Entidades;
using ProyectoSeminario.Servicios.Interfaces;

namespace ProyectoSeminario.Servicios.Servicios
{
    public class ServiciosCategorias : IServiciosCategorias
    {
        private readonly IRepositorioCategorias _repositorioCategorias;

        public ServiciosCategorias(IRepositorioCategorias repositorio)
        {
            _repositorioCategorias = repositorio
                ?? throw new ArgumentNullException(nameof(repositorio));
        }

        public void Desactivar(int categoriaId)
        {
            _repositorioCategorias.Desactivar(categoriaId);
        }

        public void Activar(int categoriaId)
        {
            _repositorioCategorias.Activar(categoriaId);
        }

        public bool Existe(Categoria categoria)
        {
            return _repositorioCategorias.Existe(categoria);
        }

        public int GetCantidad(Func<Categoria, bool>? filter = null)
        {
            return _repositorioCategorias.GetCantidad(filter);
        }

        public List<Categoria> GetLista(
            int currentPage,
            int pageSize,
            Func<Categoria, bool>? filter = null)
        {
            return _repositorioCategorias.GetLista(
                currentPage, pageSize, filter);
        }

        public Categoria? GetCategoriaPorId(int categoriaId)
        {
            return _repositorioCategorias.GetCategoriaPorId(categoriaId);
        }

        public void Guardar(Categoria categoria)
        {
            if (categoria.CategoriaId == 0)
            {
                _repositorioCategorias.Agregar(categoria);
            }
            else
            {
                _repositorioCategorias.Editar(categoria);
            }
        }

        public void Editar(Categoria categoriaEditada)
        {
            _repositorioCategorias.Editar(categoriaEditada);
        }

        public bool EstaRelacionada(int categoriaId)
        {
            return _repositorioCategorias.EstaRelacionada(categoriaId);
        }

        public List<Categoria> GetCategoriasActivasComboBox()
        {
            return _repositorioCategorias.GetCategoriasActivasComboBox();
        }
    }
}
