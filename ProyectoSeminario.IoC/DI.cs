using ProyectoSeminario.Datos.Interfaces;
using ProyectoSeminario.Datos.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using ProyectoSeminario.Servicios.Interfaces;
using ProyectoSeminario.Servicios.Servicios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProyectoSeminario.Datos.DbContext;


namespace ProyectoSeminario.IoC
{
    public static class DI
    {
        public static IServiceProvider ConfigurarServicios()
        {
            var service = new ServiceCollection();
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var connectionString = configuration
                .GetConnectionString("ProyectoSeminarioConnection");

            service.AddDbContext<ProyectoSeminarioDbContext>(options =>
                options.UseSqlServer(connectionString));


            var cadena = System.Configuration.ConfigurationManager
                .ConnectionStrings["MiConexion"].ToString();

            service.AddScoped<IRepositorioProductos, RepositorioProductos>();
            service.AddScoped<IRepositorioCategorias, RepositorioCategorias>();
            service.AddScoped<IRepositorioEmpleados, RepositorioEmpleados>();


            service.AddScoped<IServiciosProductos, ServiciosProductos>();

            service.AddScoped<IServiciosCategorias, ServiciosCategorias>();


            service.AddScoped<IServiciosEmpleados, ServiciosEmpleados>();

            return service.BuildServiceProvider();
        }
    }
}
