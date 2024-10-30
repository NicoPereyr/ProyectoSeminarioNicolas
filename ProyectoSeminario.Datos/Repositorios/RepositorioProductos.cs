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
            throw new NotImplementedException();
        }

        public void Borrar(int ProductoId, SqlConnection conn, SqlTransaction? tran = null)
        {
            throw new NotImplementedException();
        }

        public void Editar(Producto producto, SqlConnection conn, SqlTransaction? tran = null)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Producto producto, SqlConnection conn, SqlTransaction? tran = null)
        {
            throw new NotImplementedException();
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
            string selectQuery = @"SELECT ProductoId, Nombre, Descripcion, PrecioVenta, Activo, CategoriaId
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
                 @"SELECT p.ProductoId, p.Nombre, p.Descripcion, p.PrecioVenta, p.Activo, p.CategoriaId, c.NombreCategoria
          FROM Productos p
          LEFT JOIN Categorias c ON p.CategoriaId = c.CategoriaId";

            var lista = conn.Query<ProductoListDto, CategoriaListDto, ProductoListDto>(
                selectQuery,
                (producto, categoria) =>
                {
                    // Concatenacion de los campos relacionados con la dirección
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
