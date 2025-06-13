using static BibliotecaForms.Form1;

namespace BibliotecaForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
        }


        List<Libro> Libros = new List<Libro>(); 
        
        private void btnRegistro_Click(object sender, EventArgs e)
        {

            string titulo = inputTitulo.Text;

            string autor = inputAutor.Text;

            string anioPublicacion = inputAño.Text;

            if (!string.IsNullOrWhiteSpace(titulo) && !string.IsNullOrWhiteSpace(autor))
            {
                Libros.Add(new Libro(titulo, autor, int.Parse(anioPublicacion)));
                MessageBox.Show("Libro registrado exitosamente.");
            }
            else
            {
                MessageBox.Show("Título y autor no pueden estar vacíos.");
            }
        }

        private void btnActualizarGrid_Click(object sender, EventArgs e)
        {
            var librosReducidos = Libros.Select(p => new
            {
                p.Titulo,
                p.Autor 
            }).ToList();
            BibliotecaGrid.DataSource = librosReducidos;
        }
    }
}
