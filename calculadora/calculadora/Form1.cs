namespace calculadora
{
    public partial class calculadora_1 : Form
    {
        int operador = 0;
        public calculadora_1()
        {
            InitializeComponent();
        }
        private void button_mais_Click(object sender, EventArgs e)
        {
            operador = 1;
            label_a.Text = "+";
        }

        private void button_menos_Click(object sender, EventArgs e)
        {
            operador = 2;
            label_a.Text = "-";
        }

        private void button_vezes_Click(object sender, EventArgs e)
        {
            operador = 3;
            label_a.Text = "X";
        }

        private void button_dividido_Click(object sender, EventArgs e)
        {
            operador = 4;
            label_a.Text = "/";
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            string numero_a_puro = input_numero_a.Text;
            string numero_b_puro = input_numero_b.Text;

            int numero_a = 0;
            int numero_b = 0;

            if (numero_a_puro.All(char.IsNumber) && numero_b_puro.All(char.IsNumber))
            {
                numero_a = Convert.ToInt32(input_numero_a.Text);
                numero_b = Convert.ToInt32(input_numero_b.Text);

                label_erro.Text = "";
            }
            else
            {
                label_erro.Text = "Insira apenas números.";
                return;
            }
            
            if (operador == 1)
            {
                label_resultado.Text = $"{numero_a + numero_b}";
            }
            else if (operador == 2)
            {
                label_resultado.Text = $"{numero_a - numero_b}";
            }
            else if (operador == 3)
            {
                label_resultado.Text = $"{numero_a * numero_b}";
            }
            else if(operador == 4)
            {
                label_resultado.Text = $"{numero_a / numero_b}";
            }
            else
            {
                label_erro.Text = "Escolha uma operação.";
            }
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            operador = 0;

            label_a.Text = "";
            label_resultado.Text = "";
            label_erro.Text = "";

            input_numero_a.Clear();
            input_numero_b.Clear();

            var form_2 = new calculadora_2();
            this.Hide();
            form_2.Show();
        }
    }
}
