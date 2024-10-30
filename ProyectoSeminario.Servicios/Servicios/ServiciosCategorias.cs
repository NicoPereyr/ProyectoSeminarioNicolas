using ProyectoSeminario.Datos.Interfaces;
using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using System.Data.SqlClient;

namespace ProyectoSeminario.Servicios.Servicios
{
    public class ServiciosCategorias : IServiciosCategorias
    {
        private readonly IRepositorioCategorias? _repositorioCategorias;
        private readonly string? _cadena;
        public ServiciosCategorias(IRepositorioCategorias? repositorio, string? cadena)
        {
            _repositorioCategorias = repositorio ?? throw new ApplicationException("Dependencias no cargadas!!!");
            _cadena = cadena;
        }

        public void Desactivar(int categoriaId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                        _repositorioCategorias!.Desactivar(categoriaId, conn);
                    
            }
        }

        public void Activar(int categoriaId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                _repositorioCategorias!.Activar(categoriaId, conn);

            }
        }

        public bool Existe(Categoria categoria)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioCategorias!.Existe(categoria, conn);
            }
        }

        public int GetCantidad(Func<CategoriaListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioCategorias!.GetCantidad(conn, filter);
            }
        }

        public List<CategoriaListDto> GetLista(int currentPage, int pageSize, Func<CategoriaListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioCategorias.GetLista(conn, currentPage, pageSize, filter);
            }
        }

        public Categoria? GetCategoriaPorId(int categoriaId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                var categoria = _repositorioCategorias.GetCategoriaPorId(categoriaId, conn);
                return categoria;
            }
        }

        public void Guardar(Categoria categoria)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (categoria.CategoriaId == 0)
                        {
                            _repositorioCategorias!.Agregar(categoria, conn, tran);
                        }

                        tran.Commit();//guarda efectivamente
                    }
                    catch (Exception)
                    {
                        tran.Rollback();//tira todo pa tras!!!
                        throw;
                    }
                }
            }
        }

        public bool EstaRelacionada(int categoriaId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioCategorias!.EstaRelacionada(categoriaId, conn);

            }

        }
        public void Editar(Categoria categoriaEditada)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (categoriaEditada.CategoriaId == 0)
                        {
                            _repositorioCategorias!.Agregar(categoriaEditada, conn, tran);
                        }
                        else
                        {
                            _repositorioCategorias!.Editar(categoriaEditada, conn, tran);
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
