namespace login
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string usuario = input_email.Text;
            string senha = input_senha.Text;

            if (string.IsNullOrWhiteSpace(usuario))
            {
                label_resultado.Text = "O campo 'email' deve ser preenchido.";
                label_resultado.ForeColor = Color.Orange;
            }
            else if (string.IsNullOrWhiteSpace(senha))
            {
                label_resultado.Text = "O campo 'senha' deve ser preenchido.";
                label_resultado.ForeColor = Color.Orange;
            }
            else
            {
                if (usuario == "fellipe@gmail.com" && senha == "12345")
                {
                    label_resultado.Text = "Usuário logado.";
                    label_resultado.ForeColor = Color.Orange;
                }
                else
                {
                    label_resultado.Text = "Usuário e/ou senha incorretos.";
                    label_resultado.ForeColor = Color.Orange;
                }
            }
        }
    }
}
