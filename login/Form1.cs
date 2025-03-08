namespace login
{
    public partial class form_login : Form
    {
        List<Usuario> usuarios = new List<Usuario>();

        public form_login()
        {
            InitializeComponent();

            usuarios.Add(new Usuario() { Email = "junior@email.com", Senha = "Abruna@123A" });
            usuarios.Add(new Usuario() { Email = "messi@email.com", Senha = "Afifa@123A" });
            usuarios.Add(new Usuario() { Email = "ronaldo@email.com", Senha = "A777@Abcd" });
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
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

            bool autenticado = false;
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].Email == usuario_buscado && usuarios[i].Senha == senha)
                {
                    autenticado = true;
                }
            }

            if (!autenticado)
            {
                label_resultado_log.Text = "Usuário e/ou senha incorretos.";
                label_resultado_log.ForeColor = Color.Orange;
                return;
            }

            label_resultado_log.Text = "Usuário logado com sucesso.";
            label_resultado_log.ForeColor = Color.Orange;
            input_email_log.Clear();
            input_senha_log.Clear();
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

            label_resultado_cad.Text = "";

            if (nova_senha.Length < 8)
            {
                label_resultado_senha.Text = "A senha deve conter mais de 8 caracteres.";
                label_resultado_senha.ForeColor = Color.White;
                return;
            }

            if (!nova_senha.Any(char.IsPunctuation) || nova_senha.Any(char.IsSymbol) || !nova_senha.Contains("@"))
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

            bool encontrado = false;
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].Email == novo_usuario && usuarios[i].Senha == nova_senha)
                {
                    encontrado = true;
                }
            }

            if (encontrado)
            {
                label_resultado_cad.Text = "Já existe um usuário cadastrado";
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
