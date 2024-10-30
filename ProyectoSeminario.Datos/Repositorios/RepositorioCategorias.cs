using Dapper;
using ProyectoSeminario.Datos.Interfaces;
using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using System.Data.SqlClient;

namespace ProyectoSeminario.Datos.Repositorios
{
    public class RepositorioCategorias : IRepositorioCategorias
    {
        public void Agregar(Categoria categoria, SqlConnection conn, SqlTransaction? tran = null)
        {
            var insertQuery = @"INSERT INTO Categorias (NombreCategoria, Activa) VALUES 
                        (@NombreCategoria, @Activa); 
                        SELECT CAST(SCOPE_IDENTITY() as int)";

            int primaryKey = conn.QuerySingle<int>(insertQuery, new
            {
                NombreCategoria = categoria.NombreCategoria,
                Activa = categoria.Activa
            }, tran);

            if (primaryKey > 0)
            {
                categoria.CategoriaId = primaryKey;
                return;
            }
            throw new Exception("No se pudo agregar");

        }

        public void Desactivar(int categoriaId, SqlConnection conn)
        {
            try
            {
                var updateQuery = @"UPDATE Categorias SET 
                        Activa = 0 WHERE categoriaId = @CategoriaId";

                int registrosAfectados = conn.Execute(updateQuery, new
                {
                    @CategoriaId = categoriaId,
                });

                if (registrosAfectados == 0)
                {
                    throw new Exception("No se pudo desactivar");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo desactivar, la categoría contiene productos.", ex);
            }
        }

        public void Activar(int categoriaId, SqlConnection conn)
        {
            try
            {
                var updateQuery = @"UPDATE Categorias SET 
                        Activa = 1 WHERE categoriaId = @CategoriaId";

                int registrosAfectados = conn.Execute(updateQuery, new
                {
                    @CategoriaId = categoriaId,
                });

                if (registrosAfectados == 0)
                {
                    throw new Exception("No se pudo activar");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo activar", ex);
            }
        }

        public void Editar(Categoria categoriaEditada, SqlConnection conn, SqlTransaction? tran = null)
        {
            string updateQuery = @"UPDATE Categorias SET NombreCategoria=@NombreCategoria 
                                    WHERE CategoriaId=@CategoriaId";

            int registrosAfectados = conn.Execute(updateQuery, categoriaEditada, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo editar la categoria");
            }
        }

        public bool Existe(Categoria categoria, SqlConnection conn, SqlTransaction? tran = null)
        {
            var selectQuery = "SELECT COUNT(*) FROM Categorias WHERE NombreCategoria = @NombreCategoria";
            if (categoria.CategoriaId != 0)
            {
                selectQuery += " AND CategoriaId<>@CategoriaId";
            }

            return conn.QuerySingle<int>(selectQuery, categoria) > 0;
        }

        public int GetCantidad(SqlConnection conn, Func<CategoriaListDto, bool>? filter = null, SqlTransaction? tran = null)
        {
            var selectQuery = @"SELECT c.CategoriaId, c.NombreCategoria, c.Activa
                          FROM Categorias c";
            var query = conn.Query<CategoriaListDto>(selectQuery).ToList();
            if (filter != null)
            {
                query = query.Where(filter).ToList();
            }
            return query.Count;
        }

        public int GetCategoriaIdIfExists(Categoria categoria, SqlConnection conn, SqlTransaction? tran = null)
        {
            var selectQuery = @"SELECT CategoriaId FROM Categorias 
                WHERE NombreCategoria = @NombreCategoria";
            return conn.ExecuteScalar<int>(selectQuery, categoria, tran);
        }

        public Categoria? GetCategoriaPorId(int categoriaId, SqlConnection conn, SqlTransaction? tran = null)
        {
            var query = "SELECT * FROM Categorias WHERE CategoriaId = @CategoriaId";
            return conn.QuerySingleOrDefault<Categoria>(query, new { CategoriaId = categoriaId }, tran);
        }

        public List<CategoriaListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Func<CategoriaListDto, bool>? filter = null, SqlTransaction? tran = null)
        {
            var selectQuery =
                 @"SELECT c.CategoriaId, c.NombreCategoria, c.Activa
                          FROM Categorias c";

            var lista = conn.Query<CategoriaListDto>(
                selectQuery,
                transaction: tran
            ).ToList();

            if (filter != null)
            {
                lista = lista.Where(filter).ToList();
            }

            return lista.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }

        public List<Categoria> GetProductosPorCategoriaId(int categoriaId, SqlConnection conn, SqlTransaction? tran = null)
        {
            var query = @"
            SELECT p.Nombre, p.PrecioVenta 
            FROM Categorias c
            JOIN Productos p ON c.CategoriaId = p.CategoriaId
            WHERE p.CategoriaId = 2 AND p.Activo = 1";
            return conn.Query<Categoria>(query, new { CategoriaId = categoriaId }, tran).ToList();
        }

        public bool EstaRelacionada(int categoriaId, SqlConnection conn)
        {
            try
            {
                var selectQuery = @"SELECT COUNT(*) FROM Productos 
                WHERE CategoriaId=@CategoriaId";
                return conn.QuerySingle<int>
                    (selectQuery, new { @CategoriaId = categoriaId }) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el repo", ex);
            }
        }
    }
}
