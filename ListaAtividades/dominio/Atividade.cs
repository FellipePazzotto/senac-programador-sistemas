using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades.dominio
{
    internal class Atividade
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Situacao Situacao { get; set; }

        public void Criar()
        {

        }

        public void AtualizarSituacao()
        {

        }

        public Atividade BuscarAtividadeEmAndamento()
        {
            return new Atividade();
        }

        public List<Atividade> ListarAtividadesPendentes()
        {
            return [];
        }

        private bool ValidarTitulo()
        {
            return string.IsNullOrEmpty(Titulo);
        }

        private Situacao BuscarProximaSituacao()
        {
            return Situacao.Concluido;
        }
    }
}
