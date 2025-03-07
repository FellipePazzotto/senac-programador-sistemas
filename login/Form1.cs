namespace login
{
    public partial class form_login : Form
    {
        List<string> lista_emails = new List<string>()
        {"neymar.junior", "lionel.messi", "cristiano.ronaldo"};

        List<string> lista_senhas = new List<string>()
        {"bruna", "fifa", "777"};

        public form_login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            int posicao_usuario_encontrado = -1;
            string usuario_buscado = input_email_log.Text;
            string senha = input_senha_log.Text;

            if (string.IsNullOrWhiteSpace(usuario_buscado))
            {
                label_resultado_log.Text = "O campo 'email' deve ser preenchido.";
                label_resultado_log.ForeColor = Color.Orange;
                return;
            }

            if (string.IsNullOrWhiteSpace(senha))
            {
                label_resultado_log.Text = "O campo 'senha' deve ser preenchido.";
                label_resultado_log.ForeColor = Color.Orange;
                return;
            }

            for (int i = 0; i < lista_emails.Count; i++)
            {
                if (usuario_buscado == lista_emails[i])
                {
                    posicao_usuario_encontrado = i;
                }
            }

            if (posicao_usuario_encontrado > -1 && senha == lista_senhas[posicao_usuario_encontrado])
            {
                label_resultado_log.Text = $"Usuário logado com sucesso. ({posicao_usuario_encontrado})";
                label_resultado_log.ForeColor = Color.Orange;
            }
            else
            {
                label_resultado_log.Text = $"Usuário e/ou senha incorretos.";
                label_resultado_log.ForeColor = Color.Orange;
            }
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            string novo_usuario = input_email_cad.Text;
            string nova_senha = input_senha_cad.Text;

            if (string.IsNullOrWhiteSpace(novo_usuario))
            {
                label_resultado_cad.Text = "O campo 'cadastrar email' está vazio.";
                label_resultado_cad.ForeColor = Color.Orange;
                return;
            }

            if (string.IsNullOrWhiteSpace(nova_senha))
            {
                label_resultado_cad.Text = "O campo 'cadastrar senha' está vazio.";
                label_resultado_cad.ForeColor = Color.Orange;
                return;
            }

            if (nova_senha.Length <= 9)
            {
                label_resultado_senha.Text = "A senha deve conter mais de 8 caracteres.";
                label_resultado_senha.ForeColor = Color.White;
                return;
            }

            if (!nova_senha.Any(char.IsPunctuation) && nova_senha.Any(char.IsSymbol) && !nova_senha.Contains("@"))
            {
                label_resultado_senha.Text = "A senha deve conter um caracter especial.";
                label_resultado_senha.ForeColor = Color.White;
                return;
            }

            if (!nova_senha.Any(char.IsUpper))
            {
                label_resultado_senha.Text = "A senha deve conter uma letra maiúscula.";
                label_resultado_senha.ForeColor = Color.White;
                return;
            }

            if (!nova_senha.Any(char.IsLower))
            {
                label_resultado_senha.Text = "A senha deve conter uma letra minúscula.";
                label_resultado_senha.ForeColor = Color.White;
                return;
            }

            if (nova_senha.Any(char.IsWhiteSpace))
            {
                label_resultado_senha.Text = "A senha não pode conter espaço.";
                label_resultado_senha.ForeColor = Color.White;
                return;
            }

            if (!nova_senha.Any(char.IsNumber))
            {
                label_resultado_senha.Text = "A senha deve conter um número.";
                label_resultado_senha.ForeColor = Color.White;
                return;
            }

            if (!lista_emails.Contains(novo_usuario))
            {
                lista_emails.Add(novo_usuario);
                lista_senhas.Add(nova_senha);
                label_resultado_senha.Text = "";
                label_resultado_cad.Text = "Usuário cadastrado com sucesso.";
                label_resultado_cad.ForeColor = Color.Orange;
                return;
            }

            label_resultado_senha.Text = "";
            label_resultado_cad.Text = "Usuário já cadastrado.";
            label_resultado_cad.ForeColor = Color.Orange;
            input_email_cad.Clear();
            input_senha_cad.Clear();
        }
    }
}
