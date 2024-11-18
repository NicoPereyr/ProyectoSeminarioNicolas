using ProyectoSeminario.Datos.Interfaces;
using ProyectoSeminario.Datos.Repositorios;
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

        public void Desactivar(int productoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                _repositorioProductos!.Desactivar(productoId, conn);

            }
        }

        public void Activar(int productoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                _repositorioProductos!.Activar(productoId, conn);

            }
        }

        public bool Existe(Producto producto)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioProductos!.Existe(producto, conn);
            }
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
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (producto.ProductoId == 0)
                        {
                            _repositorioProductos!.Agregar(producto, conn, tran);
                        }
                        else
                        {
                            _repositorioProductos!.Editar(producto, conn, tran);
                        }

                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Editar(Producto productoEditado)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (productoEditado.ProductoId == 0)
                        {
                            _repositorioProductos!.Agregar(productoEditado, conn, tran);
                        }
                        else
                        {
                            _repositorioProductos!.Editar(productoEditado, conn, tran);
                        }
                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
