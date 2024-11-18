using Dapper;
using ProyectoSeminario.Datos.Interfaces;
using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using System.Data.SqlClient;

namespace ProyectoSeminario.Datos.Repositorios
{
    public class RepositorioProductos : IRepositorioProductos
    {
        public void Agregar(Producto producto, SqlConnection conn, SqlTransaction? tran = null)
        {
            int primaryKey = -1;
            string insertQuery = @"INSERT INTO Productos (Nombre, Descripcion, PrecioVenta, Activo, Imagen, CategoriaId) 
        VALUES(@Nombre, @Descripcion, @PrecioVenta, @Activo, @Imagen, @CategoriaId); SELECT CAST(SCOPE_IDENTITY() as int)";

            primaryKey = conn.QuerySingle<int>(insertQuery, producto, tran);
            if (primaryKey > 0)
            {
                producto.ProductoId = primaryKey;
                return;
            }

            throw new Exception("No se pudo agregar el producto");
        }

        public void Desactivar(int productoId, SqlConnection conn, SqlTransaction? tran = null)
        {
            try
            {
                var updateQuery = @"UPDATE Productos SET 
                Activo = 0 WHERE productoId = @productoId";

                int registrosAfectados = conn.Execute(updateQuery, new
                {
                    @productoId = productoId,
                });

                if (registrosAfectados == 0)
                {
                    throw new Exception("No se pudo desactivar");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo desactivar", ex);
            }
        }

        public void Activar(int productoId, SqlConnection conn, SqlTransaction? tran = null)
        {
            try
            {
                var updateQuery = @"UPDATE Productos SET 
                Activo = 1 WHERE productoId = @productoId";

                int registrosAfectados = conn.Execute(updateQuery, new
                {
                    @productoId = productoId,
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

        public void Editar(Producto productoEditado, SqlConnection conn, SqlTransaction? tran = null)
        {
            string updateQuery = @"UPDATE Productos SET 
                            Nombre=@Nombre, 
                            Descripcion=@Descripcion,
                            PrecioVenta=@PrecioVenta,
                            Imagen=@Imagen,
                            CategoriaId=@CategoriaId
                            WHERE ProductoId=@ProductoId";

            int registrosAfectados = conn.Execute(updateQuery, productoEditado, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo editar el producto");
            }
        }

        public bool Existe(Producto producto, SqlConnection conn, SqlTransaction? tran = null)
        {
            var selectQuery = "SELECT COUNT(*) FROM Productos WHERE Nombre = @Nombre";
            if (producto.ProductoId != 0)
            {
                selectQuery += " AND ProductoId<>@ProductoId";
            }

            return conn.QuerySingle<int>(selectQuery, producto) > 0;
        }

        public int GetCantidad(SqlConnection conn, Func<ProductoListDto, bool>? filter = null, SqlTransaction? tran = null)
        {
            var selectQuery = @"SELECT p.ProductoId, p.Nombre, c.NombreCategoria, p.PrecioVenta, p.Activo
                  FROM Productos p
                  LEFT JOIN Categorias c ON p.CategoriaId = c.CategoriaId";
            var query = conn.Query<ProductoListDto>(selectQuery).ToList();
            if (filter != null)
            {
                query = query.Where(filter).ToList();
            }
            return query.Count;
        }

        public Producto? GetProductoPorId(int productoId, SqlConnection conn)
        {
            string selectQuery = @"SELECT ProductoId, Nombre, Descripcion, PrecioVenta, Activo, Imagen, CategoriaId
        FROM Productos
        WHERE ProductoId=@ProductoId";
            var producto = conn.QuerySingleOrDefault<Producto>(selectQuery, new { @ProductoId = productoId });

            if (producto == null)
            {
                return null;
            }
            return producto;
        }

        public List<ProductoListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Func<ProductoListDto, bool>? filter = null, SqlTransaction? tran = null)
        {
            var selectQuery =
                 @"SELECT p.ProductoId, p.Nombre, p.Descripcion, p.PrecioVenta, p.Activo, p.Imagen, p.CategoriaId, c.NombreCategoria
  FROM Productos p
  LEFT JOIN Categorias c ON p.CategoriaId = c.CategoriaId";

            var lista = conn.Query<ProductoListDto, Categoria, ProductoListDto>(
                selectQuery,
                (producto, categoria) =>
                {
                    // Concatenacion de los campos relacionados
                    producto.CategoriaId = categoria.CategoriaId;
                    producto.NombreCategoria = $"{categoria.NombreCategoria}";
                    return producto;
                },
                splitOn: "CategoriaId",  // Punto de split
                transaction: tran
            ).ToList();

            if (filter != null)
            {
                lista = lista.Where(filter).ToList();
            }

            return lista.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}
