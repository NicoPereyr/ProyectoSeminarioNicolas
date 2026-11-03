
using Microsoft.EntityFrameworkCore;
using ProyectoSeminario.Datos.DbContext;
using ProyectoSeminario.Datos.Interfaces;
using ProyectoSeminario.Entidades.Entidades;

namespace ProyectoSeminario.Datos.Repositorios
{
    public class RepositorioCategorias : IRepositorioCategorias
    {
        private readonly ProyectoSeminarioDbContext _context;

        public RepositorioCategorias(ProyectoSeminarioDbContext context)
        {
            _context = context;
        }

        public void Agregar(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
        }

        public void Editar(Categoria categoria)
        {
            var categoriaDb = _context.Categorias
                .Find(categoria.CategoriaId);

            if (categoriaDb == null)
            {
                throw new Exception("No se encontró la categoría");
            }

            categoriaDb.NombreCategoria = categoria.NombreCategoria;

            _context.SaveChanges();
        }

        public void Activar(int categoriaId)
        {
            var categoria = _context.Categorias.Find(categoriaId);

            if (categoria == null)
            {
                throw new Exception("No se encontró la categoría");
            }

            categoria.Activa = true;
            _context.SaveChanges();
        }

        public void Desactivar(int categoriaId)
        {
            var categoria = _context.Categorias.Find(categoriaId);

            if (categoria == null)
            {
                throw new Exception("No se encontró la categoría");
            }

            categoria.Activa = false;
            _context.SaveChanges();
        }

        public bool Existe(Categoria categoria)
        {
            return _context.Categorias.Any(c =>
                c.NombreCategoria == categoria.NombreCategoria &&
                c.CategoriaId != categoria.CategoriaId);
        }

        public int GetCantidad(Func<Categoria, bool>? filter = null)
        {
            var lista = _context.Categorias
                .AsNoTracking()
                .AsEnumerable();

            if (filter != null)
            {
                lista = lista.Where(filter);
            }

            return lista.Count();
        }

        public List<Categoria> GetLista(
            int currentPage,
            int pageSize,
            Func<Categoria, bool>? filter = null)
        {
            if (currentPage < 1 || pageSize < 1)
            {
                throw new ArgumentException(
                    "La página y su tamaño deben ser mayores a cero");
            }

            var lista = _context.Categorias
                .AsNoTracking()
                .OrderBy(c => c.CategoriaId)
                .AsEnumerable();

            if (filter != null)
            {
                lista = lista.Where(filter);
            }

            return lista
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public int GetCategoriaIdIfExists(Categoria categoria)
        {
            return _context.Categorias
                .Where(c => c.NombreCategoria == categoria.NombreCategoria)
                .Select(c => c.CategoriaId)
                .FirstOrDefault();
        }

        public Categoria? GetCategoriaPorId(int categoriaId)
        {
            return _context.Categorias
                .AsNoTracking()
                .FirstOrDefault(c => c.CategoriaId == categoriaId);
        }

        public List<Categoria> GetProductosPorCategoriaId(int categoriaId)
        {
            // Se conserva el tipo de retorno de la interfaz original.
            // Más adelante revisaremos si debe devolver productos.
            return _context.Categorias
                .AsNoTracking()
                .Where(c => c.CategoriaId == categoriaId &&
                    _context.Productos.Any(p =>
                        p.CategoriaId == categoriaId && p.Activo))
                .ToList();
        }

        public bool EstaRelacionada(int categoriaId)
        {
            return _context.Productos
                .Any(p => p.CategoriaId == categoriaId);
        }

        public List<Categoria> GetCategoriasActivasComboBox()
        {
            return _context.Categorias
                .AsNoTracking()
                .Where(c => c.Activa)
                .OrderBy(c => c.NombreCategoria)
                .ToList();
        }
    }
}
