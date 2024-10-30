using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeminario.Entidades.Dtos
{
    public class EmpleadoListDto
    {

        public int EmpleadoId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public bool Activo { get; set; }
        public int Documento { get; set; }
        public int PorcentajeComision { get; set; }


    }
}
