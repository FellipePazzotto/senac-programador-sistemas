namespace login
{
    partial class form_login
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
            input_email = new TextBox();
            input_senha = new TextBox();
            label_email = new Label();
            label_senha = new Label();
            button_login = new Button();
            label_resultado = new Label();
            SuspendLayout();
            // 
            // input_email
            // 
            input_email.Font = new Font("Segoe UI", 12F);
            input_email.Location = new Point(200, 120);
            input_email.Name = "input_email";
            input_email.Size = new Size(350, 29);
            input_email.TabIndex = 0;
            // 
            // input_senha
            // 
            input_senha.Font = new Font("Segoe UI", 12F);
            input_senha.Location = new Point(200, 185);
            input_senha.Name = "input_senha";
            input_senha.Size = new Size(350, 29);
            input_senha.TabIndex = 1;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_email.Location = new Point(200, 99);
            label_email.Name = "label_email";
            label_email.Size = new Size(48, 18);
            label_email.TabIndex = 2;
            label_email.Text = "Email";
            // 
            // label_senha
            // 
            label_senha.AutoSize = true;
            label_senha.Font = new Font("Arial", 12.25F);
            label_senha.Location = new Point(200, 163);
            label_senha.Name = "label_senha";
            label_senha.Size = new Size(56, 19);
            label_senha.TabIndex = 3;
            label_senha.Text = "Senha";
            // 
            // button_login
            // 
            button_login.BackColor = SystemColors.GradientActiveCaption;
            button_login.FlatStyle = FlatStyle.Popup;
            button_login.Font = new Font("Arial", 12.7F);
            button_login.Location = new Point(250, 265);
            button_login.Name = "button_login";
            button_login.Size = new Size(250, 40);
            button_login.TabIndex = 4;
            button_login.Text = "Fazer login";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += buttonLogin_Click;
            // 
            // label_resultado
            // 
            label_resultado.AutoSize = true;
            label_resultado.Font = new Font("Arial", 10F);
            label_resultado.Location = new Point(250, 246);
            label_resultado.Name = "label_resultado";
            label_resultado.Size = new Size(19, 16);
            label_resultado.TabIndex = 5;
            label_resultado.Text = "...";
            // 
            // form_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(784, 411);
            Controls.Add(label_resultado);
            Controls.Add(button_login);
            Controls.Add(label_senha);
            Controls.Add(label_email);
            Controls.Add(input_senha);
            Controls.Add(input_email);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "form_login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input_email;
        private TextBox input_senha;
        private Label label_email;
        private Label label_senha;
        private Button button_login;
        private Label label_resultado;
    }
}
