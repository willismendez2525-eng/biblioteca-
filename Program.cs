using Microsoft.EntityFrameworkCore;
using BibliotecaMVC.Models;

public partial class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Agregar servicios MVC
        builder.Services.AddControllersWithViews();

        // Configurar DbContext con la cadena de conexión
        object value = builder.Services.AddDbContext<BibliotecaContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("BibliotecaDB")));

        var app = builder.Build();

        // Inicializar base de datos con datos de ejemplo
        using (
}
}