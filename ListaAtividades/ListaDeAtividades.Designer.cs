﻿namespace ListaAtividades
{
    partial class ListaDeAtividades
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
            textBoxAtividadeEmAndamento = new TextBox();
            buttonFinalizar = new Button();
            dataGridViewAtividades = new DataGridView();
            buttonAtualizar = new Button();
            buttonCriar = new Button();
            labelErro = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtividades).BeginInit();
            SuspendLayout();
            // 
            // textBoxAtividadeEmAndamento
            // 
            textBoxAtividadeEmAndamento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAtividadeEmAndamento.Location = new Point(20, 18);
            textBoxAtividadeEmAndamento.Name = "textBoxAtividadeEmAndamento";
            textBoxAtividadeEmAndamento.ReadOnly = true;
            textBoxAtividadeEmAndamento.Size = new Size(500, 25);
            textBoxAtividadeEmAndamento.TabIndex = 0;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.Location = new Point(540, 18);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(90, 30);
            buttonFinalizar.TabIndex = 1;
            buttonFinalizar.Text = "Finalizar";
            buttonFinalizar.UseVisualStyleBackColor = true;
            buttonFinalizar.Click += buttonFinalizar_Click;
            // 
            // dataGridViewAtividades
            // 
            dataGridViewAtividades.AllowUserToAddRows = false;
            dataGridViewAtividades.AllowUserToDeleteRows = false;
            dataGridViewAtividades.AllowUserToResizeColumns = false;
            dataGridViewAtividades.AllowUserToResizeRows = false;
            dataGridViewAtividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAtividades.Location = new Point(20, 80);
            dataGridViewAtividades.MultiSelect = false;
            dataGridViewAtividades.Name = "dataGridViewAtividades";
            dataGridViewAtividades.ReadOnly = true;
            dataGridViewAtividades.Size = new Size(500, 325);
            dataGridViewAtividades.TabIndex = 2;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.Location = new Point(540, 80);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(90, 30);
            buttonAtualizar.TabIndex = 3;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = true;
            buttonAtualizar.Click += buttonAtualizar_Click;
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(540, 375);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(90, 30);
            buttonCriar.TabIndex = 4;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            buttonCriar.Click += buttonCriar_Click;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErro.Location = new Point(20, 50);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(17, 17);
            labelErro.TabIndex = 5;
            labelErro.Text = "...";
            // 
            // ListaDeAtividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 421);
            Controls.Add(labelErro);
            Controls.Add(buttonCriar);
            Controls.Add(buttonAtualizar);
            Controls.Add(dataGridViewAtividades);
            Controls.Add(buttonFinalizar);
            Controls.Add(textBoxAtividadeEmAndamento);
            Name = "ListaDeAtividades";
            Text = "Lista de atividades";
            Load += ListaDeAtividades_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAtividadeEmAndamento;
        private Button buttonFinalizar;
        private DataGridView dataGridViewAtividades;
        private Button buttonAtualizar;
        private Button buttonCriar;
        private Label labelErro;
    }
}
