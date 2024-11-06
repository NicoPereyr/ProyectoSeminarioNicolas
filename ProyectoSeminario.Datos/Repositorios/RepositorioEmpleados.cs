using Dapper;
using ProyectoSeminario.Datos.Interfaces;
using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using System.Data.SqlClient;
using System.Linq;

namespace ProyectoSeminario.Datos.Repositorios
{
    public class RepositorioEmpleados : IRepositorioEmpleados
    {
        public void Agregar(Empleado empleado, SqlConnection conn, SqlTransaction? tran = null)
        {
            var insertQuery = @"INSERT INTO Empleados (Nombre, Apellido, Activo, Documento, PorcentajeComision) VALUES 
                        (@Nombre, @Apellido, @Activo, @Documento, @PorcentajeComision); 
                        SELECT CAST(SCOPE_IDENTITY() as int)";

            int primaryKey = conn.QuerySingle<int>(insertQuery, new
            {
                Nombre = empleado.Nombre,
                Apellido = empleado.Apellido,
                Documento = empleado.Documento,
                PorcentajeComision=empleado.PorcentajeComision,
                Activo = empleado.Activo
            }, tran);

            if (primaryKey > 0)
            {
                empleado.EmpleadoId = primaryKey;
                return;
            }
            throw new Exception("No se pudo agregar");

        }


        public void Editar(Empleado empleadoEditado, SqlConnection conn, SqlTransaction? tran = null)
        {
            string updateQuery = @"UPDATE Empleados SET Nombre=@Nombre, Apellido=@Apellido, Documento=@Documento, PorcentajeComision=@PorcentajeComision 
                                    WHERE EmpleadoId=@EmpleadoId";

            int registrosAfectados = conn.Execute(updateQuery, empleadoEditado, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo editar el empleado");
            }
        }

        public bool Existe(Empleado empleado, SqlConnection conn, SqlTransaction? tran = null)
        {
            var selectQuery = "SELECT COUNT(*) FROM Empleados WHERE Documento= @Documento";
            if (empleado.EmpleadoId != 0)
            {
                selectQuery += " AND EmpleadoId<>@EmpleadoId";
            }

            return conn.QuerySingle<int>(selectQuery, empleado) > 0;
        }

        public int GetCantidad(SqlConnection conn, Func<EmpleadoListDto, bool>? filter = null, SqlTransaction? tran = null)
        {
            var selectQuery = @"SELECT * FROM Empleados";
            var query = conn.Query<EmpleadoListDto>(selectQuery).ToList();
            if (filter != null)
            {
                query = query.Where(filter).ToList();
            }
            return query.Count;
        }

        public Empleado? GetEmpleadoPorId(int empleadoId, SqlConnection conn)
        {
            string selectQuery = @"SELECT EmpleadoId, Nombre, Apellido, Activo 
                FROM Empleados 
                WHERE EmpleadoId=@EmpleadoId";
            var empleado = conn.QuerySingleOrDefault<Empleado>(selectQuery, new { @EmpleadoId = empleadoId });

            // Si el cliente no existe, retornamos null
            if (empleado == null)
            {
                return null;
            }
            return empleado;
        }

        public List<EmpleadoListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Func<EmpleadoListDto, bool>? filter = null, SqlTransaction? tran = null)
        {
            var selectQuery =
                 @"SELECT e.EmpleadoId, e.Nombre, e.Apellido, e.Activo, e.Documento, e.PorcentajeComision
                          FROM Empleados e";

            var lista = conn.Query<EmpleadoListDto>(
                selectQuery,
                transaction: tran
            ).ToList();

            if (filter != null)
            {
                lista = lista.Where(filter).ToList();
            }

            return lista.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }
        public void Desactivar(int empleadoId, SqlConnection conn)
        {
            try
            {
                var updateQuery = @"UPDATE Empleados SET 
                        Activo = 0 WHERE empleadoId = @EmpleadoId";

                int registrosAfectados = conn.Execute(updateQuery, new
                {
                    @EmpleadoId = empleadoId,
                });

                if (registrosAfectados == 0)
                {
                    throw new Exception("No se pudo desactivar");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo desactivar, la categoría contiene productos.", ex);
            }
        }

        public void Activar(int empleadoId, SqlConnection conn)
        {
            try
            {
                var updateQuery = @"UPDATE Empleados SET 
                        Activo = 1 WHERE empleadoId = @EmpleadoId";

                int registrosAfectados = conn.Execute(updateQuery, new
                {
                    @EmpleadoId = empleadoId,
                });

                if (registrosAfectados == 0)
                {
                    throw new Exception("No se pudo activar");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo activar", ex);
            }
        }

    }
}
