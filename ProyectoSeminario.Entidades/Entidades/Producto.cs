using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeminario.Entidades.Entidades
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public decimal PrecioVenta { get; set; }
        public bool Activo { get; set; }
        public int CategoriaId { get; set; }
        public required Categoria Categoria { get; set; }
    }
}
