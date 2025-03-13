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

            input_numero_b.Enabled = false;
            input_numero_b.Text = input_numero_a.Text;
        }

        private void radio_perimetro_CheckedChanged(object sender, EventArgs e)
        {
            label_sinal.Text = "*";
            input_numero_b.Text = "4";
        }

        private void radio_area_CheckedChanged(object sender, EventArgs e)
        {
            label_sinal.Text = "*";
            input_numero_b.Text = $"{input_numero_a.Text}";
        }

        private void radio_volume_CheckedChanged(object sender, EventArgs e)
        {
            label_sinal.Text = "*";
            double a = Convert.ToDouble(input_numero_a.Text);
            input_numero_b.Text = $"{a * a}";
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            string numero_a_puro = input_numero_a.Text;
            string numero_b_puro = input_numero_b.Text;

            double numero_a = 0;

            if (string.IsNullOrWhiteSpace(numero_a_puro))
            {
                label_erro.Text = "Insira um valor no 1° campo.";
                return;
            }

            if (numero_a_puro.All(char.IsNumber))
            {
                numero_a = Convert.ToDouble(input_numero_a.Text);

                label_erro.Text = "";
            }
            else
            {
                label_erro.Text = "Insira apenas números.";
                return;
            }

            if (Convert.ToDouble(numero_b_puro) == 4)
            {
                label_resultado.Text = $"{numero_a * 4}";
                return;
            }

            if (Convert.ToDouble(numero_b_puro) == Convert.ToDouble(numero_a_puro))
            {
                label_resultado.Text = $"{numero_a * numero_a}";
                return;
            }
            
            if (Convert.ToDouble(numero_b_puro) == Convert.ToDouble(numero_a_puro) * Convert.ToDouble(numero_a_puro))
            {
                label_resultado.Text = $"{numero_a * numero_a * numero_a}";
                return;
            }
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            radio_perimetro.Checked = false;
            radio_area.Checked = false;
            radio_volume.Checked = false;

            label_sinal.Text = "";
            label_resultado.Text = "?????";
            label_erro.Text = "";

            input_numero_a.Clear();
            input_numero_b.Clear();
        }

        private void button_trocar_Click(object sender, EventArgs e)
        {
            Form form_1 = new calculadora_1();
            this.Hide();
            form_1.ShowDialog();
        }
    }
}
