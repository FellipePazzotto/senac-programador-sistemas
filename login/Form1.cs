using MySql.Data.MySqlClient;

namespace login
{
    public partial class form_login : Form
    {
        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=db_senac";
        private MySqlConnection Connection = new MySqlConnection(ConnectionString);

        public form_login()
        {
            InitializeComponent();
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

            try 
            {
                Connection.Open();

                string query = $"SELECT senha FROM usuario WHERE email = '{usuario_buscado}'";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                autenticado = reader.Read() && reader.GetString(0) == senha;
            }
            catch 
            {
                MessageBox.Show("Erro na conexão do banco de dados.");
            }
            finally 
            { 
                Connection.Close();
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
            try
            {
                Connection.Open();

                string query = $"SELECT email FROM usuario WHERE email = '{novo_usuario}'";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                encontrado = reader.Read();
            }
            catch
            {
                MessageBox.Show("Erro na conexão do banco de dados.");
            }
            finally
            {
                Connection.Close();
            }

            if (encontrado)
            {
                label_resultado_cad.Text = "Já existe um usuário cadastrado";
                return;
            }

            try
            {
                Connection.Open();

                string query = $"INSERT INTO usuario (email, senha) VALUES ('{novo_usuario}', '{nova_senha}')";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                mySqlCommand.ExecuteNonQuery();

                label_resultado_cad.Text = "Usuário cadastrado com sucesso.";
                label_resultado_cad.ForeColor = Color.Orange;
                input_email_cad.Clear();
                input_senha_cad.Clear();
            }
            catch
            {
                MessageBox.Show("Erro na conexão do banco de dados.");
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
