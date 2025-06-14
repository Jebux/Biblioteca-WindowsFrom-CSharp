﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaForms
{
    public class Libro
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int AnioPublicacion { get; private set; }
        public bool EstaPrestado { get; private set; }

        public Libro(string titulo, string autor, int anioPublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anioPublicacion;
            EstaPrestado = false;
        }

        public void ActualizarTitulo(string nuevotitulo)
        {
            Titulo = nuevotitulo;
        }
        public void ActualizarAutor(string nuevoAutor)
        {
            Autor = nuevoAutor;
        }
        public void ActualizarAnio(int nuevoAnio)
        {
            AnioPublicacion = nuevoAnio;
        }

        public void Prestar() 
        {
            EstaPrestado = true;
        }
        public void Devolver()
        {
            EstaPrestado = false;
        }
    }
}
