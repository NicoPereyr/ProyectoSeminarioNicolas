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
        public void Desactivar(int empleadoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                _repositorioEmpleados!.Desactivar(empleadoId, conn);

            }
        }

        public void Activar(int empleadoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                _repositorioEmpleados!.Activar(empleadoId, conn);

            }
        }

        public bool Existe(Empleado empleado)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioEmpleados!.Existe(empleado, conn);
            }
        }

        public int GetCantidad(Func<EmpleadoListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorioEmpleados!.GetCantidad(conn, filter);
            }
        }

        public Empleado? GetEmpleadoPorId(int empleadoId)
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

        public void Guardar(Empleado empleado)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (empleado.EmpleadoId == 0)
                        {
                            _repositorioEmpleados!.Agregar(empleado, conn, tran);
                        }

                        tran.Commit();//guarda efectivamente
                    }
                    catch (Exception)
                    {
                        tran.Rollback();//tira todo pa tras!!!
                        throw;
                    }
                }
            }
        }
        public void Editar(Empleado empleadoEditado)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (empleadoEditado.EmpleadoId == 0)
                        {
                            _repositorioEmpleados!.Agregar(empleadoEditado, conn, tran);
                        }
                        else
                        {
                            _repositorioEmpleados!.Editar(empleadoEditado, conn, tran);
                        }
                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }

        }
    }
}
