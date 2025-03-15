namespace calculadora
{
    public partial class calculadora_circunferencias : Form
    {
        public calculadora_circunferencias()
        {
            InitializeComponent();
        }

        private void radio_perimetro_CheckedChanged(object sender, EventArgs e)
        {
            label_formula.Text = "2 * π";
        }

        private void radio_diametro_CheckedChanged(object sender, EventArgs e)
        {
            label_formula.Text = "2";
        }

        private void radio_area_CheckedChanged(object sender, EventArgs e)
        {
            label_formula.Text = "R * π";
        }

        private void radio_volume_CheckedChanged(object sender, EventArgs e)
        {
            label_formula.Text = "4/3 * R² * π";
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            double raio = 0;

            if (string.IsNullOrEmpty(input_raio.Text))
            {
                label_erro.Text = "O campo 'raio' está vazio.";
                return;
            }

            try
            {
                label_erro.Text = "";
                raio = Convert.ToDouble(input_raio.Text);
            }
            catch
            {
                label_resultado.Text = "?????";
                label_erro.Text = "Insira apenas números.";
                return;
            }

            if (radio_perimetro.Checked)
            {
                label_resultado.Text = $"{raio * 2 * 3.1416:N2}";
                return;
            }
            else if (radio_diametro.Checked)
            {
                label_resultado.Text = $"{raio * 2:N2}";
                return;
            }
            else if (radio_area.Checked)
            {
                label_resultado.Text = $"{Math.Pow(raio, 2) * 3.1416:N2}";
                return;
            }
            else if (radio_volume.Checked)
            {
                label_resultado.Text = $"{1.3333 * Math.Pow(raio, 3) * 3.1416:N2}";
                return;
            }
            else
            {
                label_erro.Text = "Selecione uma operação.";
                return;
            }
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            label_erro.Text = "";
            label_formula.Text = "?????";
            label_sinal.Text = "";
            label_resultado.Text = "?????";

            radio_perimetro.Checked = false;
            radio_diametro.Checked = false;
            radio_area.Checked = false;
            radio_volume.Checked = false;
        }

        private void button_calc_1_Click(object sender, EventArgs e)
        {
            var form = new calculadora_padrao();
            form.Show();
            this.Hide();
        }

        private void button_calc_2_Click(object sender, EventArgs e)
        {
            var form = new calculadora_quadrilateros();
            form.Show();
            this.Hide();
        }
    }
}
