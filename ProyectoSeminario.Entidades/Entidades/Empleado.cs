namespace ProyectoSeminario.Entidades.Entidades
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Activo { get; set; }
        public int Documento { get; set; }
        public int PorcentajeComision { get; set; }
        public bool Sexo { get; set; }
    }
}
