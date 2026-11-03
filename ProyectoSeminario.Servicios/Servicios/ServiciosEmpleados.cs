
using ProyectoSeminario.Datos.Interfaces;
using ProyectoSeminario.Entidades.Entidades;
using ProyectoSeminario.Servicios.Interfaces;

namespace ProyectoSeminario.Servicios.Servicios
{
    public class ServiciosEmpleados : IServiciosEmpleados
    {
        private readonly IRepositorioEmpleados _repositorioEmpleados;

        public ServiciosEmpleados(IRepositorioEmpleados repositorioEmpleados)
        {
            _repositorioEmpleados = repositorioEmpleados
                ?? throw new ArgumentNullException(nameof(repositorioEmpleados));
        }

        public void Desactivar(int empleadoId)
        {
            _repositorioEmpleados.Desactivar(empleadoId);
        }

        public void Activar(int empleadoId)
        {
            _repositorioEmpleados.Activar(empleadoId);
        }

        public bool Existe(Empleado empleado)
        {
            return _repositorioEmpleados.Existe(empleado);
        }

        public int GetCantidad(Func<Empleado, bool>? filter = null)
        {
            return _repositorioEmpleados.GetCantidad(filter);
        }

        public Empleado? GetEmpleadoPorId(int empleadoId)
        {
            return _repositorioEmpleados.GetEmpleadoPorId(empleadoId);
        }

        public List<Empleado> GetLista(
            int currentPage,
            int pageSize,
            Func<Empleado, bool>? filter = null)
        {
            return _repositorioEmpleados.GetLista(
                currentPage, pageSize, filter);
        }

        public void Guardar(Empleado empleado)
        {
            if (empleado.EmpleadoId == 0)
            {
                _repositorioEmpleados.Agregar(empleado);
            }
            else
            {
                _repositorioEmpleados.Editar(empleado);
            }
        }

        public void Editar(Empleado empleadoEditado)
        {
            if (empleadoEditado.EmpleadoId == 0)
            {
                _repositorioEmpleados.Agregar(empleadoEditado);
            }
            else
            {
                _repositorioEmpleados.Editar(empleadoEditado);
            }
        }
    }
}
