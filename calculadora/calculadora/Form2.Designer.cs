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
            label_a = new Label();
            input_numero_b = new TextBox();
            input_numero_a = new TextBox();
            button_calcular = new Button();
            button_limpar = new Button();
            button_dividido = new Button();
            button_vezes = new Button();
            button_menos = new Button();
            button_mais = new Button();
            SuspendLayout();
            // 
            // label_erro
            // 
            label_erro.AutoSize = true;
            label_erro.Location = new Point(34, 56);
            label_erro.Name = "label_erro";
            label_erro.Size = new Size(0, 15);
            label_erro.TabIndex = 23;
            // 
            // label_resultado
            // 
            label_resultado.AutoSize = true;
            label_resultado.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_resultado.Location = new Point(200, 33);
            label_resultado.Name = "label_resultado";
            label_resultado.Size = new Size(52, 25);
            label_resultado.TabIndex = 22;
            label_resultado.Text = "?????";
            // 
            // label_b
            // 
            label_b.AutoSize = true;
            label_b.Location = new Point(180, 39);
            label_b.Name = "label_b";
            label_b.Size = new Size(15, 15);
            label_b.TabIndex = 21;
            label_b.Text = "=";
            // 
            // label_a
            // 
            label_a.AutoSize = true;
            label_a.Location = new Point(97, 39);
            label_a.Name = "label_a";
            label_a.Size = new Size(0, 15);
            label_a.TabIndex = 20;
            // 
            // input_numero_b
            // 
            input_numero_b.Location = new Point(120, 35);
            input_numero_b.Name = "input_numero_b";
            input_numero_b.Size = new Size(50, 23);
            input_numero_b.TabIndex = 19;
            // 
            // input_numero_a
            // 
            input_numero_a.Location = new Point(35, 35);
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
            // 
            // button_limpar
            // 
            button_limpar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_limpar.Location = new Point(160, 105);
            button_limpar.Name = "button_limpar";
            button_limpar.Size = new Size(90, 40);
            button_limpar.TabIndex = 16;
            button_limpar.Text = "Limpar";
            button_limpar.UseVisualStyleBackColor = true;
            // 
            // button_dividido
            // 
            button_dividido.Location = new Point(40, 195);
            button_dividido.Name = "button_dividido";
            button_dividido.Size = new Size(100, 30);
            button_dividido.TabIndex = 15;
            button_dividido.Text = "Divisão";
            button_dividido.UseVisualStyleBackColor = true;
            // 
            // button_vezes
            // 
            button_vezes.Location = new Point(40, 160);
            button_vezes.Name = "button_vezes";
            button_vezes.Size = new Size(100, 30);
            button_vezes.TabIndex = 14;
            button_vezes.Text = "Multiplicação";
            button_vezes.UseVisualStyleBackColor = true;
            // 
            // button_menos
            // 
            button_menos.Location = new Point(40, 125);
            button_menos.Name = "button_menos";
            button_menos.Size = new Size(100, 30);
            button_menos.TabIndex = 13;
            button_menos.Text = "Subtração";
            button_menos.UseVisualStyleBackColor = true;
            // 
            // button_mais
            // 
            button_mais.Location = new Point(40, 90);
            button_mais.Name = "button_mais";
            button_mais.Size = new Size(100, 30);
            button_mais.TabIndex = 12;
            button_mais.Text = "Soma";
            button_mais.UseVisualStyleBackColor = true;
            // 
            // calculadora_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(284, 261);
            Controls.Add(label_erro);
            Controls.Add(label_resultado);
            Controls.Add(label_b);
            Controls.Add(label_a);
            Controls.Add(input_numero_b);
            Controls.Add(input_numero_a);
            Controls.Add(button_calcular);
            Controls.Add(button_limpar);
            Controls.Add(button_dividido);
            Controls.Add(button_vezes);
            Controls.Add(button_menos);
            Controls.Add(button_mais);
            Name = "calculadora_2";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_erro;
        private Label label_resultado;
        private Label label_b;
        private Label label_a;
        private TextBox input_numero_b;
        private TextBox input_numero_a;
        private Button button_calcular;
        private Button button_limpar;
        private Button button_dividido;
        private Button button_vezes;
        private Button button_menos;
        private Button button_mais;
    }
}