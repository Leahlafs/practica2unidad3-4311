namespace ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrarprimos_Click(object sender, EventArgs e)
        {
            listBoxPrimos.Items.Clear();

            if (int.TryParse(txtinicio.Text, out int inicio) && int.TryParse(txtfin.Text, out int fin))
            {
                if (inicio > fin)
                {
                    MessageBox.Show("El valor de inicio debe ser menor o igual que el de fin.");
                    return;
                }

                for (int i = inicio; i <= fin; i++)
                { 
                   if (EsPrimo(i))
                    {
                        listBoxPrimos.Items.Add(i);
                    }
                }
            }

            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
        }



        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }
    }
}
