namespace ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "000000";
            maskedTextBox1.ValidatingType = typeof(int);
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(maskedTextBox1.Text, out int numero))
            {
                if (EsUnNumeroPerfecto(numero))
                {
                    MessageBox.Show($"{numero} es un numero perfecto.", "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show($"{numero} NO es un numero perfecto.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("por favor, ingrese un numero valido", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private bool EsUnNumeroPerfecto(int numero)
        {
            if (numero < 1) return false;

            int suma = 0;
            for (int i = 1; i <= numero / 2; i++)
            {
               if (numero % i == 0)
                {
                    suma += i;
                }
            }

            return suma == numero;
        }


    }
}
