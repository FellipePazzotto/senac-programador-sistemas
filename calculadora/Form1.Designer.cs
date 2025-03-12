namespace calculadora
{
    partial class calculadora_1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_limpar = new Button();
            button_calcular = new Button();
            input_numero_a = new TextBox();
            input_numero_b = new TextBox();
            label_sinal = new Label();
            label_b = new Label();
            label_resultado = new Label();
            label_erro = new Label();
            radio_menos = new RadioButton();
            radio_mais = new RadioButton();
            radio_vezes = new RadioButton();
            radio_dividido = new RadioButton();
            button_trocar = new Button();
            SuspendLayout();
            // 
            // button_limpar
            // 
            button_limpar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_limpar.Location = new Point(160, 100);
            button_limpar.Name = "button_limpar";
            button_limpar.Size = new Size(90, 40);
            button_limpar.TabIndex = 4;
            button_limpar.Text = "Limpar";
            button_limpar.UseVisualStyleBackColor = true;
            button_limpar.Click += button_limpar_Click;
            // 
            // button_calcular
            // 
            button_calcular.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_calcular.Location = new Point(160, 150);
            button_calcular.Name = "button_calcular";
            button_calcular.Size = new Size(90, 40);
            button_calcular.TabIndex = 5;
            button_calcular.Text = "Calcular";
            button_calcular.UseVisualStyleBackColor = true;
            button_calcular.Click += button_calcular_Click;
            // 
            // input_numero_a
            // 
            input_numero_a.Location = new Point(35, 30);
            input_numero_a.Name = "input_numero_a";
            input_numero_a.Size = new Size(50, 23);
            input_numero_a.TabIndex = 6;
            // 
            // input_numero_b
            // 
            input_numero_b.Location = new Point(120, 30);
            input_numero_b.Name = "input_numero_b";
            input_numero_b.Size = new Size(50, 23);
            input_numero_b.TabIndex = 7;
            // 
            // label_sinal
            // 
            label_sinal.AutoSize = true;
            label_sinal.Location = new Point(97, 34);
            label_sinal.Name = "label_sinal";
            label_sinal.Size = new Size(0, 15);
            label_sinal.TabIndex = 8;
            // 
            // label_b
            // 
            label_b.AutoSize = true;
            label_b.Location = new Point(180, 34);
            label_b.Name = "label_b";
            label_b.Size = new Size(15, 15);
            label_b.TabIndex = 9;
            label_b.Text = "=";
            // 
            // label_resultado
            // 
            label_resultado.AutoSize = true;
            label_resultado.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_resultado.Location = new Point(200, 28);
            label_resultado.Name = "label_resultado";
            label_resultado.Size = new Size(52, 25);
            label_resultado.TabIndex = 10;
            label_resultado.Text = "?????";
            // 
            // label_erro
            // 
            label_erro.AutoSize = true;
            label_erro.Location = new Point(35, 60);
            label_erro.Name = "label_erro";
            label_erro.Size = new Size(0, 15);
            label_erro.TabIndex = 11;
            // 
            // radio_menos
            // 
            radio_menos.AutoSize = true;
            radio_menos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio_menos.Location = new Point(35, 110);
            radio_menos.Name = "radio_menos";
            radio_menos.Size = new Size(85, 21);
            radio_menos.TabIndex = 12;
            radio_menos.TabStop = true;
            radio_menos.Text = "Subtração";
            radio_menos.UseVisualStyleBackColor = true;
            radio_menos.CheckedChanged += radio_menos_CheckedChanged;
            // 
            // radio_mais
            // 
            radio_mais.AutoSize = true;
            radio_mais.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio_mais.Location = new Point(35, 85);
            radio_mais.Name = "radio_mais";
            radio_mais.Size = new Size(59, 21);
            radio_mais.TabIndex = 13;
            radio_mais.TabStop = true;
            radio_mais.Text = "Soma";
            radio_mais.UseVisualStyleBackColor = true;
            radio_mais.CheckedChanged += radio_mais_CheckedChanged;
            // 
            // radio_vezes
            // 
            radio_vezes.AutoSize = true;
            radio_vezes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio_vezes.Location = new Point(35, 135);
            radio_vezes.Name = "radio_vezes";
            radio_vezes.Size = new Size(103, 21);
            radio_vezes.TabIndex = 15;
            radio_vezes.TabStop = true;
            radio_vezes.Text = "Multiplicação";
            radio_vezes.UseVisualStyleBackColor = true;
            radio_vezes.CheckedChanged += radio_vezes_CheckedChanged;
            // 
            // radio_dividido
            // 
            radio_dividido.AutoSize = true;
            radio_dividido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio_dividido.Location = new Point(35, 160);
            radio_dividido.Name = "radio_dividido";
            radio_dividido.Size = new Size(68, 21);
            radio_dividido.TabIndex = 14;
            radio_dividido.TabStop = true;
            radio_dividido.Text = "Divisão";
            radio_dividido.UseVisualStyleBackColor = true;
            radio_dividido.CheckedChanged += radio_dividido_CheckedChanged;
            // 
            // button_trocar
            // 
            button_trocar.Location = new Point(70, 205);
            button_trocar.Name = "button_trocar";
            button_trocar.Size = new Size(150, 23);
            button_trocar.TabIndex = 16;
            button_trocar.Text = "Trocar de calculadora";
            button_trocar.UseVisualStyleBackColor = true;
            button_trocar.Click += button_trocar_Click;
            // 
            // calculadora_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(284, 241);
            Controls.Add(button_trocar);
            Controls.Add(radio_vezes);
            Controls.Add(radio_dividido);
            Controls.Add(radio_mais);
            Controls.Add(radio_menos);
            Controls.Add(label_erro);
            Controls.Add(label_resultado);
            Controls.Add(label_b);
            Controls.Add(label_sinal);
            Controls.Add(input_numero_b);
            Controls.Add(input_numero_a);
            Controls.Add(button_calcular);
            Controls.Add(button_limpar);
            Name = "calculadora_1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_limpar;
        private Button button_calcular;
        private TextBox input_numero_a;
        private TextBox input_numero_b;
        private Label label_sinal;
        private Label label_b;
        private Label label_resultado;
        private Label label_erro;
        private RadioButton radio_menos;
        private RadioButton radio_mais;
        private RadioButton radio_vezes;
        private RadioButton radio_dividido;
        private Button button_trocar;
    }
}
