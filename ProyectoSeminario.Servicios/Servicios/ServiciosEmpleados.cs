using ProyectoSeminario.Datos.Interfaces;
using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using System.Data.SqlClient;

namespace ProyectoSeminario.Servicios.Servicios
{
    public class ServiciosEmpleados : IServiciosEmpleados
    {

        private readonly IRepositorioEmpleados _repositorioEmpleados;
        private readonly string _cadena;

        public ServiciosEmpleados(
            IRepositorioEmpleados repositorioEmpleados,
            string cadena)
        {
            _repositorioEmpleados = repositorioEmpleados;
            _cadena = cadena;
        }

        public void Borrar(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Empleados empleado)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad(Func<EmpleadoListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioEmpleados!.GetCantidad(conn, filter);
            }
        }

        public Empleados? GetEmpleadoPorId(int empleadoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                var empleado = _repositorioEmpleados.GetEmpleadoPorId(empleadoId, conn);
                return empleado;
            }
        }

        public List<EmpleadoListDto> GetLista(int currentPage, int pageSize, Func<EmpleadoListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioEmpleados.GetLista(conn, currentPage, pageSize, filter);
            }
        }

        public void Guardar(Empleados empleado)
        {
            throw new NotImplementedException();
        }
    }
}
