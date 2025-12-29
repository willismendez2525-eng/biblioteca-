namespace BibliotecaMVC.Models
{
    public class DbContext
    {
        private DbContextOptions<BibliotecaContext> options;

        public DbContext(DbContextOptions<BibliotecaContext> options)
        {
            this.options = options;
        }
    }
}