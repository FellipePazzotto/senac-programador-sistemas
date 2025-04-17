namespace ListaAtividades
{
    partial class CriarAtividade
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
            labelTitulo = new Label();
            labelErro = new Label();
            textBoxTitulo = new TextBox();
            buttonDescartar = new Button();
            buttonCriar = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(60, 45);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(47, 20);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Título";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErro.Location = new Point(15, 175);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(17, 17);
            labelErro.TabIndex = 1;
            labelErro.Text = "...";
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTitulo.Location = new Point(60, 73);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(210, 25);
            textBoxTitulo.TabIndex = 2;
            // 
            // buttonDescartar
            // 
            buttonDescartar.Location = new Point(60, 110);
            buttonDescartar.Name = "buttonDescartar";
            buttonDescartar.Size = new Size(100, 30);
            buttonDescartar.TabIndex = 3;
            buttonDescartar.Text = "Descartar";
            buttonDescartar.UseVisualStyleBackColor = true;
            buttonDescartar.Click += buttonDescartar_Click;
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(170, 110);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(100, 30);
            buttonCriar.TabIndex = 4;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            buttonCriar.Click += buttonCriar_Click;
            // 
            // CriarAtividade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 211);
            Controls.Add(buttonCriar);
            Controls.Add(buttonDescartar);
            Controls.Add(textBoxTitulo);
            Controls.Add(labelErro);
            Controls.Add(labelTitulo);
            Name = "CriarAtividade";
            Text = "Criação de atividade";
            Load += CriarAtividade_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelErro;
        private TextBox textBoxTitulo;
        private Button buttonDescartar;
        private Button buttonCriar;
    }
}