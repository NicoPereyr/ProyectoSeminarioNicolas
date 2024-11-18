namespace ProyectoSeminario.Entidades.Dtos
{
    public class ProductoListDto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal PrecioVenta { get; set; }
        public string? Descripcion { get; set; }
        public bool Activo { get; set; }
        public string? Imagen { get; set; }
        public int CategoriaId { get; set; }
        public string NombreCategoria { get; set; }




    }
}
