namespace calculadora
{
    partial class calculadora_3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            radio_area = new RadioButton();
            radio_perimetro = new RadioButton();
            radio_diametro = new RadioButton();
            label_erro = new Label();
            label_resultado = new Label();
            label_igual = new Label();
            label_sinal = new Label();
            input_raio = new TextBox();
            button_calcular = new Button();
            button_limpar = new Button();
            radio_volume = new RadioButton();
            label_formula = new Label();
            label_titulo = new Label();
            button_calc_1 = new Button();
            button_calc_2 = new Button();
            label_titulo_formula = new Label();
            SuspendLayout();
            // 
            // radio_area
            // 
            radio_area.AutoSize = true;
            radio_area.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio_area.Location = new Point(55, 142);
            radio_area.Name = "radio_area";
            radio_area.Size = new Size(53, 21);
            radio_area.TabIndex = 26;
            radio_area.TabStop = true;
            radio_area.Text = "Área";
            radio_area.UseVisualStyleBackColor = true;
            radio_area.CheckedChanged += radio_area_CheckedChanged;
            // 
            // radio_perimetro
            // 
            radio_perimetro.AutoSize = true;
            radio_perimetro.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio_perimetro.Location = new Point(55, 92);
            radio_perimetro.Name = "radio_perimetro";
            radio_perimetro.Size = new Size(83, 21);
            radio_perimetro.TabIndex = 25;
            radio_perimetro.TabStop = true;
            radio_perimetro.Text = "Perímetro";
            radio_perimetro.UseVisualStyleBackColor = true;
            radio_perimetro.CheckedChanged += radio_perimetro_CheckedChanged;
            // 
            // radio_diametro
            // 
            radio_diametro.AutoSize = true;
            radio_diametro.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio_diametro.Location = new Point(75, 117);
            radio_diametro.Name = "radio_diametro";
            radio_diametro.Size = new Size(80, 21);
            radio_diametro.TabIndex = 24;
            radio_diametro.TabStop = true;
            radio_diametro.Text = "Diâmetro";
            radio_diametro.UseVisualStyleBackColor = true;
            radio_diametro.CheckedChanged += radio_diametro_CheckedChanged;
            // 
            // label_erro
            // 
            label_erro.AutoSize = true;
            label_erro.Location = new Point(55, 70);
            label_erro.Name = "label_erro";
            label_erro.Size = new Size(0, 15);
            label_erro.TabIndex = 23;
            // 
            // label_resultado
            // 
            label_resultado.AutoSize = true;
            label_resultado.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_resultado.Location = new Point(233, 38);
            label_resultado.Name = "label_resultado";
            label_resultado.Size = new Size(52, 25);
            label_resultado.TabIndex = 22;
            label_resultado.Text = "?????";
            // 
            // label_igual
            // 
            label_igual.AutoSize = true;
            label_igual.Location = new Point(217, 44);
            label_igual.Name = "label_igual";
            label_igual.Size = new Size(15, 15);
            label_igual.TabIndex = 21;
            label_igual.Text = "=";
            // 
            // label_sinal
            // 
            label_sinal.AutoSize = true;
            label_sinal.Location = new Point(105, 46);
            label_sinal.Name = "label_sinal";
            label_sinal.Size = new Size(12, 15);
            label_sinal.TabIndex = 20;
            label_sinal.Text = "*";
            // 
            // input_raio
            // 
            input_raio.Location = new Point(45, 40);
            input_raio.Name = "input_raio";
            input_raio.Size = new Size(50, 23);
            input_raio.TabIndex = 18;
            // 
            // button_calcular
            // 
            button_calcular.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_calcular.Location = new Point(195, 150);
            button_calcular.Name = "button_calcular";
            button_calcular.Size = new Size(90, 40);
            button_calcular.TabIndex = 17;
            button_calcular.Text = "Calcular";
            button_calcular.UseVisualStyleBackColor = true;
            button_calcular.Click += button_calcular_Click;
            // 
            // button_limpar
            // 
            button_limpar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_limpar.Location = new Point(195, 100);
            button_limpar.Name = "button_limpar";
            button_limpar.Size = new Size(90, 40);
            button_limpar.TabIndex = 16;
            button_limpar.Text = "Limpar";
            button_limpar.UseVisualStyleBackColor = true;
            button_limpar.Click += button_limpar_Click;
            // 
            // radio_volume
            // 
            radio_volume.AutoSize = true;
            radio_volume.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio_volume.Location = new Point(75, 167);
            radio_volume.Name = "radio_volume";
            radio_volume.Size = new Size(69, 21);
            radio_volume.TabIndex = 28;
            radio_volume.TabStop = true;
            radio_volume.Text = "Volume";
            radio_volume.UseVisualStyleBackColor = true;
            radio_volume.CheckedChanged += radio_volume_CheckedChanged;
            // 
            // label_formula
            // 
            label_formula.AutoSize = true;
            label_formula.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_formula.Location = new Point(125, 40);
            label_formula.Name = "label_formula";
            label_formula.Size = new Size(45, 21);
            label_formula.TabIndex = 30;
            label_formula.Text = "?????";
            // 
            // label_titulo
            // 
            label_titulo.AutoSize = true;
            label_titulo.Location = new Point(55, 22);
            label_titulo.Name = "label_titulo";
            label_titulo.Size = new Size(30, 15);
            label_titulo.TabIndex = 31;
            label_titulo.Text = "Raio";
            // 
            // button_calc_1
            // 
            button_calc_1.Location = new Point(20, 205);
            button_calc_1.Name = "button_calc_1";
            button_calc_1.Size = new Size(140, 23);
            button_calc_1.TabIndex = 32;
            button_calc_1.Text = "Calculadora padrão";
            button_calc_1.UseVisualStyleBackColor = true;
            button_calc_1.Click += button_calc_1_Click;
            // 
            // button_calc_2
            // 
            button_calc_2.Location = new Point(170, 205);
            button_calc_2.Name = "button_calc_2";
            button_calc_2.Size = new Size(140, 23);
            button_calc_2.TabIndex = 33;
            button_calc_2.Text = "Calc. de quadriláteros";
            button_calc_2.UseVisualStyleBackColor = true;
            button_calc_2.Click += button_calc_2_Click;
            // 
            // label_titulo_formula
            // 
            label_titulo_formula.AutoSize = true;
            label_titulo_formula.Location = new Point(150, 22);
            label_titulo_formula.Name = "label_titulo_formula";
            label_titulo_formula.Size = new Size(51, 15);
            label_titulo_formula.TabIndex = 34;
            label_titulo_formula.Text = "Fórmula";
            // 
            // calculadora_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(334, 241);
            Controls.Add(label_titulo_formula);
            Controls.Add(button_calc_2);
            Controls.Add(button_calc_1);
            Controls.Add(label_titulo);
            Controls.Add(label_formula);
            Controls.Add(radio_volume);
            Controls.Add(radio_area);
            Controls.Add(radio_perimetro);
            Controls.Add(radio_diametro);
            Controls.Add(label_erro);
            Controls.Add(label_resultado);
            Controls.Add(label_igual);
            Controls.Add(label_sinal);
            Controls.Add(input_raio);
            Controls.Add(button_calcular);
            Controls.Add(button_limpar);
            Name = "calculadora_3";
            Text = "Calculadora de circunferências";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton radio_area;
        private RadioButton radio_perimetro;
        private RadioButton radio_diametro;
        private Label label_erro;
        private Label label_resultado;
        private Label label_igual;
        private Label label_sinal;
        private TextBox input_numero_b;
        private TextBox input_raio;
        private Button button_calcular;
        private Button button_limpar;
        private RadioButton radio_volume;
        private Label label_formula;
        private TextBox textBox1;
        private Label label_titulo;
        private Button button_calc_1;
        private Button button_calc_2;
        private Label label_titulo_formula;
    }
}