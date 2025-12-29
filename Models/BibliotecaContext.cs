
namespace BibliotecaMVC.Models
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options) { }

        public DbSet<Libro> Libros { get; set; } = null!;
        public DbSet<Autor> Autores { get; set; } = null!;

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}




