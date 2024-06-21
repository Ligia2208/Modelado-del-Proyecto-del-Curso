namespace Proyecto_GalleryVibe_Web.Models
{
    public class Pintura
    {
        public int? id { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public DateTime? fechaCreacion { get; set; }
        public string tipo { get; set; }
        public decimal? precio { get; set; }
        public Tecnica tecnica { get; set; }
        public string imageUrl { get; set; }
        public int? usuarioId { get; set; }
    }
}
