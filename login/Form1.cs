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

        }
    }
}
