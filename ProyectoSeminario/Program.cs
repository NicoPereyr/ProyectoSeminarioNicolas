using ProyectoSeminario.IoC;
using ProyectoSeminario.Windows.Formularios;

namespace ProyectoSeminario
{
    internal static class Program
    {
        private static IServiceProvider? _serviceProvider;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _serviceProvider = DI.ConfigurarServicios();
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMenuPrincipal(_serviceProvider));
        }
    }
}