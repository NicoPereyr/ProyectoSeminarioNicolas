
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ProyectoSeminario.Datos.DbContext
{
    public class ProyectoSeminarioDbContextFactory
        : IDesignTimeDbContextFactory<ProyectoSeminarioDbContext>
    {
        public ProyectoSeminarioDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder =
                new DbContextOptionsBuilder<ProyectoSeminarioDbContext>();

            optionsBuilder.UseSqlServer(
                @"Server=.\SQLEXPRESS;Database=ProyectoSeminarioEF;Trusted_Connection=True;TrustServerCertificate=True;");

            return new ProyectoSeminarioDbContext(optionsBuilder.Options);
        }
    }
}

