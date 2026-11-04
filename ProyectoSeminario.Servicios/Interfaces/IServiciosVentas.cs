
using ProyectoSeminario.Entidades.Entidades;

namespace ProyectoSeminario.Servicios.Interfaces
{
    public interface IServiciosVentas
    {
        void Guardar(Venta venta);

        Venta? GetVentaPorId(int ventaId);

        List<Venta> GetLista();

        void Anular(int ventaId);
    }
}
