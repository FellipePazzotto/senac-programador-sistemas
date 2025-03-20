using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace cadastroCliente
{
    public partial class Main : Form
    {
        private readonly List<Cliente> clientes = new List<Cliente>();
        TipoCliente tipo;
        bool estrangeiro = false;

        public Main()
        {
            EnderecoCliente enderecoPadrao = new EnderecoCliente();
            enderecoPadrao.logradouro = "Avenida Paulista";
            enderecoPadrao.numero = "1578";
            enderecoPadrao.complemento = "";
            enderecoPadrao.bairro = "Bela Vista";
            enderecoPadrao.estado = "S�o Paulo";
            enderecoPadrao.cep = "01310-200";

            Cliente cliente1 = new Cliente()
            {
                id = 01,
                nome = "Neymar J�nior",
                dataNascimento = "05/02/1992",
                telefone = "(11) 91122-3344",
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
                telefone = "(11) 95566-7788",
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
                telefone = "(11) 91133-5577",
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

        public int NovoId()
        {
            int id = clientes[clientes.Count - 1].id;
            int idNovo = id + 1;

            return idNovo;
        }

        public string ValidarTipoCliente()
        {
            if (radio_tipo_pf.Checked == false && radio_tipo_pj.Checked == false)
            {
                return label_erro.Text = "Selecione um tipo de cliente.";
            }

            if (radio_tipo_pf.Checked == true)
            {
                /*label_erro.Text =*/ tipo = TipoCliente.PF;
            }

            if (radio_tipo_pj.Checked == true)
            {
                /*label_erro.Text =*/ tipo = TipoCliente.PJ;
            }

            return label_erro.Text = "";
        }

        public string ValidarNome()
        {
            if (string.IsNullOrWhiteSpace(input_nome.Text) || string.IsNullOrEmpty(input_nome.Text))
            {
                return label_erro.Text = "O campo 'Nome completo' est� vazio.";
            }

            if (!(input_nome.Text.Any(char.IsLetter)))
            {
                return label_erro.Text = "O campo 'Nome completo' deve conter apenas letras.";
            }

            if (input_nome.Text.Length < 5)
            {
                return label_erro.Text = "O campo 'Nome completo' est� incompleto.";
            }

            if (!input_nome.Text.Any(char.IsWhiteSpace))
            {
                return label_erro.Text = "O campo 'Nome completo' possui apenas um nome.";
            }

            return label_erro.Text = "";
        }

        public string ValidarDataNascimento()
        {
            if (string.IsNullOrWhiteSpace(input_data_nasc.Text) || string.IsNullOrEmpty(input_data_nasc.Text))
            {
                return label_erro.Text = "O campo 'Data de nascimento' est� vazio.";
            }

            if (input_data_nasc.Text.Length <= 8)
            {
                return label_erro.Text = "O campo 'Data de nascimento' deve conter uma data v�lida.";
            }

            return label_erro.Text = "";
        }

        public string ValidarTelefone()
        {
            if (string.IsNullOrWhiteSpace(input_telefone.Text) || string.IsNullOrEmpty(input_telefone.Text))
            {
                return label_erro.Text = "O campo 'Telefone' est� vazio.";
            }

            if (!(input_telefone.Text[5] == '9') || !(input_telefone.Text.Length == 15))
            {
                return label_erro.Text = "O campo 'Telefone' deve conter um n�mero de celular.";
            }

            if (clientes.Any(cliente => cliente.telefone == input_telefone.Text))
            {
                return label_erro.Text = "O campo 'Telefone' cont�m um telefone j� cadastrado.";
            }

            return label_erro.Text = "";
        }

        public string ValidarEmail()
        {
            if (string.IsNullOrWhiteSpace(input_email.Text) || string.IsNullOrEmpty(input_email.Text))
            {
                return label_erro.Text = "O campo 'Email' est� vazio.";
            }

            if (!(input_email.Text.Contains('@')) || !(input_email.Text.Contains(".com")) || !(input_email.Text.Length > 8))
            {
                return label_erro.Text = "O campo 'Email' deve conter um email v�lido.";
            }

            if (clientes.Any(cliente => cliente.email == input_email.Text))
            {
                return label_erro.Text = "O campo 'Email' cont�m um email j� cadastrado.";
            }

            return label_erro.Text = "";
        }

        public string ValidarGenero()
        {
            var generos = Enum.GetNames(typeof(GeneroCliente)).ToList();

            if (string.IsNullOrEmpty(combo_genero.Text) || string.IsNullOrWhiteSpace(combo_genero.Text))
            {
                return label_erro.Text = "O campo 'G�nero' est� vazio.";
            }

            if (!generos.Contains(combo_genero.Text))
            {
                return label_erro.Text = "O campo 'G�nero' deve conter um g�nero v�lido.";
            }

            return label_erro.Text = "";
        }

        public string ValidarNomeSocial()
        {
            if (!string.IsNullOrWhiteSpace(input_nome_social.Text))
            {
                if (!input_nome_social.Text.Any(char.IsLetter))
                {
                    return label_erro.Text = "O campo 'Nome social' possui um n�mero.";
                }

                if (!input_nome_social.Text.Any(char.IsWhiteSpace))
                {
                    return label_erro.Text = "O campo 'Nome social' deve conter mais de um nome.";
                }
            }

            return label_erro.Text = "";
        }

        public string ValidarEtnia()
        {
            var etnias = new List<string> { "Branco", "Negro", "Pardo", "Amarelo", "Ind�gena" };

            if (string.IsNullOrEmpty(combo_etnia.Text) || string.IsNullOrWhiteSpace(combo_etnia.Text))
            {
                return label_erro.Text = "O campo 'Etnia' est� vazio.";
            }

            if (!(etnias.Any(etnia => combo_etnia.Text.Contains(etnia))))
            {
                return label_erro.Text = "O campo 'Etnia' deve conter um g�nero v�lido.";
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
            var tiposLogradouro = new List<string>{ "avenida", "rua", "travessa", "pra�a", "alameda",
                "rodovia", "beco", "estrada", "largo", "vila" };

            if (string.IsNullOrEmpty(input_logradouro.Text) || string.IsNullOrWhiteSpace(input_logradouro.Text))
            {
                return label_erro.Text = "O campo 'Logradouro' est� vazio.";
            }

            if (!(tiposLogradouro.Any(tipo => input_logradouro.Text.ToLower().Contains(tipo))) || !input_logradouro.Text.Any(char.IsWhiteSpace) ||
                !(input_logradouro.Text.Length > 5))
            {
                return label_erro.Text = "O campo 'Logradouro' deve conter um logradouro v�lido.";
            }

            return label_erro.Text = "";
        }

        public string ValidarNumero()
        {
            if (string.IsNullOrWhiteSpace(input_numero.Text) || string.IsNullOrEmpty(input_numero.Text))
            {
                return label_erro.Text = "O campo 'N�mero' est� vazio.";
            }

            if (!(input_numero.Text.Any(char.IsLetterOrDigit)))
            {
                return label_erro.Text = "O campo 'N�mero' deve conter letras e/ou n�meros.";
            }

            return label_erro.Text = "";
        }

        public string ValidarComplemento()
        {
            if (!(string.IsNullOrWhiteSpace(input_complemento.Text)) || !(string.IsNullOrEmpty(input_complemento.Text)))
            {
                if (!(input_complemento.Text.Any(char.IsLetterOrDigit)))
                {
                    return label_erro.Text = "O campo 'Complemento' deve conter letras e/ou n�mero.";
                }
            }

            return label_erro.Text = "";
        }

        public string ValidarBairro()
        {
            var tiposBairro = new List<string>{ "bairro", "vila", "condom�nio", "parque", 
                "loteamento", "centro", "sub�rbio" };

            if (string.IsNullOrEmpty(input_bairro.Text) || string.IsNullOrWhiteSpace(input_bairro.Text))
            {
                return label_erro.Text = "O campo 'Bairro' est� vazio.";
            }

            if (!(tiposBairro.Any(tipo => input_bairro.Text.ToLower().Contains(tipo))) || !input_bairro.Text.Any(char.IsWhiteSpace) ||
                !(input_bairro.Text.Length > 8))
            {
                return label_erro.Text = "O campo 'Bairro' deve conter um bairro v�lido.";
            }

            return label_erro.Text = "";
        }

        public string ValidarMunicipio()
        {
            if (string.IsNullOrEmpty(input_municipio.Text) || string.IsNullOrWhiteSpace(input_municipio.Text))
            {
                return label_erro.Text = "O campo 'Munic�pio' est� vazio.";
            }

            if (!input_municipio.Text.Any(char.IsLetter) || !(input_municipio.Text.Length > 5))
            {
                return label_erro.Text = "O campo 'Munic�pio' deve conter um munic�pio v�lido.";
            }

            return label_erro.Text = "";
        }

        public string ValidarEstado()
        {
            var estados = new List<string> { "AC - Acre", "AL - Alagoas", "AP - Amap�", "AM - Amazonas", "BA - Bahia", 
                "CE - Cear�", "DF - Distrito Federal", "ES - Esp�rito Santo", "GO - Goi�s", "MA - Maranh�o", "MT - Mato Grosso", 
                "MS - Mato Grosso do Sul", "MG - Minas Gerais", "PA - Par�", "PB - Para�ba", "PR - Paran�", "PE - Pernambuco", 
                "PI - Piau�", "RJ - Rio de Janeiro", "RN - Rio Grande do Norte", "RS - Rio Grande do Sul", "RO - Rond�nia", 
                "RR - Roraima", "SC - Santa Catarina", "SP - S�o Paulo", "SE - Sergipe", "TO - Tocantins"};

            if (string.IsNullOrEmpty(combo_estado.Text) || string.IsNullOrWhiteSpace(combo_estado.Text))
            {
                return label_erro.Text = "O campo 'Estado' est� vazio.";
            }

            if (!(estados.Any(estado => combo_estado.Text.Contains(estado))))
            {
                return label_erro.Text = "O campo 'Estado' deve conter um estado v�lido.";
            }

            return label_erro.Text = "";
        }

        public string ValidarCEP()
        {
            string cep = "00000-000";

            if (string.IsNullOrWhiteSpace(input_cep.Text) || string.IsNullOrEmpty(input_cep.Text))
            {
                return label_erro.Text = "O campo 'CEP' est� vazio.";
            }

            if (!(input_cep.Text.Length == 9) || input_cep.Text == cep)
            {
                return label_erro.Text = "O campo 'CEP' deve conter um CEP v�lido.";
            }

            return label_erro.Text = "";
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

            Cliente clienteNovo = new Cliente
            {
                id = NovoId(),
                nome = input_nome.Text,
                dataNascimento = input_data_nasc.Text,
                telefone = input_telefone.Text,
                email = input_email.Text,
                endereco = new EnderecoCliente
                {
                    logradouro = input_logradouro.Text,
                    numero = input_numero.Text,
                    complemento = input_complemento.Text,
                    bairro = input_bairro.Text,
                    municipio = input_municipio.Text,
                    estado = combo_estado.Text,
                    cep = input_cep.Text
                },
                genero = (GeneroCliente)Enum.Parse(typeof(GeneroCliente), combo_genero.Text),
                nomeSocial = input_nome_social.Text,
                etnia = (EtniaCliente)Enum.Parse(typeof(EtniaCliente), combo_etnia.Text),
                estrangeiro = check_estrangeiro.Checked,
                tipo = tipo
            };

            clientes.Add(clienteNovo);
            label_erro.Text = $"Cliente cadastrado com sucesso {clienteNovo.id}.";
        }
    }
}
