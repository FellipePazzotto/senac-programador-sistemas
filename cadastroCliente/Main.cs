namespace cadastroCliente
{
    public partial class Main : Form
    {
        private readonly List<Cliente> clientes = [];

        public Main()
        {
            EnderecoCliente enderecoPadrao = new EnderecoCliente();
            enderecoPadrao.logradouro = "Avenida Paulista";
            enderecoPadrao.numero = "1578";
            enderecoPadrao.complemento = "";
            enderecoPadrao.bairro = "Bela Vista";
            enderecoPadrao.estado = "São Paulo";
            enderecoPadrao.cep = "01310-200";

            Cliente cliente1 = new Cliente()
            {
                id = 01,
                nome = "Neymar Júnior",
                dataNascimento = "05/02/1992",
                telefone = "1191122-3344",
                email = "neymar.junior@gmail.com",
                endereco = enderecoPadrao,
                genero = GeneroCliente.Masculino,
                nomeSocial = "",
                etnia = EtniaCliente.Pardo,
                estrangeiro = false,
                tipo = TipoCliente.PJ
            };
            clientes.Add(cliente1);

            Cliente cliente2 = new Cliente()
            {
                id = 02,
                nome = "Marcos Leonardo",
                dataNascimento = "02/05/2003",
                telefone = "1195566-7788",
                email = "marcos.leonardo@gmail.com",
                endereco = enderecoPadrao,
                genero = GeneroCliente.Masculino,
                nomeSocial = "",
                etnia = EtniaCliente.Pardo,
                estrangeiro = false,
                tipo = TipoCliente.PJ
            };
            clientes.Add(cliente2);

            Cliente cliente3 = new Cliente()
            {
                id = 03,
                nome = "Tiquinho Soares",
                dataNascimento = "17/01/1991",
                telefone = "1191133-5577",
                email = "tiquinho.soares@gmail.com",
                endereco = enderecoPadrao,
                genero = GeneroCliente.Masculino,
                nomeSocial = "",
                etnia = EtniaCliente.Pardo,
                estrangeiro = false,
                tipo = TipoCliente.PJ
            };
            clientes.Add(cliente3);

            InitializeComponent();
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            string nome = input_nome.Text;
            string data = input_data_nasc.Text;
            string telefone = input_telefone.Text;
            string email = input_email.Text;
            string genero = combo_genero.Text;
            string nome_social = input_nome_social.Text;
            string etnia = combo_etnia.Text;
            bool estrangeiro = check_estrangeiro.Checked;
            string logradouro = input_logradouro.Text;
            string numero = input_numero.Text;
            string complemento = input_complemento.Text;
            string bairro = input_bairro.Text;
            string municipio = input_municipio.Text;
            string estado = combo_estado.Text;
            string cep = input_cep.Text;

            if (string.IsNullOrEmpty(nome))
            {
                label_erro.Text = "O campo 'Nome completo' está vazio.";
                return;
            }

            if (!nome.Any(char.IsWhiteSpace))
            {
                label_erro.Text = "O campo 'Nome completo' possui apenas um nome.";
                return;
            }




        }
    }
}
