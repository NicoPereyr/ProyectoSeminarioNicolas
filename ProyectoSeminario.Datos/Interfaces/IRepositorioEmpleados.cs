
using ProyectoSeminario.Entidades.Entidades;

namespace ProyectoSeminario.Datos.Interfaces
{
    public interface IRepositorioEmpleados
    {
        void Agregar(Empleado empleado);

        void Editar(Empleado empleado);

        void Activar(int empleadoId);

        void Desactivar(int empleadoId);

        bool Existe(Empleado empleado);

        Empleado? GetEmpleadoPorId(int empleadoId);

        List<Empleado> GetLista(
            int currentPage,
            int pageSize,
            Func<Empleado, bool>? filter = null);

        int GetCantidad(
            Func<Empleado, bool>? filter = null);
    }
}
