namespace Proyecto_GalleryVibe_Web.Models
{
    public class Usuario
    {
        public int? id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string cedula { get; set; }
        public string correo { get; set; }
        public int genero { get; set; }
        public DateTime FechNac { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
    }
}
