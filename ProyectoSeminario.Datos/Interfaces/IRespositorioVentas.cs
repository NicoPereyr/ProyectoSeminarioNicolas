
using ProyectoSeminario.Entidades.Entidades;

namespace ProyectoSeminario.Datos.Interfaces
{
    public interface IRepositorioVentas
    {
        void Agregar(Venta venta);

        Venta? GetVentaPorId(int ventaId);

        List<Venta> GetLista();

        void Anular(int ventaId);
    }
}
