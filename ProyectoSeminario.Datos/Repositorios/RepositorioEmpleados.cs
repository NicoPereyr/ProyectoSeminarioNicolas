
using Microsoft.EntityFrameworkCore;
using ProyectoSeminario.Datos.DbContext;
using ProyectoSeminario.Datos.Interfaces;
using ProyectoSeminario.Entidades.Entidades;

namespace ProyectoSeminario.Datos.Repositorios
{
    public class RepositorioEmpleados : IRepositorioEmpleados
    {
        private readonly ProyectoSeminarioDbContext _context;

        public RepositorioEmpleados(ProyectoSeminarioDbContext context)
        {
            _context = context;
        }

        public void Agregar(Empleado empleado)
        {
            _context.Empleados.Add(empleado);
            _context.SaveChanges();
        }

        public void Editar(Empleado empleado)
        {
            var empleadoDb = _context.Empleados.Find(empleado.EmpleadoId);

            if (empleadoDb == null)
            {
                throw new Exception("No se encontró el empleado");
            }

            empleadoDb.Nombre = empleado.Nombre;
            empleadoDb.Apellido = empleado.Apellido;
            empleadoDb.Documento = empleado.Documento;
            empleadoDb.PorcentajeComision = empleado.PorcentajeComision;
            empleadoDb.Sexo = empleado.Sexo;

            _context.SaveChanges();
        }

        public void Activar(int empleadoId)
        {
            var empleado = _context.Empleados.Find(empleadoId);

            if (empleado == null)
                throw new Exception("No se encontró el empleado");

            empleado.Activo = true;
            _context.SaveChanges();
        }

        public void Desactivar(int empleadoId)
        {
            var empleado = _context.Empleados.Find(empleadoId);

            if (empleado == null)
                throw new Exception("No se encontró el empleado");

            empleado.Activo = false;
            _context.SaveChanges();
        }

        public bool Existe(Empleado empleado)
        {
            return _context.Empleados.Any(e =>
                e.Documento == empleado.Documento &&
                e.EmpleadoId != empleado.EmpleadoId);
        }

        public Empleado? GetEmpleadoPorId(int empleadoId)
        {
            return _context.Empleados
                .AsNoTracking()
                .FirstOrDefault(e => e.EmpleadoId == empleadoId);
        }

        public int GetCantidad(Func<Empleado, bool>? filter = null)
        {
            var lista = _context.Empleados
                .AsNoTracking()
                .AsEnumerable();

            if (filter != null)
                lista = lista.Where(filter);

            return lista.Count();
        }

        public List<Empleado> GetLista(
            int currentPage,
            int pageSize,
            Func<Empleado, bool>? filter = null)
        {
            if (currentPage < 1 || pageSize < 1)
                throw new ArgumentException(
                    "La página y el tamaño deben ser mayores a cero");

            var lista = _context.Empleados
                .AsNoTracking()
                .OrderBy(e => e.EmpleadoId)
                .AsEnumerable();

            if (filter != null)
                lista = lista.Where(filter);

            return lista
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
    }
}
