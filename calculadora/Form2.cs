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
    public partial class calculadora_2 : Form
    {
        public calculadora_2()
        {
            InitializeComponent();

            input_numero_q_b.Enabled = false;
            input_numero_q_b.Text = input_numero_q_a.Text;
        }

        private void radio_perimetro_CheckedChanged(object sender, EventArgs e)
        {
            label_q_sinal.Text = "*";
            input_numero_q_b.Text = "4";
        }

        private void radio_area_CheckedChanged(object sender, EventArgs e)
        {
            label_q_sinal.Text = "*";
            input_numero_q_b.Text = $"{input_numero_q_a.Text}";
        }

        private void radio_volume_CheckedChanged(object sender, EventArgs e)
        {
            label_q_sinal.Text = "*";
            double a = Convert.ToDouble(input_numero_q_a.Text);
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

            if (Convert.ToDouble(numero_b_puro) == 4)
            {
                label_resultado_q.Text = $"{numero_a * 4}";
                return;
            }

            if (Convert.ToDouble(numero_b_puro) == Convert.ToDouble(numero_a_puro))
            {
                label_resultado_q.Text = $"{numero_a * numero_a}";
                return;
            }

            if (Convert.ToDouble(numero_b_puro) == Convert.ToDouble(numero_a_puro) * Convert.ToDouble(numero_a_puro))
            {
                label_resultado_q.Text = $"{numero_a * numero_a * numero_a}";
                return;
            }
        }

        private void button_limpar_Click(object sender, EventArgs e)
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

        private void button_trocar_Click(object sender, EventArgs e)
        {
            Form form_3 = new calculadora_3();
            this.Hide();
            form_3.ShowDialog();
        }



        private void radio_perimetro_r_CheckedChanged(object sender, EventArgs e)
        {
            label_r_sinal_a.Text = "*";
            input_numero_r_b.Text = "4";
        }

        private void radio_area_r_CheckedChanged(object sender, EventArgs e)
        {
            label_r_sinal_a.Text = "*";
            input_numero_r_b.Text = $"{input_numero_r_a.Text}";
        }

        private void radio_volume_r_CheckedChanged(object sender, EventArgs e)
        {
            label_r_sinal_a.Text = "*";
            label_r_sinal_b.Text = "*";
            double a = Convert.ToDouble(input_numero_r_a.Text);
            input_numero_r_b.Text = $"{a * a}";
        }

        private void button_calcular_r_Click(object sender, EventArgs e)
        {
            string numero_a_puro_r = input_numero_r_a.Text;
            string numero_b_puro_r = input_numero_r_b.Text;
            string numero_c_puro_r = input_numero_r_c.Text;

            double numero_a = 0;

            if (string.IsNullOrWhiteSpace(numero_a_puro))
            {
                label_erro_t.Text = "Insira um valor no 1° campo.";
                return;
            }

            if (string.IsNullOrWhiteSpace(numero_a_puro))
            {
                label_erro_t.Text = "Insira um valor no 2° campo.";
                return;
            }

            if (numero_a_puro.All(char.IsNumber))
            {
                numero_a = Convert.ToDouble(input_numero_r_a.Text);

                label_erro_t.Text = "";
            }
            else
            {
                label_erro_t.Text = "Insira apenas números.";
                return;
            }

            if (Convert.ToDouble(numero_b_puro) == 4)
            {
                label_resultado_r.Text = $"{numero_a * 4}";
                return;
            }

            if (Convert.ToDouble(numero_b_puro) == Convert.ToDouble(numero_a_puro))
            {
                label_resultado_r.Text = $"{numero_a * numero_a}";
                return;
            }

            if (Convert.ToDouble(numero_b_puro) == Convert.ToDouble(numero_a_puro) * Convert.ToDouble(numero_a_puro))
            {
                label_resultado_r.Text = $"{numero_a * numero_a * numero_a}";
                return;
            }

        }

        private void button_calc_3_Click(object sender, EventArgs e)
        {
            Form form_1 = new calculadora_1();
            this.Hide();
            form_1.ShowDialog();
        }
    }
}