namespace calculadora
{
    partial class calculadora_quadrilateros
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
            label_erro_q = new Label();
            label_resultado_q = new Label();
            label_q_b = new Label();
            label_q_sinal = new Label();
            input_numero_q_b = new TextBox();
            input_numero_q_a = new TextBox();
            button_calcular_q = new Button();
            button_limpar_q = new Button();
            radio_perimetro_q = new RadioButton();
            radio_area_q = new RadioButton();
            radio_volume_q = new RadioButton();
            button_calc_1 = new Button();
            radio_volume_r = new RadioButton();
            radio_area_r = new RadioButton();
            radio_perimetro_r = new RadioButton();
            label_erro_r = new Label();
            label_resultado_r = new Label();
            label_r_b = new Label();
            label_r_sinal_a = new Label();
            input_numero_r_b = new TextBox();
            input_numero_r_a = new TextBox();
            button_calcular_r = new Button();
            button_limpar_r = new Button();
            label_r_sinal_b = new Label();
            input_numero_r_c = new TextBox();
            button_calc_3 = new Button();
            label_lado_a = new Label();
            label_largura = new Label();
            label_altura = new Label();
            label_lado_b = new Label();
            label_comprimento = new Label();
            SuspendLayout();
            // 
            // label_erro_q
            // 
            label_erro_q.AutoSize = true;
            label_erro_q.Location = new Point(35, 70);
            label_erro_q.Name = "label_erro_q";
            label_erro_q.Size = new Size(0, 15);
            label_erro_q.TabIndex = 23;
            // 
            // label_resultado_q
            // 
            label_resultado_q.AutoSize = true;
            label_resultado_q.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_resultado_q.Location = new Point(200, 37);
            label_resultado_q.Name = "label_resultado_q";
            label_resultado_q.Size = new Size(52, 25);
            label_resultado_q.TabIndex = 22;
            label_resultado_q.Text = "?????";
            // 
            // label_q_b
            // 
            label_q_b.AutoSize = true;
            label_q_b.Location = new Point(180, 45);
            label_q_b.Name = "label_q_b";
            label_q_b.Size = new Size(15, 15);
            label_q_b.TabIndex = 21;
            label_q_b.Text = "=";
            // 
            // label_q_sinal
            // 
            label_q_sinal.AutoSize = true;
            label_q_sinal.Location = new Point(97, 45);
            label_q_sinal.Name = "label_q_sinal";
            label_q_sinal.Size = new Size(0, 15);
            label_q_sinal.TabIndex = 20;
            // 
            // input_numero_q_b
            // 
            input_numero_q_b.Location = new Point(120, 40);
            input_numero_q_b.Name = "input_numero_q_b";
            input_numero_q_b.Size = new Size(50, 23);
            input_numero_q_b.TabIndex = 19;
            // 
            // input_numero_q_a
            // 
            input_numero_q_a.Location = new Point(35, 40);
            input_numero_q_a.Name = "input_numero_q_a";
            input_numero_q_a.Size = new Size(50, 23);
            input_numero_q_a.TabIndex = 18;
            // 
            // button_calcular_q
            // 
            button_calcular_q.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_calcular_q.Location = new Point(160, 140);
            button_calcular_q.Name = "button_calcular_q";
            button_calcular_q.Size = new Size(90, 40);
            button_calcular_q.TabIndex = 17;
            button_calcular_q.Text = "Calcular";
            button_calcular_q.UseVisualStyleBackColor = true;
            button_calcular_q.Click += button_calcular_q_Click;
            // 
            // button_limpar_q
            // 
            button_limpar_q.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_limpar_q.Location = new Point(160, 95);
            button_limpar_q.Name = "button_limpar_q";
            button_limpar_q.Size = new Size(90, 40);
            button_limpar_q.TabIndex = 16;
            button_limpar_q.Text = "Limpar";
            button_limpar_q.UseVisualStyleBackColor = true;
            button_limpar_q.Click += button_limpar_q_Click;
            // 
            // radio_perimetro_q
            // 
            radio_perimetro_q.AutoSize = true;
            radio_perimetro_q.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio_perimetro_q.Location = new Point(35, 100);
            radio_perimetro_q.Name = "radio_perimetro_q";
            radio_perimetro_q.Size = new Size(83, 21);
            radio_perimetro_q.TabIndex = 24;
            radio_perimetro_q.TabStop = true;
            radio_perimetro_q.Text = "Perímetro";
            radio_perimetro_q.UseVisualStyleBackColor = true;
            radio_perimetro_q.CheckedChanged += radio_perimetro_q_CheckedChanged;
            // 
            // radio_area_q
            // 
            radio_area_q.AutoSize = true;
            radio_area_q.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio_area_q.Location = new Point(35, 125);
            radio_area_q.Name = "radio_area_q";
            radio_area_q.Size = new Size(53, 21);
            radio_area_q.TabIndex = 25;
            radio_area_q.TabStop = true;
            radio_area_q.Text = "Área";
            radio_area_q.UseVisualStyleBackColor = true;
            radio_area_q.CheckedChanged += radio_area_q_CheckedChanged;
            // 
            // radio_volume_q
            // 
            radio_volume_q.AutoSize = true;
            radio_volume_q.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio_volume_q.Location = new Point(35, 150);
            radio_volume_q.Name = "radio_volume_q";
            radio_volume_q.Size = new Size(69, 21);
            radio_volume_q.TabIndex = 26;
            radio_volume_q.TabStop = true;
            radio_volume_q.Text = "Volume";
            radio_volume_q.UseVisualStyleBackColor = true;
            radio_volume_q.CheckedChanged += radio_volume_q_CheckedChanged;
            // 
            // button_calc_1
            // 
            button_calc_1.Location = new Point(180, 202);
            button_calc_1.Name = "button_calc_1";
            button_calc_1.Size = new Size(150, 23);
            button_calc_1.TabIndex = 29;
            button_calc_1.Text = "Calculadora padrão";
            button_calc_1.UseVisualStyleBackColor = true;
            button_calc_1.Click += button_calc_1_Click;
            // 
            // radio_volume_r
            // 
            radio_volume_r.AutoSize = true;
            radio_volume_r.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio_volume_r.Location = new Point(370, 150);
            radio_volume_r.Name = "radio_volume_r";
            radio_volume_r.Size = new Size(69, 21);
            radio_volume_r.TabIndex = 40;
            radio_volume_r.TabStop = true;
            radio_volume_r.Text = "Volume";
            radio_volume_r.UseVisualStyleBackColor = true;
            radio_volume_r.CheckedChanged += radio_volume_r_CheckedChanged;
            // 
            // radio_area_r
            // 
            radio_area_r.AutoSize = true;
            radio_area_r.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio_area_r.Location = new Point(370, 125);
            radio_area_r.Name = "radio_area_r";
            radio_area_r.Size = new Size(53, 21);
            radio_area_r.TabIndex = 39;
            radio_area_r.TabStop = true;
            radio_area_r.Text = "Área";
            radio_area_r.UseVisualStyleBackColor = true;
            radio_area_r.CheckedChanged += radio_area_r_CheckedChanged;
            // 
            // radio_perimetro_r
            // 
            radio_perimetro_r.AutoSize = true;
            radio_perimetro_r.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio_perimetro_r.Location = new Point(370, 100);
            radio_perimetro_r.Name = "radio_perimetro_r";
            radio_perimetro_r.Size = new Size(83, 21);
            radio_perimetro_r.TabIndex = 38;
            radio_perimetro_r.TabStop = true;
            radio_perimetro_r.Text = "Perímetro";
            radio_perimetro_r.UseVisualStyleBackColor = true;
            radio_perimetro_r.CheckedChanged += radio_perimetro_r_CheckedChanged;
            // 
            // label_erro_r
            // 
            label_erro_r.AutoSize = true;
            label_erro_r.Location = new Point(330, 70);
            label_erro_r.Name = "label_erro_r";
            label_erro_r.Size = new Size(0, 15);
            label_erro_r.TabIndex = 37;
            // 
            // label_resultado_r
            // 
            label_resultado_r.AutoSize = true;
            label_resultado_r.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_resultado_r.Location = new Point(585, 37);
            label_resultado_r.Name = "label_resultado_r";
            label_resultado_r.Size = new Size(52, 25);
            label_resultado_r.TabIndex = 36;
            label_resultado_r.Text = "?????";
            // 
            // label_r_b
            // 
            label_r_b.AutoSize = true;
            label_r_b.Location = new Point(565, 45);
            label_r_b.Name = "label_r_b";
            label_r_b.Size = new Size(15, 15);
            label_r_b.TabIndex = 35;
            label_r_b.Text = "=";
            // 
            // label_r_sinal_a
            // 
            label_r_sinal_a.AutoSize = true;
            label_r_sinal_a.Location = new Point(392, 44);
            label_r_sinal_a.Name = "label_r_sinal_a";
            label_r_sinal_a.Size = new Size(0, 15);
            label_r_sinal_a.TabIndex = 34;
            // 
            // input_numero_r_b
            // 
            input_numero_r_b.Location = new Point(415, 40);
            input_numero_r_b.Name = "input_numero_r_b";
            input_numero_r_b.Size = new Size(50, 23);
            input_numero_r_b.TabIndex = 33;
            // 
            // input_numero_r_a
            // 
            input_numero_r_a.Location = new Point(330, 40);
            input_numero_r_a.Name = "input_numero_r_a";
            input_numero_r_a.Size = new Size(50, 23);
            input_numero_r_a.TabIndex = 32;
            // 
            // button_calcular_r
            // 
            button_calcular_r.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_calcular_r.Location = new Point(495, 140);
            button_calcular_r.Name = "button_calcular_r";
            button_calcular_r.Size = new Size(90, 40);
            button_calcular_r.TabIndex = 31;
            button_calcular_r.Text = "Calcular";
            button_calcular_r.UseVisualStyleBackColor = true;
            button_calcular_r.Click += button_calcular_r_Click;
            // 
            // button_limpar_r
            // 
            button_limpar_r.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_limpar_r.Location = new Point(495, 95);
            button_limpar_r.Name = "button_limpar_r";
            button_limpar_r.Size = new Size(90, 40);
            button_limpar_r.TabIndex = 30;
            button_limpar_r.Text = "Limpar";
            button_limpar_r.UseVisualStyleBackColor = true;
            button_limpar_r.Click += button_limpar_r_Click;
            // 
            // label_r_sinal_b
            // 
            label_r_sinal_b.AutoSize = true;
            label_r_sinal_b.Location = new Point(477, 44);
            label_r_sinal_b.Name = "label_r_sinal_b";
            label_r_sinal_b.Size = new Size(0, 15);
            label_r_sinal_b.TabIndex = 43;
            // 
            // input_numero_r_c
            // 
            input_numero_r_c.Location = new Point(500, 40);
            input_numero_r_c.Name = "input_numero_r_c";
            input_numero_r_c.Size = new Size(50, 23);
            input_numero_r_c.TabIndex = 42;
            // 
            // button_calc_3
            // 
            button_calc_3.Location = new Point(345, 202);
            button_calc_3.Name = "button_calc_3";
            button_calc_3.Size = new Size(150, 23);
            button_calc_3.TabIndex = 44;
            button_calc_3.Text = "Calc. de circunferências";
            button_calc_3.UseVisualStyleBackColor = true;
            button_calc_3.Click += button_calc_3_Click;
            // 
            // label_lado_a
            // 
            label_lado_a.AutoSize = true;
            label_lado_a.Location = new Point(39, 22);
            label_lado_a.Name = "label_lado_a";
            label_lado_a.Size = new Size(33, 15);
            label_lado_a.TabIndex = 45;
            label_lado_a.Text = "Lado";
            // 
            // label_largura
            // 
            label_largura.AutoSize = true;
            label_largura.Location = new Point(331, 22);
            label_largura.Name = "label_largura";
            label_largura.Size = new Size(47, 15);
            label_largura.TabIndex = 46;
            label_largura.Text = "Largura";
            // 
            // label_altura
            // 
            label_altura.AutoSize = true;
            label_altura.Location = new Point(420, 22);
            label_altura.Name = "label_altura";
            label_altura.Size = new Size(39, 15);
            label_altura.TabIndex = 47;
            label_altura.Text = "Altura";
            // 
            // label_lado_b
            // 
            label_lado_b.AutoSize = true;
            label_lado_b.Location = new Point(128, 22);
            label_lado_b.Name = "label_lado_b";
            label_lado_b.Size = new Size(33, 15);
            label_lado_b.TabIndex = 48;
            label_lado_b.Text = "Lado";
            // 
            // label_comprimento
            // 
            label_comprimento.AutoSize = true;
            label_comprimento.Location = new Point(484, 22);
            label_comprimento.Name = "label_comprimento";
            label_comprimento.Size = new Size(82, 15);
            label_comprimento.TabIndex = 49;
            label_comprimento.Text = "Comprimento";
            // 
            // calculadora_quadrilateros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(664, 251);
            Controls.Add(label_comprimento);
            Controls.Add(label_lado_b);
            Controls.Add(label_altura);
            Controls.Add(label_largura);
            Controls.Add(label_lado_a);
            Controls.Add(button_calc_3);
            Controls.Add(label_r_sinal_b);
            Controls.Add(input_numero_r_c);
            Controls.Add(radio_volume_r);
            Controls.Add(radio_area_r);
            Controls.Add(radio_perimetro_r);
            Controls.Add(label_erro_r);
            Controls.Add(label_resultado_r);
            Controls.Add(label_r_b);
            Controls.Add(label_r_sinal_a);
            Controls.Add(input_numero_r_b);
            Controls.Add(input_numero_r_a);
            Controls.Add(button_calcular_r);
            Controls.Add(button_limpar_r);
            Controls.Add(button_calc_1);
            Controls.Add(radio_volume_q);
            Controls.Add(radio_area_q);
            Controls.Add(radio_perimetro_q);
            Controls.Add(label_erro_q);
            Controls.Add(label_resultado_q);
            Controls.Add(label_q_b);
            Controls.Add(label_q_sinal);
            Controls.Add(input_numero_q_b);
            Controls.Add(input_numero_q_a);
            Controls.Add(button_calcular_q);
            Controls.Add(button_limpar_q);
            Name = "calculadora_quadrilateros";
            Text = "Calculadora de quadriláteros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_erro_q;
        private Label label_resultado_q;
        private Label label_q_b;
        private Label label_q_sinal;
        private TextBox input_numero_q_b;
        private TextBox input_numero_q_a;
        private Button button_calcular_q;
        private Button button_limpar_q;
        private RadioButton radio_perimetro_q;
        private RadioButton radio_area_q;
        private RadioButton radio_volume_q;
        private Button button_calc_1;
        private RadioButton radio_volume_r;
        private RadioButton radio_area_r;
        private RadioButton radio_perimetro_r;
        private Label label_erro_r;
        private Label label_resultado_r;
        private Label label_r_b;
        private Label label_r_sinal_a;
        private TextBox input_numero_r_b;
        private TextBox input_numero_r_a;
        private Button button_calcular_r;
        private Button button_limpar_r;
        private Label label_r_sinal_b;
        private TextBox input_numero_r_c;
        private Button button_calc_3;
        private Label label_lado_a;
        private Label label_largura;
        private Label label_altura;
        private Label label_lado_b;
        private Label label_comprimento;
    }
}
