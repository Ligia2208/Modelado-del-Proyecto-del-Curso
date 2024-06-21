namespace Proyecto_GalleryVibe_Web.Models
{
    public class OrdenCompra
    {
        public int idOrdenCompra { get; set; }
        public int idUsuario { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string estadoOrden { get; set; }
        public decimal totalOrden { get; set; }
        public int idImagen { get; set; }
        public int cantidad { get; set; }
        public decimal precioUnitario { get; set; }
        public string metodoPago { get; set; }
        public string direccionEnvio { get; set; }
        public string comentariosAdicionales { get; set; }
    }
}
