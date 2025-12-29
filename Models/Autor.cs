
using System.Collections.Generic;

namespace BibliotecaMVC.Models
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Nombre { get; set; }
        public List<Libro> Libros { get; set; } = new List<Libro>();
    }
}

