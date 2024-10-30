using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeminario.Servicios.Interfaces
{
    public interface IServiciosProductos
    {
        void Borrar(int productoId);
        //bool EstaRelacionado(int productoId);
        bool Existe(Producto producto);
        List<ProductoListDto> GetLista(int currentPage, int pageSize, Func<ProductoListDto, bool>? filter = null);
        void Guardar(Producto producto);
        Producto? GetProductoPorId(int productoId);
        int GetCantidad(Func<ProductoListDto, bool>? filter = null);
    }
}
