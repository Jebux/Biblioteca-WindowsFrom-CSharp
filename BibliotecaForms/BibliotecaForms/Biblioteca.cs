using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaForms
{
    public class Biblioteca
    {
        public static List<Libro> Libros = new List<Libro>();

        public static void AgregarLibro(Libro libro)
        {
            Libros.Add(libro);
        }

        public static List<Libro> MostrarLibros()
        {
            return Libros;
        }
    }
}
