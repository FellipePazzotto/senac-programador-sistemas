namespace login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string usuario = inputEmail.Text;
            string senha = inputSenha.Text;

            if (usuario == null || usuario == "")
            {
                labelResultado.Text = "O campo 'email' deve ser preenchido.";
                labelResultado.ForeColor = Color.Orange;
            }
            else if (senha == null || senha == "")
            {
                labelResultado.Text = "O campo 'senha' deve ser preenchido.";
                labelResultado.ForeColor = Color.Orange;
            }
            else
            {
                if (usuario == "fellipe@gmail.com" && senha == "12345")
                {
                    labelResultado.Text = "Usuário logado.";
                    labelResultado.ForeColor = Color.Orange;
                }
                else
                {
                    labelResultado.Text = "Usuário e/ou senha incorretos.";
                    labelResultado.ForeColor = Color.Orange;
                }
            }
        }
    }
}
