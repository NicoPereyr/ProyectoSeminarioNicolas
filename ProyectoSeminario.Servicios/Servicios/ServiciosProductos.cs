using ProyectoSeminario.Datos.Interfaces;
using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using System.Data.SqlClient;

namespace ProyectoSeminario.Servicios.Servicios
{
    public class ServiciosProductos : IServiciosProductos
    {
        private readonly IRepositorioProductos? _repositorioProductos;
        private readonly string? _cadena;
        public ServiciosProductos(IRepositorioProductos? repositorio, string? cadena)
        {
            _repositorioProductos = repositorio ?? throw new ApplicationException("Dependencias no cargadas!!!");
            _cadena = cadena;
        }

        public void Borrar(int productoId)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Producto producto)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad(Func<ProductoListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioProductos!.GetCantidad(conn, filter);
            }
        }

        public List<ProductoListDto> GetLista(int currentPage, int pageSize, Func<ProductoListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioProductos.GetLista(conn, currentPage, pageSize, filter);
            }
        }

        public Producto? GetProductoPorId(int productoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                var producto = _repositorioProductos.GetProductoPorId(productoId, conn);
                return producto;
            }
        }

        public void Guardar(Producto producto)
        {
            throw new NotImplementedException();
        }
    }
}
