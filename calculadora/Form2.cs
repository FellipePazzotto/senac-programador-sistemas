using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class calculadora_quadrilateros : Form
    {
        public calculadora_quadrilateros()
        {
            InitializeComponent();

            input_numero_q_b.Enabled = false;
            input_numero_q_b.Text = input_numero_q_a.Text;
        }

        private void radio_perimetro_q_CheckedChanged(object sender, EventArgs e)
        {
            label_q_sinal.Text = "*";
            input_numero_q_b.Text = "4";
        }

        private void radio_area_q_CheckedChanged(object sender, EventArgs e)
        {
            label_q_sinal.Text = "*";
            input_numero_q_b.Text = $"{input_numero_q_a.Text}";
        }

        private void radio_volume_q_CheckedChanged(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(input_numero_q_a.Text);

            label_q_sinal.Text = "*";
            input_numero_q_b.Text = $"{a * a}";
        }

        private void button_calcular_q_Click(object sender, EventArgs e)
        {
            string numero_a_puro = input_numero_q_a.Text;
            string numero_b_puro = input_numero_q_b.Text;

            double numero_a = 0;

            if (string.IsNullOrWhiteSpace(numero_a_puro))
            {
                label_erro_q.Text = "O campo 'lado' está vazio.";
                return;
            }

            if (numero_a_puro.All(char.IsNumber))
            {
                numero_a = Convert.ToDouble(input_numero_q_a.Text);

                label_erro_q.Text = "";
            }
            else
            {
                label_erro_q.Text = "Insira apenas números.";
                return;
            }

            if (radio_perimetro_q.Checked)
            {
                label_resultado_q.Text = $"{numero_a * 4}";
                return;
            }
            else if (radio_area_q.Checked)
            {
                label_resultado_q.Text = $"{numero_a * numero_a}";
                return;
            }
            else if (radio_volume_q.Checked)
            {
                label_resultado_q.Text = $"{numero_a * numero_a * numero_a}";
                return;
            }
            else
            {
                label_erro_q.Text = "Selecione uma operação.";
            }
        }

        private void button_limpar_q_Click(object sender, EventArgs e)
        {
            radio_perimetro_q.Checked = false;
            radio_area_q.Checked = false;
            radio_volume_q.Checked = false;

            label_q_sinal.Text = "";
            label_resultado_q.Text = "?????";
            label_erro_q.Text = "";

            input_numero_q_a.Clear();
            input_numero_q_b.Clear();
        }

        private void radio_perimetro_r_CheckedChanged(object sender, EventArgs e)
        {
            input_numero_r_c.Text = "";
            input_numero_r_c.Enabled = false;

            label_r_sinal_a.Text = "* 2 +";
            label_r_sinal_a.Location = new Point(380, 44);

            label_r_sinal_b.Text = "* 2";
            label_r_sinal_b.Location = new Point(470, 44);
        }

        private void radio_area_r_CheckedChanged(object sender, EventArgs e)
        {
            input_numero_r_c.Text = "";
            input_numero_r_c.Enabled = false;

            label_r_sinal_a.Text = "*";
            label_r_sinal_a.Location = new Point(392, 46);

            label_r_sinal_b.Text = "";
            label_r_sinal_b.Location = new Point(477, 46);
        }

        private void radio_volume_r_CheckedChanged(object sender, EventArgs e)
        {
            input_numero_r_c.Enabled = true;

            label_r_sinal_a.Text = "*";
            label_r_sinal_a.Location = new Point(392, 46);

            label_r_sinal_b.Text = "*";
            label_r_sinal_b.Location = new Point(477, 46);
        }

        private void button_calcular_r_Click(object sender, EventArgs e)
        {
            string numero_a_puro_r = input_numero_r_a.Text;
            string numero_b_puro_r = input_numero_r_b.Text;
            string numero_c_puro_r = input_numero_r_c.Text;

            double numero_a_r = 0;
            double numero_b_r = 0;
            double numero_c_r = 0;

            if (string.IsNullOrWhiteSpace(numero_a_puro_r))
            {
                label_erro_r.Text = "O campo 'largura' está vazio.";
                return;
            }

            if (numero_a_puro_r.All(char.IsNumber))
            {
                numero_a_r = Convert.ToDouble(input_numero_r_a.Text);

                label_erro_r.Text = "";
            }
            else
            {
                label_erro_r.Text = "Insira apenas números.";
                return;
            }

            if (string.IsNullOrWhiteSpace(numero_b_puro_r))
            {
                label_erro_r.Text = "O campo 'altura' está vazio.";
                return;
            }

            if (numero_b_puro_r.All(char.IsNumber))
            {
                numero_b_r = Convert.ToDouble(input_numero_r_b.Text);

                label_erro_r.Text = "";
            }
            else
            {
                label_erro_r.Text = "Insira apenas números.";
                return;
            }

            if (radio_perimetro_r.Checked)
            {
                label_resultado_r.Text = $"{numero_a_r + numero_a_r + numero_b_r + numero_b_r}";
                return;
            }
            else if (radio_area_r.Checked)
            {
                label_resultado_r.Text = $"{numero_a_r * numero_b_r}";
                return;
            }
            else if (radio_volume_r.Checked)
            {
                if (string.IsNullOrWhiteSpace(numero_c_puro_r))
                {
                    label_erro_r.Text = "O campo 'comprimento' está vazio.";
                    return;
                }

                if (numero_c_puro_r.All(char.IsNumber))
                {
                    numero_c_r = Convert.ToDouble(input_numero_r_c.Text);

                    label_erro_r.Text = "";
                }
                else
                {
                    label_erro_r.Text = "Insira apenas números.";
                    return;
                }

                label_resultado_r.Text = $"{numero_a_r * numero_b_r * numero_c_r}";
                return;
            }
            else
            {
                label_erro_r.Text = "Selecione uma operação.";
            }
        }

        private void button_limpar_r_Click(object sender, EventArgs e)
        {
            radio_perimetro_r.Checked = false;
            radio_area_r.Checked = false;
            radio_volume_r.Checked = false;

            label_r_sinal_a.Text = "";
            label_r_sinal_b.Text = "";
            label_resultado_r.Text = "?????";
            label_erro_r.Text = "";

            input_numero_r_a.Clear();
            input_numero_r_b.Clear();
            input_numero_r_c.Clear();
        }

        private void button_calc_1_Click(object sender, EventArgs e)
        {
            Form form_1 = new calculadora_padrao();
            this.Hide();
            form_1.ShowDialog();
        }

        private void button_calc_3_Click(object sender, EventArgs e)
        {
            Form form_3 = new calculadora_circunferencias();
            this.Hide();
            form_3.ShowDialog();
        }
    }
}