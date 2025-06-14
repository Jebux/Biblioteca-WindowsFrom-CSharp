using static BibliotecaForms.Form1;

namespace BibliotecaForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Biblioteca.AgregarLibro(new Libro("titulo1", "autor1", 1998));
            Biblioteca.AgregarLibro(new Libro("titulo2", "autor2", 2003));
            Biblioteca.AgregarLibro(new Libro("titulo3", "autor3", 2004));
            ActualizarGrid();
        }


        private void Event_Registro_Click(object sender, EventArgs e)
        {

            string titulo = inputTitulo.Text;

            string autor = inputAutor.Text;

            string anioPublicacion = inputAño.Text;

            if (!string.IsNullOrWhiteSpace(titulo) && !string.IsNullOrWhiteSpace(autor))
            {
                Biblioteca.AgregarLibro(new Libro(titulo, autor, int.Parse(anioPublicacion)));
                MessageBox.Show("Libro registrado exitosamente.");
                ActualizarGrid();
                inputTitulo.Text = "";
                inputAutor.Text = "";
                inputAño.Text = "";
            }
            else
            {
                MessageBox.Show("Título y autor no pueden estar vacíos.");
            }
        }



        public void ActualizarGrid()
        {
            var bibliotecaActual = Biblioteca.MostrarLibros();
            var librosReducidos = bibliotecaActual.Select(p => new
            {
                p.Titulo,
                p.Autor,
                p.AnioPublicacion,
                p.EstaPrestado
            }).ToList();
            BibliotecaGrid.DataSource = librosReducidos;
        }

        private void Event_ModificarInfo_Click(object sender, EventArgs e)
        {
            string tituloModificar = inputModificarTitulo.Text;
            string tituloNuevo = inputNuevoTitulo.Text;
            string autorNuevo = inputNuevoAutor.Text;
            string anioNuevo = inputNuevoAnio.Text;

            Libro libroModificar = Biblioteca.BuscarLibro(tituloModificar);

            if (libroModificar != null)
            {
                bool everyThingOk = false;
                if (tituloNuevo != "")
                {
                    libroModificar.ActualizarTitulo(tituloNuevo);
                    everyThingOk = true;
                };
                if (autorNuevo != "")
                {
                    libroModificar.ActualizarAutor(autorNuevo);
                    everyThingOk = true;
                }
                if (anioNuevo != "")
                {
                    if (int.TryParse(anioNuevo, out int anioNuevoNum))
                    {
                        libroModificar.ActualizarAnio(anioNuevoNum);
                    }
                    else
                    {
                        MessageBox.Show("El Año definido no es un número.");
                        MessageBox.Show(anioNuevo);
                    };
                };
                if (everyThingOk)
                {
                    ActualizarGrid();
                    MessageBox.Show("Libro actualizado");
                }
            }
            else
            {
                MessageBox.Show("Titulo no encontrado");
            }
            ActualizarGrid();
            inputModificarTitulo.Text = "";
            inputNuevoTitulo.Text = "";
            inputNuevoAutor.Text = "";
            inputNuevoAnio.Text = "";

        }

        private void Event_Prestar_Click(object sender, EventArgs e)
        {
            string tituloPrestar = inputPrestar.Text;

            Biblioteca.PrestarLibro(tituloPrestar);
            ActualizarGrid();
            inputPrestar.Text = "";
        }

        private void Event_Devolver_Click(object sender, EventArgs e)
        {
            string tituloPrestar = inputDevolver.Text;

            Biblioteca.DevolverLibro(tituloPrestar);
            ActualizarGrid();
            inputDevolver.Text = "";
        }

        private void Event_Antiguo_Click(object sender, EventArgs e)
        {
            string tituloConsultar = inputAntiguo.Text;

            Biblioteca.LibroAntiguo(tituloConsultar);

            inputAntiguo.Text = "";
        }

        private void Event_CalcAntiguedad_Click(object sender, EventArgs e)
        {
            string tituloConsultar = inputCalcAnt.Text;

            Biblioteca.CalcAntiguedad(tituloConsultar);

            inputCalcAnt.Text = "";
        }

        private void Event_Comparar_Click(object sender, EventArgs e)
        {
            string tituloConsultar1 = inputComparar1.Text;
            string tituloConsultar2 = inputComparar2.Text;

            Biblioteca.Comparar_libros(tituloConsultar1,tituloConsultar2);

            inputComparar1.Text = "";
            inputComparar2.Text = "";
        }
    }
}
