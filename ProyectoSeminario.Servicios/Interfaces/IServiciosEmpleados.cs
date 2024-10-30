using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;

namespace ProyectoSeminario.Servicios.Interfaces
{
    public interface IServiciosEmpleados
    {
        bool Existe(Empleados empleado);
        List<EmpleadoListDto> GetLista(int currentPage, int pageSize, Func<EmpleadoListDto, bool>? filter = null);
        void Guardar(Empleados empleado);
        Empleados? GetEmpleadoPorId(int empleadoId);
        int GetCantidad(Func<EmpleadoListDto, bool>? filter = null);
    }
}
