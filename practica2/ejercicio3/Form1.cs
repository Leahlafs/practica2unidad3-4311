namespace ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbUnidadEntrada.Items.AddRange(new string[] {"metros", "centimetros", "pulgadas" });
            cmbUnidadSalida.Items.AddRange(new string[] { "metros", "centimetros", "pulgadas" });

            cmbUnidadEntrada.SelectedIndex = 0;
            cmbUnidadSalida.SelectedIndex = 1;
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtvalor.Text, out double valor))
            {
                double valorEnMetros = ConvertirAmetros(valor, cmbUnidadEntrada.SelectedItem.ToString());
                double resultado = ConvertirDesdeMetros(valorEnMetros, cmbUnidadSalida.SelectedItem.ToString());

                lblresultado.Text = $"Resultado: {resultado:F4} {cmbUnidadSalida.SelectedItem}";
            }

            else
            {
                MessageBox.Show("por favor, ingrse un numero valido.", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private double ConvertirAmetros(double valor, string unidad)
        {
            switch (unidad)
            {
                case "metros":
                    return valor;
                case "centimetros":
                    return valor / 100.0;
                default:
                    return valor;
                    case "pulgadas":
                    return valor * 0.0254; 
            }
        }

        private double ConvertirDesdeMetros(double valor, string unidad)
        {
            switch (unidad)
            {
                case "metros":
                    return valor;
                case "centimetros":
                    return valor * 100.0;
                default:
                    return valor;
                case "pulgadas":
                    return valor * 0.0254;
            }
        }
    }
}
