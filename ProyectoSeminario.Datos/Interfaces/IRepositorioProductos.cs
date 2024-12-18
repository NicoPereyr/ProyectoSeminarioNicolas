﻿using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using System.Data.SqlClient;

namespace ProyectoSeminario.Datos.Interfaces
{
    public interface IRepositorioProductos
    {

        void Desactivar(int ProductoId, SqlConnection conn, SqlTransaction? tran = null);
        void Activar(int ProductoId, SqlConnection conn, SqlTransaction? tran = null);
        void Agregar(Producto producto, SqlConnection conn, SqlTransaction? tran = null);

        bool Existe(Producto producto, SqlConnection conn, SqlTransaction? tran = null);

        void Editar(Producto producto, SqlConnection conn, SqlTransaction? tran = null);
        Producto? GetProductoPorId(int productoId, SqlConnection conn);
        List<ProductoListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Func<ProductoListDto, bool>? filter = null, SqlTransaction? tran = null);
        int GetCantidad(SqlConnection conn, Func<ProductoListDto, bool>? filter = null, SqlTransaction? tran = null);
    }
}
