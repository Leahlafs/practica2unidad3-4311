namespace ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            string palabra = txtpalabra.Text.Trim().ToLower();

            // invertir la palabra
            char[] letas = palabra.ToCharArray();
            Array.Reverse(letas);
            string palabraInvertida = new string(letas);

            if (palabra == palabraInvertida && palabra.Length > 0)
            { 
            MessageBox.Show("La palabra es un palíndromo", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
   
            else
            {
                MessageBox.Show("La palabra no es un palíndromo", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        
    }
}
