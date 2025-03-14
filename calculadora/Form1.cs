namespace calculadora
{
    public partial class calculadora_padrao : Form
    {
        public calculadora_padrao()
        {
            InitializeComponent();
        }
        private void radio_mais_CheckedChanged(object sender, EventArgs e)
        {
            label_sinal.Text = "+";
        }

        private void radio_menos_CheckedChanged(object sender, EventArgs e)
        {
            label_sinal.Text = "-";
        }

        private void radio_vezes_CheckedChanged(object sender, EventArgs e)
        {
            label_sinal.Text = "*";
        }

        private void radio_dividido_CheckedChanged(object sender, EventArgs e)
        {
            label_sinal.Text = "/";
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            string numero_a_puro = input_numero_a.Text;
            string numero_b_puro = input_numero_b.Text;

            double numero_a = 0;
            double numero_b = 0;

            if (string.IsNullOrWhiteSpace(numero_a_puro))
            {
                label_erro.Text = "O campo '1� n�mero' est� vazio.";
                return;
            }

            if (string.IsNullOrWhiteSpace(numero_b_puro))
            {
                label_erro.Text = "O campo '2� n�mero' est� vazio.";
                return;
            }

            if (numero_a_puro.All(char.IsNumber) && numero_b_puro.All(char.IsNumber))
            {
                numero_a = Convert.ToDouble(input_numero_a.Text);
                numero_b = Convert.ToDouble(input_numero_b.Text);

                label_erro.Text = "";
            }
            else
            {
                label_erro.Text = "Insira apenas n�meros.";
                return;
            }

            if (radio_mais.Checked)
            {
                label_resultado.Text = $"{numero_a + numero_b}";
                return;
            }
            else if (radio_menos.Checked)
            {
                label_resultado.Text = $"{numero_a - numero_b}";
                return;
            }
            else if (radio_vezes.Checked)
            {
                label_resultado.Text = $"{numero_a * numero_b}";
                return;
            }
            else if (radio_dividido.Checked)
            {
                label_resultado.Text = $"{numero_a / numero_b}";
                return;
            }
            else
            {
                label_erro.Text = "Selecione uma opera��o.";
                return;
            }
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            radio_mais.Checked = false;
            radio_menos.Checked = false;
            radio_vezes.Checked = false;
            radio_dividido.Checked = false;

            label_sinal.Text = "";
            label_resultado.Text = "?????";
            label_erro.Text = "";

            input_numero_a.Clear();
            input_numero_b.Clear();
        }

        private void button_calc_2_Click(object sender, EventArgs e)
        {
            Form form_2 = new calculadora_quadrilateros();
            this.Hide();
            form_2.ShowDialog();
        }

        private void button_calc_3_Click(object sender, EventArgs e)
        {
            Form form_3 = new calculadora_circunferencias();
            this.Hide();
            form_3.ShowDialog();
        }
    }
}
