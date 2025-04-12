using cadastroCliente.dominio;

namespace cadastroCliente
{
    public partial class Main : Form
    {
        private readonly Cliente Cliente = new();

        private readonly List<Cliente> Clientes = [];
        private readonly BindingSource BindingSource = [];

        TipoCliente tipo;
        bool estrangeiro = false;

        public Main()
        {
            InitializeComponent();
        }

        /*public int NovoId()
        {
            int id = clientes[clientes.Count - 1].Id;
            int idNovo = id + 1;

            return idNovo;
        }*/

        public string ValidarTipoCliente()
        {
            if (radio_tipo_pf.Checked == false && radio_tipo_pj.Checked == false)
            {
                return label_erro.Text = "Selecione um Tipo de cliente.";
            }

            if (radio_tipo_pf.Checked == true)
            {
                /*label_erro.Text =*/
                tipo = TipoCliente.PF;
            }

            if (radio_tipo_pj.Checked == true)
            {
                /*label_erro.Text =*/
                tipo = TipoCliente.PJ;
            }

            return label_erro.Text = "";
        }

        public string ValidarNome()
        {
            if (string.IsNullOrWhiteSpace(input_nome.Text) || string.IsNullOrEmpty(input_nome.Text))
            {
                return label_erro.Text = "O campo 'Nome completo' está vazio.";
            }

            if (!(input_nome.Text.Any(char.IsLetter)))
            {
                return label_erro.Text = "O campo 'Nome completo' deve conter apenas letras.";
            }

            if (input_nome.Text.Length < 5)
            {
                return label_erro.Text = "O campo 'Nome completo' está incompleto.";
            }

            if (!input_nome.Text.Any(char.IsWhiteSpace))
            {
                return label_erro.Text = "O campo 'Nome completo' possui apenas um Nome.";
            }

            return label_erro.Text = "";
        }

        public string ValidarDataNascimento()
        {
            if (input_data_nasc.Text.Length <= 8)
            {
                return label_erro.Text = $"O campo 'Data de nascimento' deve conter uma data DD/MM/AAAA.";
            }
            else
            {
                string dataTexto = input_data_nasc.Text.Trim();
                DateTime dataHoje;

                if (!DateTime.TryParse(dataTexto, out dataHoje))
                {
                    return label_erro.Text = "O campo 'Data de nascimento' deve conter uma data válida.";
                }
            }

            return label_erro.Text = "";
        }

        public string ValidarTelefone()
        {
            if (string.IsNullOrWhiteSpace(input_telefone.Text) || string.IsNullOrEmpty(input_telefone.Text))
            {
                return label_erro.Text = "O campo 'Telefone' está vazio.";
            }

            if (!(input_telefone.Text[5] == '9') || !(input_telefone.Text.Length == 15))
            {
                return label_erro.Text = "O campo 'Telefone' deve conter um número de celular.";
            }

            if (Clientes.Any(cliente => cliente.Telefone == input_telefone.Text))
            {
                return label_erro.Text = "O campo 'Telefone' contém um Telefone já cadastrado.";
            }

            return label_erro.Text = "";
        }

        public string ValidarEmail()
        {
            if (string.IsNullOrWhiteSpace(input_email.Text) || string.IsNullOrEmpty(input_email.Text))
            {
                return label_erro.Text = "O campo 'Email' está vazio.";
            }

            if (!(input_email.Text.Contains('@')) || !(input_email.Text.Contains(".com")) || !(input_email.Text.Length > 8))
            {
                return label_erro.Text = "O campo 'Email' deve conter um Email válido.";
            }

            if (Clientes.Any(cliente => cliente.Email == input_email.Text))
            {
                return label_erro.Text = "O campo 'Email' contém um Email já cadastrado.";
            }

            return label_erro.Text = "";
        }

        public string ValidarGenero()
        {
            var generos = Enum.GetNames(typeof(GeneroCliente)).ToList();

            if (string.IsNullOrEmpty(combo_genero.Text) || string.IsNullOrWhiteSpace(combo_genero.Text))
            {
                return label_erro.Text = "O campo 'Gênero' está vazio.";
            }

            if (!generos.Contains(combo_genero.Text))
            {
                return label_erro.Text = "O campo 'Gênero' deve conter um gênero válido.";
            }

            return label_erro.Text = "";
        }

        public string ValidarNomeSocial()
        {
            if (!string.IsNullOrWhiteSpace(input_nome_social.Text))
            {
                if (!input_nome_social.Text.Any(char.IsLetter))
                {
                    return label_erro.Text = "O campo 'Nome social' possui um número.";
                }

                if (!input_nome_social.Text.Any(char.IsWhiteSpace))
                {
                    return label_erro.Text = "O campo 'Nome social' deve conter mais de um Nome.";
                }
            }

            return label_erro.Text = "";
        }

        public string ValidarEtnia()
        {
            var etnias = new List<string> { "Branco", "Negro", "Pardo", "Amarelo", "Indígena" };

            if (string.IsNullOrEmpty(combo_etnia.Text) || string.IsNullOrWhiteSpace(combo_etnia.Text))
            {
                return label_erro.Text = "O campo 'Etnia' está vazio.";
            }

            if (!(etnias.Any(etnia => combo_etnia.Text.Contains(etnia))))
            {
                return label_erro.Text = "O campo 'Etnia' deve conter um gênero válido.";
            }

            return label_erro.Text = "";
        }

        public string ValidarEstrangeiro()
        {
            if (check_estrangeiro.Checked)
            {
                estrangeiro = true;
            }
            else
            {
                estrangeiro = false;
            }

            return label_erro.Text = "";
        }

        public string ValidarLogradouro()
        {
            var tiposLogradouro = new List<string>{ "avenida", "rua", "travessa", "praça", "alameda",
                "rodovia", "beco", "estrada", "largo", "vila" };

            if (string.IsNullOrEmpty(input_logradouro.Text) || string.IsNullOrWhiteSpace(input_logradouro.Text))
            {
                return label_erro.Text = "O campo 'Logradouro' está vazio.";
            }

            if (!(tiposLogradouro.Any(tipo => input_logradouro.Text.ToLower().Contains(tipo))) || !input_logradouro.Text.Any(char.IsWhiteSpace) ||
                !(input_logradouro.Text.Length > 5))
            {
                return label_erro.Text = "O campo 'Logradouro' deve conter um logradouro válido.";
            }

            return label_erro.Text = "";
        }

        public string ValidarNumero()
        {
            if (string.IsNullOrWhiteSpace(input_numero.Text) || string.IsNullOrEmpty(input_numero.Text))
            {
                return label_erro.Text = "O campo 'Número' está vazio.";
            }

            if (!(input_numero.Text.Any(char.IsLetterOrDigit)))
            {
                return label_erro.Text = "O campo 'Número' deve conter letras e/ou números.";
            }

            return label_erro.Text = "";
        }

        public string ValidarComplemento()
        {
            if (!(string.IsNullOrWhiteSpace(input_complemento.Text)) || !(string.IsNullOrEmpty(input_complemento.Text)))
            {
                if (!(input_complemento.Text.Any(char.IsLetterOrDigit)))
                {
                    return label_erro.Text = "O campo 'Complemento' deve conter letras e/ou número.";
                }
            }

            return label_erro.Text = "";
        }

        public string ValidarBairro()
        {
            var tiposBairro = new List<string>{ "Bairro", "vila", "condomínio", "parque",
                "loteamento", "centro", "subúrbio" };

            if (string.IsNullOrEmpty(input_bairro.Text) || string.IsNullOrWhiteSpace(input_bairro.Text))
            {
                return label_erro.Text = "O campo 'Bairro' está vazio.";
            }

            if (!(tiposBairro.Any(tipo => input_bairro.Text.ToLower().Contains(tipo))) || !input_bairro.Text.Any(char.IsWhiteSpace) ||
                !(input_bairro.Text.Length > 8))
            {
                return label_erro.Text = "O campo 'Bairro' deve conter um Bairro válido.";
            }

            return label_erro.Text = "";
        }

        public string ValidarMunicipio()
        {
            if (string.IsNullOrEmpty(input_municipio.Text) || string.IsNullOrWhiteSpace(input_municipio.Text))
            {
                return label_erro.Text = "O campo 'Município' está vazio.";
            }

            if (!input_municipio.Text.Any(char.IsLetter) || !(input_municipio.Text.Length > 5))
            {
                return label_erro.Text = "O campo 'Município' deve conter um município válido.";
            }

            return label_erro.Text = "";
        }

        public string ValidarEstado()
        {
            var estados = new List<string> { "AC - Acre", "AL - Alagoas", "AP - Amapá", "AM - Amazonas", "BA - Bahia",
                "CE - Ceará", "DF - Distrito Federal", "ES - Espírito Santo", "GO - Goiás", "MA - Maranhão", "MT - Mato Grosso",
                "MS - Mato Grosso do Sul", "MG - Minas Gerais", "PA - Pará", "PB - Paraíba", "PR - Paraná", "PE - Pernambuco",
                "PI - Piauí", "RJ - Rio de Janeiro", "RN - Rio Grande do Norte", "RS - Rio Grande do Sul", "RO - Rondônia",
                "RR - Roraima", "SC - Santa Catarina", "SP - São Paulo", "SE - Sergipe", "TO - Tocantins"};

            if (string.IsNullOrEmpty(combo_estado.Text) || string.IsNullOrWhiteSpace(combo_estado.Text))
            {
                return label_erro.Text = "O campo 'Estado' está vazio.";
            }

            if (!(estados.Any(estado => combo_estado.Text.Contains(estado))))
            {
                return label_erro.Text = "O campo 'Estado' deve conter um Estado válido.";
            }

            return label_erro.Text = "";
        }

        public string ValidarCEP()
        {
            string cep = "00000-000";

            if (string.IsNullOrWhiteSpace(input_cep.Text) || string.IsNullOrEmpty(input_cep.Text))
            {
                return label_erro.Text = "O campo 'CEP' está vazio.";
            }

            if (!(input_cep.Text.Length == 9) || input_cep.Text == cep)
            {
                return label_erro.Text = "O campo 'CEP' deve conter um CEP válido.";
            }

            return label_erro.Text = "";
        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            label_erro.Text = "";

            Enum.GetNames(typeof(EtniaCliente)).ToList().ForEach(etnia => combo_etnia.Items.Add(etnia));

            BindingSource.DataSource = Cliente.ListarClientes();
            dataGridViewClientes.DataSource = BindingSource;
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            string erro = ValidarTipoCliente();
            if (!string.IsNullOrEmpty(erro))
            {
                label_erro.Text = erro;
                return;
            }

            erro = ValidarNome();
            if (!string.IsNullOrEmpty(erro))
            {
                label_erro.Text = erro;
                return;
            }

            erro = ValidarDataNascimento();
            if (!string.IsNullOrEmpty(erro))
            {
                label_erro.Text = erro;
                return;
            }

            erro = ValidarTelefone();
            if (!string.IsNullOrEmpty(erro))
            {
                label_erro.Text = erro;
                return;
            }

            erro = ValidarEmail();
            if (!string.IsNullOrEmpty(erro))
            {
                label_erro.Text = erro;
                return;
            }

            erro = ValidarGenero();
            if (!string.IsNullOrEmpty(erro))
            {
                label_erro.Text = erro;
                return;
            }

            erro = ValidarNomeSocial();
            if (!string.IsNullOrEmpty(erro))
            {
                label_erro.Text = erro;
                return;
            }

            erro = ValidarEtnia();
            if (!string.IsNullOrEmpty(erro))
            {
                label_erro.Text = erro;
                return;
            }

            erro = ValidarEstrangeiro();
            if (!string.IsNullOrEmpty(erro))
            {
                label_erro.Text = erro;
                return;
            }

            erro = ValidarLogradouro();
            if (!string.IsNullOrEmpty(erro))
            {
                label_erro.Text = erro;
                return;
            }

            erro = ValidarNumero();
            if (!string.IsNullOrEmpty(erro))
            {
                label_erro.Text = erro;
                return;
            }

            erro = ValidarComplemento();
            if (!string.IsNullOrEmpty(erro))
            {
                label_erro.Text = erro;
                return;
            }

            erro = ValidarBairro();
            if (!string.IsNullOrEmpty(erro))
            {
                label_erro.Text = erro;
                return;
            }

            erro = ValidarMunicipio();
            if (!string.IsNullOrEmpty(erro))
            {
                label_erro.Text = erro;
                return;
            }

            erro = ValidarEstado();
            if (!string.IsNullOrEmpty(erro))
            {
                label_erro.Text = erro;
                return;
            }

            erro = ValidarCEP();
            if (!string.IsNullOrEmpty(erro))
            {
                label_erro.Text = erro;
                return;
            }

            DateTime.TryParse(input_telefone.Text, out DateTime dataNascimento);

            EnderecoCliente novoEndereco = new()
            {
                Logradouro = input_logradouro.Text,
                Numero = input_numero.Text,
                Bairro = input_bairro.Text,
                CEP = input_cep.Text.Replace("-", ""),
                Municipio = input_municipio.Text,
                Estado = combo_estado.Text,
                Complemento = input_complemento.Text,
            };

            Cliente novoCliente = new()
            {
                Nome = input_nome.Text,
                NomeSocial = input_nome_social.Text,
                DataNascimento = dataNascimento,
                Email = input_email.Text,
                Telefone = input_telefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""),
                Etnia = (EtniaCliente)combo_etnia.SelectedIndex,
                Genero = (GeneroCliente)combo_genero.SelectedIndex,
                Tipo = radio_tipo_pf.Checked ? TipoCliente.PF : TipoCliente.PJ,
                Estrangeiro = check_estrangeiro.Checked,
                Endereco = novoEndereco
            };

            Clientes.Add(clienteNovo);
            BindingSource.ResetBindings(false);
            label_erro.Text = $"{clienteNovo.Id}° cliente cadastrado com sucesso.";
        }
    }
}
