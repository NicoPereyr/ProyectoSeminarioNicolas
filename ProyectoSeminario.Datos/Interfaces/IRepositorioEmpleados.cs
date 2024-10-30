using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using System.Data.SqlClient;

namespace ProyectoSeminario.Datos.Interfaces
{
    public interface IRepositorioEmpleados
    {

        void Agregar(Empleados empleado, SqlConnection conn, SqlTransaction? tran = null);

        bool Existe(Empleados empleado, SqlConnection conn, SqlTransaction? tran = null);

        void Editar(Empleados empleado, SqlConnection conn, SqlTransaction? tran = null);
        Empleados? GetEmpleadoPorId(int empleadoId, SqlConnection conn);
        List<EmpleadoListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Func<EmpleadoListDto, bool>? filter = null, SqlTransaction? tran = null);
        int GetCantidad(SqlConnection conn, Func<EmpleadoListDto, bool>? filter = null, SqlTransaction? tran = null);


    }
}
