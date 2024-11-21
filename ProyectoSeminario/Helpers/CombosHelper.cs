using Microsoft.Extensions.DependencyInjection;
using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using ProyectoSeminario.Servicios.Interfaces;

namespace ProyectoSeminario.Windows.Helpers
{
    public static class CombosHelper
    {
        private static IServiceProvider? _serviceProvider;

        public static void CargarComboPaginas(ref ComboBox cbo, int totalPages)
        {
            cbo.Items.Clear();
            for (int i = 1; i <= totalPages; i++)
            {
                cbo.Items.Add(i.ToString());
            }
        }
        public static void CargarComboCategorias(ref ComboBox cbo,
    IServiceProvider? serviceProvider)
        {
            _serviceProvider = serviceProvider;
            IServiciosCategorias? servicio = _serviceProvider?.GetService<IServiciosCategorias>();
            var listaCategorias = servicio?.GetCategoriasActivasComboBox();
            var defaultCategoria = new Categoria()
            {
                CategoriaId = 0,
                NombreCategoria = "Seleccione"
            };
            listaCategorias?.Insert(0, defaultCategoria);
            cbo.DataSource = listaCategorias;
            cbo.DisplayMember = "NombreCategoria";
            cbo.ValueMember = "CategoriaId";
            cbo.SelectedIndex = 0;
        }
    }
}
