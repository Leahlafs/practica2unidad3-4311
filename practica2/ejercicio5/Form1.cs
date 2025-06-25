namespace ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "000000000";
            maskedTextBox1.ValidatingType = typeof(int);
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(maskedTextBox1.Text, out int numero))
            {

                if (EsPrimo(numero))
                {
                    MessageBox.Show($"{numero} es un numero primo", "resultado");
                }
                else
                {
                    MessageBox.Show($"{numero} no es un numero primo", "resultado");
                }
            }
            else
            {
                MessageBox.Show("por favor, digite un numero valido", "Error");
            }

        }

        private bool EsPrimo(int num)
        { 
        if (num <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

    }
}
