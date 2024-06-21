namespace Proyecto_GalleryVibe_Web.Models
{
    public class Publicacion
    {
        public int? id { get; set; }
        public string titulo { get; set; }
        public decimal precio { get; set; }
        public string categoria { get; set; }
        public string estado { get; set; }
        public string descripcion { get; set; }
        public string etiquetas { get; set; }
        public byte[] imagen { get; set; }
    }
}
