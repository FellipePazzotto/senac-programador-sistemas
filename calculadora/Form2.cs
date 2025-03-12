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
        }

        private void radio_perimetro_CheckedChanged(object sender, EventArgs e)
        {
            label_sinal.Text = "+";
        }

        private void radio_area_CheckedChanged(object sender, EventArgs e)
        {
            label_sinal.Text = "*";
            input_numero_c.Enabled = false;
            input_numero_d.Enabled = false;
        }

        private void radio_volume_CheckedChanged(object sender, EventArgs e)
        {
            label_sinal.Text = "*";
            input_numero_d.Enabled = false;
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            string numero_a_puro = input_numero_a.Text;
            string numero_b_puro = input_numero_b.Text;
            string numero_c_puro = input_numero_c.Text;
            string numero_d_puro = input_numero_d.Text;

            double numero_a = 0;
            double numero_b = 0;
            double numero_c = 0;
            double numero_d = 0;

            if (string.IsNullOrWhiteSpace(numero_a_puro))
            {
                label_erro.Text = "Insira um valor no 1° campo.";
                return;
            }

            if (string.IsNullOrWhiteSpace(numero_b_puro))
            {
                label_erro.Text = "Insira um valor no 2° campo.";
                return;
            }

            if (string.IsNullOrWhiteSpace(numero_c_puro))
            {
                label_erro.Text = "Insira um valor no 3° campo.";
                return;
            }

            if (string.IsNullOrWhiteSpace(numero_d_puro))
            {
                label_erro.Text = "Insira um valor no 4° campo.";
                return;
            }

            if (numero_a_puro.All(char.IsNumber) && numero_b_puro.All(char.IsNumber)
                && numero_c_puro.All(char.IsNumber) && numero_d_puro.All(char.IsNumber))
            {
                numero_a = Convert.ToDouble(input_numero_a.Text);
                numero_b = Convert.ToDouble(input_numero_b.Text);
                numero_c = Convert.ToDouble(input_numero_c.Text);
                numero_d = Convert.ToDouble(input_numero_d.Text);

                label_erro.Text = "";
            }
            else
            {
                label_erro.Text = "Insira apenas números.";
                return;
            }

            switch (label_sinal.Text)
            {
                case "+":
                    label_resultado.Text = $"{numero_a + numero_b}";
                    break;

                case "*":
                    label_resultado.Text = $"{numero_a - numero_b}";
                    break;

                case "":
                    label_erro.Text = "Selecione uma operação.";
                    break;
            }
        }

        private void button_trocar_Click(object sender, EventArgs e)
        {

        }
    }
}
