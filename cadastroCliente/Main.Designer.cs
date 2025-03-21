namespace cadastroCliente
{
    partial class Main
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
            input_nome = new TextBox();
            input_telefone = new MaskedTextBox();
            input_data_nasc = new MaskedTextBox();
            input_email = new TextBox();
            combo_genero = new ComboBox();
            input_nome_social = new TextBox();
            combo_etnia = new ComboBox();
            check_estrangeiro = new CheckBox();
            radio_tipo_pf = new RadioButton();
            radio_tipo_pj = new RadioButton();
            label_tipo = new Label();
            label_nome = new Label();
            label_data_nasc = new Label();
            label_telefone = new Label();
            label_email = new Label();
            label_genero = new Label();
            label_nome_social = new Label();
            label_etnia = new Label();
            input_logradouro = new TextBox();
            input_numero = new TextBox();
            input_complemento = new TextBox();
            input_bairro = new TextBox();
            input_municipio = new TextBox();
            combo_estado = new ComboBox();
            input_cep = new MaskedTextBox();
            label_logradouro = new Label();
            label_numero = new Label();
            label_complemento = new Label();
            label_bairro = new Label();
            label_municipio = new Label();
            label_estado = new Label();
            label_cep = new Label();
            button_cadastrar = new Button();
            button_limpar = new Button();
            label_titulo = new Label();
            label_erro = new Label();
            dataGridViewClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // input_nome
            // 
            input_nome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input_nome.Location = new Point(200, 105);
            input_nome.Name = "input_nome";
            input_nome.Size = new Size(300, 29);
            input_nome.TabIndex = 0;
            // 
            // input_telefone
            // 
            input_telefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input_telefone.Location = new Point(200, 185);
            input_telefone.Mask = "(99) 00000-0000";
            input_telefone.Name = "input_telefone";
            input_telefone.Size = new Size(130, 29);
            input_telefone.TabIndex = 1;
            // 
            // input_data_nasc
            // 
            input_data_nasc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input_data_nasc.Location = new Point(200, 145);
            input_data_nasc.Mask = "00/00/0000";
            input_data_nasc.Name = "input_data_nasc";
            input_data_nasc.Size = new Size(100, 29);
            input_data_nasc.TabIndex = 2;
            input_data_nasc.ValidatingType = typeof(DateTime);
            // 
            // input_email
            // 
            input_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input_email.Location = new Point(200, 225);
            input_email.Name = "input_email";
            input_email.Size = new Size(200, 29);
            input_email.TabIndex = 3;
            // 
            // combo_genero
            // 
            combo_genero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combo_genero.FormattingEnabled = true;
            combo_genero.Items.AddRange(new object[] { "Masculino", "Feminino", "Outros" });
            combo_genero.Location = new Point(200, 265);
            combo_genero.Name = "combo_genero";
            combo_genero.Size = new Size(150, 29);
            combo_genero.TabIndex = 4;
            // 
            // input_nome_social
            // 
            input_nome_social.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input_nome_social.Location = new Point(200, 305);
            input_nome_social.Name = "input_nome_social";
            input_nome_social.Size = new Size(300, 29);
            input_nome_social.TabIndex = 5;
            // 
            // combo_etnia
            // 
            combo_etnia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combo_etnia.FormattingEnabled = true;
            combo_etnia.Items.AddRange(new object[] { "Branco", "Negro", "Pardo", "Amarelo", "Indígena" });
            combo_etnia.Location = new Point(200, 345);
            combo_etnia.Name = "combo_etnia";
            combo_etnia.Size = new Size(121, 29);
            combo_etnia.TabIndex = 6;
            // 
            // check_estrangeiro
            // 
            check_estrangeiro.AutoSize = true;
            check_estrangeiro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            check_estrangeiro.Location = new Point(350, 147);
            check_estrangeiro.Name = "check_estrangeiro";
            check_estrangeiro.Size = new Size(199, 25);
            check_estrangeiro.TabIndex = 7;
            check_estrangeiro.Text = "O cliente é estrangeiro??";
            check_estrangeiro.UseVisualStyleBackColor = true;
            // 
            // radio_tipo_pf
            // 
            radio_tipo_pf.AutoSize = true;
            radio_tipo_pf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio_tipo_pf.Location = new Point(203, 69);
            radio_tipo_pf.Name = "radio_tipo_pf";
            radio_tipo_pf.Size = new Size(114, 25);
            radio_tipo_pf.TabIndex = 8;
            radio_tipo_pf.TabStop = true;
            radio_tipo_pf.Text = "Pessoa física";
            radio_tipo_pf.UseVisualStyleBackColor = true;
            // 
            // radio_tipo_pj
            // 
            radio_tipo_pj.AutoSize = true;
            radio_tipo_pj.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radio_tipo_pj.Location = new Point(350, 69);
            radio_tipo_pj.Name = "radio_tipo_pj";
            radio_tipo_pj.Size = new Size(130, 25);
            radio_tipo_pj.TabIndex = 9;
            radio_tipo_pj.TabStop = true;
            radio_tipo_pj.Text = "Pessoa jurídica";
            radio_tipo_pj.UseVisualStyleBackColor = true;
            // 
            // label_tipo
            // 
            label_tipo.AutoSize = true;
            label_tipo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_tipo.Location = new Point(74, 70);
            label_tipo.Name = "label_tipo";
            label_tipo.Size = new Size(123, 21);
            label_tipo.TabIndex = 10;
            label_tipo.Text = "Tipo de cliente:";
            label_tipo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_nome
            // 
            label_nome.AutoSize = true;
            label_nome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_nome.Location = new Point(64, 109);
            label_nome.Name = "label_nome";
            label_nome.Size = new Size(134, 21);
            label_nome.TabIndex = 11;
            label_nome.Text = "Nome completo:";
            label_nome.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_data_nasc
            // 
            label_data_nasc.AutoSize = true;
            label_data_nasc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_data_nasc.Location = new Point(40, 149);
            label_data_nasc.Name = "label_data_nasc";
            label_data_nasc.Size = new Size(158, 21);
            label_data_nasc.TabIndex = 12;
            label_data_nasc.Text = "Data de nascimento:";
            label_data_nasc.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_telefone
            // 
            label_telefone.AutoSize = true;
            label_telefone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_telefone.Location = new Point(121, 189);
            label_telefone.Name = "label_telefone";
            label_telefone.Size = new Size(77, 21);
            label_telefone.TabIndex = 13;
            label_telefone.Text = "Telefone:";
            label_telefone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_email.Location = new Point(146, 229);
            label_email.Name = "label_email";
            label_email.Size = new Size(52, 21);
            label_email.TabIndex = 14;
            label_email.Text = "Email:";
            label_email.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_genero
            // 
            label_genero.AutoSize = true;
            label_genero.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_genero.Location = new Point(130, 269);
            label_genero.Name = "label_genero";
            label_genero.Size = new Size(68, 21);
            label_genero.TabIndex = 15;
            label_genero.Text = "Gênero:";
            label_genero.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_nome_social
            // 
            label_nome_social.AutoSize = true;
            label_nome_social.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_nome_social.Location = new Point(94, 309);
            label_nome_social.Name = "label_nome_social";
            label_nome_social.Size = new Size(104, 21);
            label_nome_social.TabIndex = 16;
            label_nome_social.Text = "Nome social:";
            label_nome_social.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_etnia
            // 
            label_etnia.AutoSize = true;
            label_etnia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_etnia.Location = new Point(149, 349);
            label_etnia.Name = "label_etnia";
            label_etnia.Size = new Size(49, 21);
            label_etnia.TabIndex = 17;
            label_etnia.Text = "Etnia:";
            label_etnia.TextAlign = ContentAlignment.MiddleRight;
            // 
            // input_logradouro
            // 
            input_logradouro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input_logradouro.Location = new Point(200, 405);
            input_logradouro.Name = "input_logradouro";
            input_logradouro.Size = new Size(250, 29);
            input_logradouro.TabIndex = 18;
            // 
            // input_numero
            // 
            input_numero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input_numero.Location = new Point(200, 445);
            input_numero.Name = "input_numero";
            input_numero.Size = new Size(80, 29);
            input_numero.TabIndex = 19;
            // 
            // input_complemento
            // 
            input_complemento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input_complemento.Location = new Point(200, 485);
            input_complemento.Name = "input_complemento";
            input_complemento.Size = new Size(200, 29);
            input_complemento.TabIndex = 20;
            // 
            // input_bairro
            // 
            input_bairro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input_bairro.Location = new Point(200, 525);
            input_bairro.Name = "input_bairro";
            input_bairro.Size = new Size(150, 29);
            input_bairro.TabIndex = 21;
            // 
            // input_municipio
            // 
            input_municipio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input_municipio.Location = new Point(200, 565);
            input_municipio.Name = "input_municipio";
            input_municipio.Size = new Size(180, 29);
            input_municipio.TabIndex = 22;
            // 
            // combo_estado
            // 
            combo_estado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combo_estado.FormattingEnabled = true;
            combo_estado.Items.AddRange(new object[] { "AC - Acre", "AL - Alagoas", "AP - Amapá", "AM - Amazonas", "BA - Bahia", "CE - Ceará", "DF - Distrito Federal", "ES - Espírito Santo", "GO - Goiás", "MA - Maranhão", "MT - Mato Grosso", "MS - Mato Grosso do Sul", "MG - Minas Gerais", "PA - Pará", "PB - Paraíba", "PR - Paraná", "PE - Pernambuco", "PI - Piauí", "RJ - Rio de Janeiro", "RN - Rio Grande do Norte", "RS - Rio Grande do Sul", "RO - Rondônia", "RR - Roraima", "SC - Santa Catarina", "SP - São Paulo", "SE - Sergipe", "TO - Tocantins" });
            combo_estado.Location = new Point(200, 605);
            combo_estado.Name = "combo_estado";
            combo_estado.Size = new Size(200, 29);
            combo_estado.TabIndex = 23;
            // 
            // input_cep
            // 
            input_cep.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input_cep.Location = new Point(200, 645);
            input_cep.Mask = "00000-000";
            input_cep.Name = "input_cep";
            input_cep.Size = new Size(90, 29);
            input_cep.TabIndex = 24;
            // 
            // label_logradouro
            // 
            label_logradouro.AutoSize = true;
            label_logradouro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_logradouro.Location = new Point(97, 409);
            label_logradouro.Name = "label_logradouro";
            label_logradouro.Size = new Size(101, 21);
            label_logradouro.TabIndex = 25;
            label_logradouro.Text = "Logradouro:";
            label_logradouro.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_numero
            // 
            label_numero.AutoSize = true;
            label_numero.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_numero.Location = new Point(124, 449);
            label_numero.Name = "label_numero";
            label_numero.Size = new Size(74, 21);
            label_numero.TabIndex = 26;
            label_numero.Text = "Número:";
            label_numero.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_complemento
            // 
            label_complemento.AutoSize = true;
            label_complemento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_complemento.Location = new Point(79, 489);
            label_complemento.Name = "label_complemento";
            label_complemento.Size = new Size(119, 21);
            label_complemento.TabIndex = 27;
            label_complemento.Text = "Complemento:";
            label_complemento.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_bairro
            // 
            label_bairro.AutoSize = true;
            label_bairro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_bairro.Location = new Point(140, 529);
            label_bairro.Name = "label_bairro";
            label_bairro.Size = new Size(58, 21);
            label_bairro.TabIndex = 28;
            label_bairro.Text = "Bairro:";
            label_bairro.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_municipio
            // 
            label_municipio.AutoSize = true;
            label_municipio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_municipio.Location = new Point(111, 569);
            label_municipio.Name = "label_municipio";
            label_municipio.Size = new Size(87, 21);
            label_municipio.TabIndex = 29;
            label_municipio.Text = "Município:";
            label_municipio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_estado
            // 
            label_estado.AutoSize = true;
            label_estado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_estado.Location = new Point(135, 609);
            label_estado.Name = "label_estado";
            label_estado.Size = new Size(63, 21);
            label_estado.TabIndex = 30;
            label_estado.Text = "Estado:";
            label_estado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_cep
            // 
            label_cep.AutoSize = true;
            label_cep.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_cep.Location = new Point(156, 649);
            label_cep.Name = "label_cep";
            label_cep.Size = new Size(41, 21);
            label_cep.TabIndex = 31;
            label_cep.Text = "CEP:";
            label_cep.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button_cadastrar
            // 
            button_cadastrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_cadastrar.Location = new Point(545, 690);
            button_cadastrar.Name = "button_cadastrar";
            button_cadastrar.Size = new Size(100, 40);
            button_cadastrar.TabIndex = 32;
            button_cadastrar.Text = "Cadastrar";
            button_cadastrar.UseVisualStyleBackColor = true;
            button_cadastrar.Click += button_cadastrar_Click;
            // 
            // button_limpar
            // 
            button_limpar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_limpar.Location = new Point(430, 690);
            button_limpar.Name = "button_limpar";
            button_limpar.Size = new Size(100, 40);
            button_limpar.TabIndex = 33;
            button_limpar.Text = "Limpar";
            button_limpar.UseVisualStyleBackColor = true;
            // 
            // label_titulo
            // 
            label_titulo.AutoSize = true;
            label_titulo.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label_titulo.Location = new Point(225, 25);
            label_titulo.Name = "label_titulo";
            label_titulo.Size = new Size(206, 30);
            label_titulo.TabIndex = 34;
            label_titulo.Text = "Cadastro de clientes";
            // 
            // label_erro
            // 
            label_erro.AutoSize = true;
            label_erro.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_erro.Location = new Point(430, 661);
            label_erro.Name = "label_erro";
            label_erro.Size = new Size(0, 17);
            label_erro.TabIndex = 35;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewClientes.AllowUserToOrderColumns = true;
            dataGridViewClientes.AllowUserToResizeRows = false;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(580, 25);
            dataGridViewClientes.MultiSelect = false;
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.Size = new Size(580, 569);
            dataGridViewClientes.TabIndex = 36;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(dataGridViewClientes);
            Controls.Add(label_erro);
            Controls.Add(label_titulo);
            Controls.Add(button_limpar);
            Controls.Add(button_cadastrar);
            Controls.Add(label_cep);
            Controls.Add(label_estado);
            Controls.Add(label_municipio);
            Controls.Add(label_bairro);
            Controls.Add(label_complemento);
            Controls.Add(label_numero);
            Controls.Add(label_logradouro);
            Controls.Add(input_cep);
            Controls.Add(combo_estado);
            Controls.Add(input_municipio);
            Controls.Add(input_bairro);
            Controls.Add(input_complemento);
            Controls.Add(input_numero);
            Controls.Add(input_logradouro);
            Controls.Add(label_etnia);
            Controls.Add(label_nome_social);
            Controls.Add(label_genero);
            Controls.Add(label_email);
            Controls.Add(label_telefone);
            Controls.Add(label_data_nasc);
            Controls.Add(label_nome);
            Controls.Add(label_tipo);
            Controls.Add(radio_tipo_pj);
            Controls.Add(radio_tipo_pf);
            Controls.Add(check_estrangeiro);
            Controls.Add(combo_etnia);
            Controls.Add(input_nome_social);
            Controls.Add(combo_genero);
            Controls.Add(input_email);
            Controls.Add(input_data_nasc);
            Controls.Add(input_telefone);
            Controls.Add(input_nome);
            ForeColor = SystemColors.ControlText;
            Name = "Main";
            Text = "Cadastro de clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input_nome;
        private MaskedTextBox input_telefone;
        private MaskedTextBox input_data_nasc;
        private TextBox input_email;
        private ComboBox combo_genero;
        private TextBox input_nome_social;
        private ComboBox combo_etnia;
        private CheckBox check_estrangeiro;
        private RadioButton radio_tipo_pf;
        private RadioButton radio_tipo_pj;
        private Label label_tipo;
        private Label label_nome;
        private Label label_data_nasc;
        private Label label_telefone;
        private Label label_email;
        private Label label_genero;
        private Label label_nome_social;
        private Label label_etnia;
        private TextBox input_logradouro;
        private TextBox input_numero;
        private TextBox input_complemento;
        private TextBox input_bairro;
        private TextBox input_municipio;
        private ComboBox combo_estado;
        private MaskedTextBox input_cep;
        private Label label_logradouro;
        private Label label_numero;
        private Label label_complemento;
        private Label label_bairro;
        private Label label_municipio;
        private Label label_estado;
        private Label label_cep;
        private Button button_cadastrar;
        private Button button_limpar;
        private Label label_titulo;
        private Label label_erro;
        private DataGridView dataGridViewClientes;
    }
}
