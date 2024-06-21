using Microsoft.EntityFrameworkCore;
using Proyecto_GalleryVibe_Web.Models;

namespace Proyecto_GalleryVibe_Web.Context
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions<DBContext> options): base(options) { } 

        public DbSet<Contact> contact { get; set; }
        public DbSet<Genero> genero { get; set; }
        public DbSet<OrdenCompra> ordenCompra { get; set; }
        public DbSet<Pintura> pintura { get; set; }
        public DbSet<Publicacion> publicacion { get; set; }
        public DbSet<Registro> registro { get; set; }
        public DbSet<Tecnica> tecnica { get; set; }
        public DbSet<Usuario> usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().ToTable("Contactos");

            modelBuilder.Entity<Genero>().ToTable("Genero");

            modelBuilder.Entity<OrdenCompra>().ToTable("OrdenCompra").HasNoKey();

            modelBuilder.Entity<Pintura>().ToTable("Pintura");

            modelBuilder.Entity<Publicacion>().ToTable("Publicacion");

            modelBuilder.Entity<Registro>().ToTable("Registro");

            modelBuilder.Entity<Tecnica>().ToTable("Tecnica");

            modelBuilder.Entity<Usuario>().ToTable("Usuario");

            base.OnModelCreating(modelBuilder);

        }

    }
  
}