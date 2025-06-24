namespace ejercicio2
{
    public partial class Form1 : Form
    {
        private int tiemporestante;
        public Form1()
        {
            InitializeComponent();

            nudminutos.Maximum = 59;
            nudsegundos.Maximum = 59;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            int minutos = (int)nudminutos.Value;
            int segundos = (int)nudsegundos.Value;

            tiemporestante = (minutos * 60) + segundos;

            if (tiemporestante > 0)
            {
                timer1.Start();
                ActualizarTiempoMostrado();
            }
            else
            {
                MessageBox.Show("por favor, establese un tiempo mayor a 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void ActualizarTiempoMostrado()
        {
            int minutos = tiemporestante / 60;
            int segundos = tiemporestante % 60;
            lbltiemporestante.Text = $"Tiempo restante: {minutos:D2}:{segundos:D2}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiemporestante > 0)
            {
                tiemporestante--;
                ActualizarTiempoMostrado();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("El tiempo ha terminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbltiemporestante.Text = "00:00";
            }
        }
    }
}
