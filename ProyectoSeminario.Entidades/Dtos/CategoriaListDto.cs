namespace ProyectoSeminario.Entidades.Dtos
{
    public class CategoriaListDto
    {
        public int CategoriaId { get; set; }
        public string NombreCategoria { get; set; } = null!;

        public bool Activa { get; set; }
    }
}
