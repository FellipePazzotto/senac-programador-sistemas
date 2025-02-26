namespace login
{
    partial class FormLogin
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
            inputEmail = new TextBox();
            inputSenha = new TextBox();
            labelEmail = new Label();
            labelSenha = new Label();
            buttonLogin = new Button();
            labelResultado = new Label();
            SuspendLayout();
            // 
            // inputEmail
            // 
            inputEmail.Font = new Font("Segoe UI", 12F);
            inputEmail.Location = new Point(200, 120);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(350, 29);
            inputEmail.TabIndex = 0;
            // 
            // inputSenha
            // 
            inputSenha.Font = new Font("Segoe UI", 12F);
            inputSenha.Location = new Point(200, 185);
            inputSenha.Name = "inputSenha";
            inputSenha.Size = new Size(350, 29);
            inputSenha.TabIndex = 1;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(200, 99);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(48, 18);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Arial", 12.25F);
            labelSenha.Location = new Point(200, 163);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(56, 19);
            labelSenha.TabIndex = 3;
            labelSenha.Text = "Senha";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.GradientActiveCaption;
            buttonLogin.FlatStyle = FlatStyle.Popup;
            buttonLogin.Font = new Font("Arial", 12.7F);
            buttonLogin.Location = new Point(250, 265);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(250, 40);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Fazer login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Arial", 10F);
            labelResultado.Location = new Point(250, 246);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(19, 16);
            labelResultado.TabIndex = 5;
            labelResultado.Text = "...";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(784, 411);
            Controls.Add(labelResultado);
            Controls.Add(buttonLogin);
            Controls.Add(labelSenha);
            Controls.Add(labelEmail);
            Controls.Add(inputSenha);
            Controls.Add(inputEmail);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputEmail;
        private TextBox inputSenha;
        private Label labelEmail;
        private Label labelSenha;
        private Button buttonLogin;
        private Label labelResultado;
    }
}
