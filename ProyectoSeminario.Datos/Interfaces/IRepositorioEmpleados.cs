using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using System.Data.SqlClient;

namespace ProyectoSeminario.Datos.Interfaces
{
    public interface IRepositorioEmpleados
    {
        void Desactivar(int EmpleadoId, SqlConnection conn);
        void Activar(int EmpleadoId, SqlConnection conn);
        void Agregar(Empleado empleado, SqlConnection conn, SqlTransaction? tran = null);

        bool Existe(Empleado empleado, SqlConnection conn, SqlTransaction? tran = null);

        void Editar(Empleado empleado, SqlConnection conn, SqlTransaction? tran = null);
        Empleado? GetEmpleadoPorId(int empleadoId, SqlConnection conn);
        List<Empleado> GetLista(SqlConnection conn, int currentPage, int pageSize, Func<Empleado, bool>? filter = null, SqlTransaction? tran = null);
        int GetCantidad(SqlConnection conn, Func<Empleado, bool>? filter = null, SqlTransaction? tran = null);


    }
}
