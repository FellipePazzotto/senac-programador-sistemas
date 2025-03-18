namespace cadastroCliente
{
    public partial class Main : Form
    {
        List<Cliente> clientes = new List<Cliente>();

        public Main()
        {
            EnderecoCliente enderecoPadrao = new EnderecoCliente();
            enderecoPadrao.logradouro = "Avenida Paulista";
            enderecoPadrao.numero = "1578";
            enderecoPadrao.complemento = "";
            enderecoPadrao.bairro = "Bela Vista";
            enderecoPadrao.estado = "São Paulo";
            enderecoPadrao.cep = "01310-200";

            GeneroCliente generoPadrao = new GeneroCliente();
            generoPadrao.genero = "Masculino";

            EtniaCliente etniaPadrao = new EtniaCliente();
            etniaPadrao.etnia = "Pardo";

            clientes.Add(new Cliente()
            {
                id = 01, nome = "Neymar Júnior", dataNascimento = "05/02/1992", telefone = "1191122-3344",
                email = "neymar.junior@gmail.com", endereco = enderecoPadrao, genero = generoPadrao,
                nomeSocial = "", etnia = etniaPadrao, estrangeiro = false, tipo = TipoCliente.PJ
            });

            clientes.Add(new Cliente()
            {
                id = 02, nome = "Marcos Leonardo", dataNascimento = "02/05/2003", telefone = "1195566-7788",
                email = "marcos.leonardo@gmail.com", endereco = enderecoPadrao, genero = generoPadrao,
                nomeSocial = "", etnia = etniaPadrao, estrangeiro = false, tipo = TipoCliente.PJ
            });

            clientes.Add(new Cliente()
            {
                id = 03, nome = "Tiquinho Soares", dataNascimento = "17/01/1991", telefone = "1191133-5577",
                email = "tiquinho.soares@gmail.com", endereco = enderecoPadrao, genero = generoPadrao,
                nomeSocial = "", etnia = etniaPadrao, estrangeiro = false, tipo = TipoCliente.PJ
            });

            InitializeComponent();
        }
    }
}
