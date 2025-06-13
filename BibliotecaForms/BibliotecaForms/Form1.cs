using static BibliotecaForms.Form1;

namespace BibliotecaForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {

            string titulo = inputTitulo.Text;

            string autor = inputAutor.Text;

            string anioPublicacion = inputA�o.Text;

            if (!string.IsNullOrWhiteSpace(titulo) && !string.IsNullOrWhiteSpace(autor))
            {
                Biblioteca.AgregarLibro(new Libro(titulo, autor, int.Parse(anioPublicacion)));
                MessageBox.Show("Libro registrado exitosamente.");
                inputTitulo.Text = "";
                inputAutor.Text = "";
                inputA�o.Text = "";
            }
            else
            {
                MessageBox.Show("T�tulo y autor no pueden estar vac�os.");
            }
        }

        private void btnActualizarGrid_Click(object sender, EventArgs e)
        {
            var bibliotecaActual = Biblioteca.MostrarLibros();
            var librosReducidos = bibliotecaActual.Select(p => new
            {
                p.Titulo,
                p.Autor
            }).ToList();
            BibliotecaGrid.DataSource = librosReducidos;
        }

        private void BibliotecaGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
