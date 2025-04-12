using cadastroCliente.repositorio;

namespace cadastroCliente.dominio
{
    internal class Cliente
    {
        private readonly ClienteRepositorio clienteRepositorio = new();

        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeSocial { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public TipoCliente Tipo { get; set; }
        public EtniaCliente Etnia { get; set; }
        public GeneroCliente Genero { get; set; }
        public bool Estrangeiro { get; set; }
        public EnderecoCliente Endereco { get; set; }

        public List<Cliente> ListarClientes()
        {
            return clienteRepositorio.ListarClientes();
        }

        /*public void InserirCliente(Cliente novoCliente)
        {
            clienteRepositorio.InserirCliente(novoCliente);
        }*/
    }
}