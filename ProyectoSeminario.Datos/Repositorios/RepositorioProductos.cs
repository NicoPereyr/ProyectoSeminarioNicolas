
using Microsoft.EntityFrameworkCore;
using ProyectoSeminario.Datos.DbContext;
using ProyectoSeminario.Datos.Interfaces;
using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;

namespace ProyectoSeminario.Datos.Repositorios
{
    public class RepositorioProductos : IRepositorioProductos
    {
        private readonly ProyectoSeminarioDbContext _context;

        public RepositorioProductos(ProyectoSeminarioDbContext context)
        {
            _context = context;
        }

        public void Agregar(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        public void Editar(Producto producto)
        {
            var productoDb = _context.Productos
                .Find(producto.ProductoId);

            if (productoDb == null)
            {
                throw new Exception("No se encontró el producto");
            }

            productoDb.Nombre = producto.Nombre;
            productoDb.Descripcion = producto.Descripcion;
            productoDb.PrecioVenta = producto.PrecioVenta;
            productoDb.Imagen = producto.Imagen;
            productoDb.CategoriaId = producto.CategoriaId;

            _context.SaveChanges();
        }

        public void Activar(int productoId)
        {
            var producto = _context.Productos.Find(productoId);

            if (producto == null)
            {
                throw new Exception("No se encontró el producto");
            }

            producto.Activo = true;
            _context.SaveChanges();
        }

        public void Desactivar(int productoId)
        {
            var producto = _context.Productos.Find(productoId);

            if (producto == null)
            {
                throw new Exception("No se encontró el producto");
            }

            producto.Activo = false;
            _context.SaveChanges();
        }

        public bool Existe(Producto producto)
        {
            return _context.Productos.Any(p =>
                p.Nombre == producto.Nombre &&
                p.ProductoId != producto.ProductoId);
        }

        public Producto? GetProductoPorId(int productoId)
        {
            return _context.Productos
                .AsNoTracking()
                .FirstOrDefault(p => p.ProductoId == productoId);
        }

        public int GetCantidad(
            Func<ProductoListDto, bool>? filter = null)
        {
            var lista = ObtenerProductosDto();

            if (filter != null)
            {
                lista = lista.Where(filter);
            }

            return lista.Count();
        }

        public List<ProductoListDto> GetLista(
            int currentPage,
            int pageSize,
            Func<ProductoListDto, bool>? filter = null)
        {
            if (currentPage < 1 || pageSize < 1)
            {
                throw new ArgumentException(
                    "La página y su tamaño deben ser mayores a cero");
            }

            var lista = ObtenerProductosDto();

            if (filter != null)
            {
                lista = lista.Where(filter);
            }

            return lista
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        private IEnumerable<ProductoListDto> ObtenerProductosDto()
        {
            return _context.Productos
                .AsNoTracking()
                .OrderBy(p => p.ProductoId)
                .Select(p => new ProductoListDto
                {
                    ProductoId = p.ProductoId,
                    Nombre = p.Nombre,
                    Descripcion = p.Descripcion,
                    PrecioVenta = p.PrecioVenta,
                    Activo = p.Activo,
                    Imagen = p.Imagen,
                    CategoriaId = p.CategoriaId,
                    NombreCategoria = p.Categoria != null
                        ? p.Categoria.NombreCategoria
                        : string.Empty
                })
                .AsEnumerable();
        }
    }
}
