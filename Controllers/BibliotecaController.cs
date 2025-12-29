using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BibliotecaMVC.Models;
using System.Linq;

namespace BibliotecaMVC.Controllers
{
    public class BibliotecaController : Controller
    {
        private readonly BibliotecaContext _context;

        public BibliotecaController(BibliotecaContext context)
        {
            _context = context;
        }

        // LISTAR LIBROS
        public IActionResult Index()
        {
            var libros = _context.Libros
                                 .Include(l => l.Autor)
                                 .ToList();

            return View(libros);
        }

        // CREAR AUTOR - GET
        [HttpGet]
        public IActionResult CrearAutor()
        {
            return View();
        }

        // CREAR AUTOR - POST
        [HttpPost]
        public IActionResult CrearAutor(Autor autor)
        {
            if (!ModelState.IsValid)
                return View(autor);

            _context.Autores.Add(autor);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        // CREAR LIBRO - GET
        [HttpGet]
        public IActionResult CrearLibro()
        {
            ViewBag.Autores = _context.Autores.ToList();
            return View();
        }

        // CREAR LIBRO - POST
        [HttpPost]
        public IActionResult CrearLibro(Libro libro)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Autores = _context.Autores.ToList();
                return View(libro);
            }

            _context.Libros.Add(libro);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}

