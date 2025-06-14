using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        public static Libro BuscarLibro(string titulo)
        {
            return Libros.Find(libro => libro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        }

        public static void PrestarLibro(string titulo)
        {
            var libro = Libros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (libro == null)
            {
                MessageBox.Show("Libro no encontrado.");
            }
            else if (libro.EstaPrestado)
            {
                MessageBox.Show("El libro ya está prestado.");
            }
            else
            {
                libro.Prestar();
                MessageBox.Show("Libro prestado exitosamente.");
            }
        }
        public static void DevolverLibro(string titulo)
        {
            var libro = Libros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (libro == null)
            {
                MessageBox.Show("Libro no encontrado.");
            }
            else if (libro.EstaPrestado)
            {
                MessageBox.Show("El libro devuelto.");
                libro.Devolver();
            }
            else
            {
                MessageBox.Show("Libro no estaba prestado.");
            }
        }

        public static void LibroAntiguo(string titulo)
        {
            var libro = Libros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if(libro == null)
            {
                MessageBox.Show("Libro no encontrado.");
            }
            else
            {
                if (libro.AnioPublicacion < 2000)
                {
                    MessageBox.Show("El libro es antiguo.");
                }
                else
                {
                    MessageBox.Show("El libro no es antiguo");
                }
            }
        }

        public static void CalcAntiguedad(string titulo)
        {
            var libro = Libros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (libro == null)
            {
                MessageBox.Show("Libro no encontrado.");
            }
            else
            {
                int libroEdad = 2025 - libro.AnioPublicacion;
                MessageBox.Show($"El libro tiene {libroEdad} años de ser publicado");
            }

        }

        public static void Comparar_libros(string titulo1,string titulo2)
        {
            var libro1 = Libros.Find(l => l.Titulo.Equals(titulo1, StringComparison.OrdinalIgnoreCase));
            var libro2 = Libros.Find(l => l.Titulo.Equals(titulo2, StringComparison.OrdinalIgnoreCase));

            if(libro1 == null || libro2 == null)
            {
                MessageBox.Show("Ingrese titulos válidos");
            }
            else
            {
                if (libro1.Autor == libro2.Autor)
                {
                    MessageBox.Show($"Los dos libros poseen el mismo autor: {libro1.Autor}");
                }
                else
                {
                    MessageBox.Show($"Los dos libros poseen NO el mismo autor:  {libro1.Autor} y {libro2.Autor}");
                }
            }
        }
    }
}
