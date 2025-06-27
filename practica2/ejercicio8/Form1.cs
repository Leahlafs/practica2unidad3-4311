namespace ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncontar_Click(object sender, EventArgs e)
        {
            string oracion = txtoracion.Text.Trim();
            if (string.IsNullOrEmpty(oracion))
            {
                MessageBox.Show("Por favor, ingrese una oración válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] palabras = oracion.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            lblresultado.Text = "contidad de palabras:" + palabras.Length;
        }
    }
}
