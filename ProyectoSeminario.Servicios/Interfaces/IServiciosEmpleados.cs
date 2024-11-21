using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;

namespace ProyectoSeminario.Servicios.Interfaces
{
    public interface IServiciosEmpleados
    {
        void Desactivar(int empleadoId);
        void Activar(int empleadoId);

        bool Existe(Empleado empleado);
        List<Empleado> GetLista(int currentPage, int pageSize, Func<Empleado, bool>? filter = null);
        void Guardar(Empleado empleado);
        Empleado? GetEmpleadoPorId(int empleadoId);
        int GetCantidad(Func<Empleado, bool>? filter = null);
        void Editar(Empleado empleadoEditado);

    }
}
