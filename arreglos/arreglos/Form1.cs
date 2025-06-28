using arreglos.controladores;
using arreglos.entidades;

namespace arreglos
{
    public partial class Form1 : Form
    {
        //llamar al controlador
        private AlumnoControl alumnoControl = new AlumnoControl();
        public Form1()
        {
            InitializeComponent();
        }

        //mostrar
        private void MostrarAlumnos(Alumno[] alumno)
        {
            dgAlumnos.DataSource = null; //Limpiar el DataGridView
            dgAlumnos.DataSource = alumno; //Asignar el nuevo origen de datos
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            //validar campos de entrada
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbPromedio.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;

            }

            //crear alumno
            Alumno alumno = new Alumno()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Promedio = Convert.ToDouble(tbPromedio.Text)
            };

            //registrar alumno

            alumnoControl.Registrar(alumno);

            //mostar alumnos
            MostrarAlumnos(alumnoControl.ListarTodo());


            //limpiar campos de entrada
            LimpiarCampos();

        }

        public void LimpiarCampos()
        {
            tbCodigo.Clear();
            tbNombre.Clear();
            tbPromedio.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validación de selección en fila
            if (dgAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro para eliminar.");
                return;
            }

            // Obtener el código del alumno seleccionado
            String codigo = dgAlumnos.SelectedRows[0].Cells[0].Value.ToString();

            // Lógica para eliminar el alumno
            alumnoControl.Eliminar(codigo);

            // Mostrar los alumnos después de la eliminación
            MostrarAlumnos(alumnoControl.ListarTodo());
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            MostrarAlumnos(alumnoControl.Ordenar());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //validar compo
            if (tbBuscar.Text == "")
            {
                MessageBox.Show("Por favor, ingrese el código del alumno a buscar.");
                return;
            }

            //buscar alumno por codigo
            //obtener el código del alumno a buscar
            string codigo = tbBuscar.Text;
            MostrarAlumnos(alumnoControl.BuscarPorCodigo(codigo));

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
