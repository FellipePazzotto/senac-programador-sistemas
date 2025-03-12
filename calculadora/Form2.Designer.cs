namespace calculadora
{
    partial class calculadora_2
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
            label_erro = new Label();
            label_resultado = new Label();
            label_b = new Label();
            label_sinal = new Label();
            input_numero_b = new TextBox();
            input_numero_a = new TextBox();
            button_calcular = new Button();
            button_limpar = new Button();
            radio_perimetro = new RadioButton();
            radio_area = new RadioButton();
            radio_volume = new RadioButton();
            input_numero_c = new TextBox();
            input_numero_d = new TextBox();
            button_trocar = new Button();
            SuspendLayout();
            // 
            // label_erro
            // 
            label_erro.AutoSize = true;
            label_erro.Location = new Point(35, 90);
            label_erro.Name = "label_erro";
            label_erro.Size = new Size(0, 15);
            label_erro.TabIndex = 23;
            // 
            // label_resultado
            // 
            label_resultado.AutoSize = true;
            label_resultado.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_resultado.Location = new Point(200, 46);
            label_resultado.Name = "label_resultado";
            label_resultado.Size = new Size(52, 25);
            label_resultado.TabIndex = 22;
            label_resultado.Text = "?????";
            // 
            // label_b
            // 
            label_b.AutoSize = true;
            label_b.Location = new Point(180, 50);
            label_b.Name = "label_b";
            label_b.Size = new Size(15, 15);
            label_b.TabIndex = 21;
            label_b.Text = "=";
            // 
            // label_sinal
            // 
            label_sinal.AutoSize = true;
            label_sinal.Location = new Point(97, 50);
            label_sinal.Name = "label_sinal";
            label_sinal.Size = new Size(0, 15);
            label_sinal.TabIndex = 20;
            // 
            // input_numero_b
            // 
            input_numero_b.Location = new Point(120, 30);
            input_numero_b.Name = "input_numero_b";
            input_numero_b.Size = new Size(50, 23);
            input_numero_b.TabIndex = 19;
            // 
            // input_numero_a
            // 
            input_numero_a.Location = new Point(35, 30);
            input_numero_a.Name = "input_numero_a";
            input_numero_a.Size = new Size(50, 23);
            input_numero_a.TabIndex = 18;
            // 
            // button_calcular
            // 
            button_calcular.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_calcular.Location = new Point(160, 155);
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
            button_limpar.Location = new Point(160, 110);
            button_limpar.Name = "button_limpar";
            button_limpar.Size = new Size(90, 40);
            button_limpar.TabIndex = 16;
            button_limpar.Text = "Limpar";
            button_limpar.UseVisualStyleBackColor = true;
            // 
            // radio_perimetro
            // 
            radio_perimetro.AutoSize = true;
            radio_perimetro.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio_perimetro.Location = new Point(35, 115);
            radio_perimetro.Name = "radio_perimetro";
            radio_perimetro.Size = new Size(83, 21);
            radio_perimetro.TabIndex = 24;
            radio_perimetro.TabStop = true;
            radio_perimetro.Text = "Perímetro";
            radio_perimetro.UseVisualStyleBackColor = true;
            radio_perimetro.CheckedChanged += radio_perimetro_CheckedChanged;
            // 
            // radio_area
            // 
            radio_area.AutoSize = true;
            radio_area.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio_area.Location = new Point(35, 140);
            radio_area.Name = "radio_area";
            radio_area.Size = new Size(53, 21);
            radio_area.TabIndex = 25;
            radio_area.TabStop = true;
            radio_area.Text = "Área";
            radio_area.UseVisualStyleBackColor = true;
            // 
            // radio_volume
            // 
            radio_volume.AutoSize = true;
            radio_volume.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio_volume.Location = new Point(35, 165);
            radio_volume.Name = "radio_volume";
            radio_volume.Size = new Size(69, 21);
            radio_volume.TabIndex = 26;
            radio_volume.TabStop = true;
            radio_volume.Text = "Volume";
            radio_volume.UseVisualStyleBackColor = true;
            radio_volume.CheckedChanged += radio_volume_CheckedChanged;
            // 
            // input_numero_c
            // 
            input_numero_c.Location = new Point(35, 60);
            input_numero_c.Name = "input_numero_c";
            input_numero_c.Size = new Size(50, 23);
            input_numero_c.TabIndex = 27;
            // 
            // input_numero_d
            // 
            input_numero_d.Location = new Point(120, 60);
            input_numero_d.Name = "input_numero_d";
            input_numero_d.Size = new Size(50, 23);
            input_numero_d.TabIndex = 28;
            // 
            // button_trocar
            // 
            button_trocar.Location = new Point(70, 205);
            button_trocar.Name = "button_trocar";
            button_trocar.Size = new Size(150, 23);
            button_trocar.TabIndex = 29;
            button_trocar.Text = "Trocar de calculadora";
            button_trocar.UseVisualStyleBackColor = true;
            button_trocar.Click += button_trocar_Click;
            // 
            // calculadora_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(284, 241);
            Controls.Add(button_trocar);
            Controls.Add(input_numero_d);
            Controls.Add(input_numero_c);
            Controls.Add(radio_volume);
            Controls.Add(radio_area);
            Controls.Add(radio_perimetro);
            Controls.Add(label_erro);
            Controls.Add(label_resultado);
            Controls.Add(label_b);
            Controls.Add(label_sinal);
            Controls.Add(input_numero_b);
            Controls.Add(input_numero_a);
            Controls.Add(button_calcular);
            Controls.Add(button_limpar);
            Name = "calculadora_2";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_erro;
        private Label label_resultado;
        private Label label_b;
        private Label label_sinal;
        private TextBox input_numero_b;
        private TextBox input_numero_a;
        private Button button_calcular;
        private Button button_limpar;
        private RadioButton radio_perimetro;
        private RadioButton radio_area;
        private RadioButton radio_volume;
        private TextBox input_numero_c;
        private TextBox input_numero_d;
        private Button button_trocar;
    }
}