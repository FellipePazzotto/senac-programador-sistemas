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
            input_email_log = new TextBox();
            input_senha_log = new TextBox();
            label_email_log = new Label();
            label_senha_log = new Label();
            button_login = new Button();
            label_resultado_log = new Label();
            input_email_cad = new TextBox();
            input_senha_cad = new TextBox();
            label_email_cad = new Label();
            label_senha_cad = new Label();
            button_cadastrar = new Button();
            label_resultado_cad = new Label();
            SuspendLayout();
            // 
            // input_email_log
            // 
            input_email_log.Font = new Font("Segoe UI", 12F);
            input_email_log.Location = new Point(100, 120);
            input_email_log.Name = "input_email_log";
            input_email_log.Size = new Size(250, 29);
            input_email_log.TabIndex = 0;
            // 
            // input_senha_log
            // 
            input_senha_log.Font = new Font("Segoe UI", 12F);
            input_senha_log.Location = new Point(100, 185);
            input_senha_log.Name = "input_senha_log";
            input_senha_log.Size = new Size(250, 29);
            input_senha_log.TabIndex = 1;
            // 
            // label_email_log
            // 
            label_email_log.AutoSize = true;
            label_email_log.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_email_log.Location = new Point(100, 99);
            label_email_log.Name = "label_email_log";
            label_email_log.Size = new Size(48, 18);
            label_email_log.TabIndex = 2;
            label_email_log.Text = "Email";
            // 
            // label_senha_log
            // 
            label_senha_log.AutoSize = true;
            label_senha_log.Font = new Font("Arial", 12.25F);
            label_senha_log.Location = new Point(100, 163);
            label_senha_log.Name = "label_senha_log";
            label_senha_log.Size = new Size(56, 19);
            label_senha_log.TabIndex = 3;
            label_senha_log.Text = "Senha";
            // 
            // button_login
            // 
            button_login.BackColor = SystemColors.GradientActiveCaption;
            button_login.FlatStyle = FlatStyle.Popup;
            button_login.Font = new Font("Arial", 12.7F);
            button_login.Location = new Point(125, 265);
            button_login.Name = "button_login";
            button_login.Size = new Size(200, 40);
            button_login.TabIndex = 4;
            button_login.Text = "Fazer login";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += buttonLogin_Click;
            // 
            // label_resultado_log
            // 
            label_resultado_log.AutoSize = true;
            label_resultado_log.Font = new Font("Arial", 10F);
            label_resultado_log.Location = new Point(125, 246);
            label_resultado_log.Name = "label_resultado_log";
            label_resultado_log.Size = new Size(19, 16);
            label_resultado_log.TabIndex = 5;
            label_resultado_log.Text = "...";
            // 
            // input_email_cad
            // 
            input_email_cad.Font = new Font("Segoe UI", 12F);
            input_email_cad.Location = new Point(490, 120);
            input_email_cad.Name = "input_email_cad";
            input_email_cad.Size = new Size(250, 29);
            input_email_cad.TabIndex = 6;
            // 
            // input_senha_cad
            // 
            input_senha_cad.Font = new Font("Segoe UI", 12F);
            input_senha_cad.Location = new Point(490, 185);
            input_senha_cad.Name = "input_senha_cad";
            input_senha_cad.Size = new Size(250, 29);
            input_senha_cad.TabIndex = 7;
            // 
            // label_email_cad
            // 
            label_email_cad.AutoSize = true;
            label_email_cad.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_email_cad.Location = new Point(490, 99);
            label_email_cad.Name = "label_email_cad";
            label_email_cad.Size = new Size(120, 18);
            label_email_cad.TabIndex = 8;
            label_email_cad.Text = "Cadastrar email";
            // 
            // label_senha_cad
            // 
            label_senha_cad.AutoSize = true;
            label_senha_cad.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_senha_cad.Location = new Point(490, 164);
            label_senha_cad.Name = "label_senha_cad";
            label_senha_cad.Size = new Size(124, 18);
            label_senha_cad.TabIndex = 9;
            label_senha_cad.Text = "Cadastrar senha";
            // 
            // button_cadastrar
            // 
            button_cadastrar.BackColor = SystemColors.GradientActiveCaption;
            button_cadastrar.FlatStyle = FlatStyle.Popup;
            button_cadastrar.Font = new Font("Arial", 12.7F);
            button_cadastrar.Location = new Point(510, 265);
            button_cadastrar.Name = "button_cadastrar";
            button_cadastrar.Size = new Size(200, 40);
            button_cadastrar.TabIndex = 10;
            button_cadastrar.Text = "Cadastrar";
            button_cadastrar.UseVisualStyleBackColor = false;
            button_cadastrar.Click += button_cadastrar_Click;
            // 
            // label_resultado_cad
            // 
            label_resultado_cad.AutoSize = true;
            label_resultado_cad.Font = new Font("Arial", 10F);
            label_resultado_cad.Location = new Point(510, 246);
            label_resultado_cad.Name = "label_resultado_cad";
            label_resultado_cad.Size = new Size(19, 16);
            label_resultado_cad.TabIndex = 11;
            label_resultado_cad.Text = "...";
            // 
            // form_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(834, 411);
            Controls.Add(label_resultado_cad);
            Controls.Add(button_cadastrar);
            Controls.Add(label_senha_cad);
            Controls.Add(label_email_cad);
            Controls.Add(input_senha_cad);
            Controls.Add(input_email_cad);
            Controls.Add(label_resultado_log);
            Controls.Add(button_login);
            Controls.Add(label_senha_log);
            Controls.Add(label_email_log);
            Controls.Add(input_senha_log);
            Controls.Add(input_email_log);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "form_login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input_email_log;
        private TextBox input_senha_log;
        private Label label_email_log;
        private Label label_senha_log;
        private Button button_login;
        private Label label_resultado_log;
        private TextBox input_email_cad;
        private TextBox input_senha_cad;
        private Label label_email_cad;
        private Label label_senha_cad;
        private Button button_cadastrar;
        private Label label_resultado_cad;
    }
}
