using ListaAtividades.banco_de_dados;
using ListaAtividades.dominio;
using MySql.Data.MySqlClient;

namespace ListaAtividades.repositorio
{
    internal class AtividadeRepositorio
    {
        public void Criar(string titulo)
        {
            using (var con = Database.GetConnection())
            {
                con.Open();
                string query = "INSERT INTO atividade (titulo) VALUES (@titulo);";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AtualizarSituacao(int id, int novaSituacao)
        {
            using (var con = Database.GetConnection())
            {
                con.Open();
                string query = "UPDATE atividade SET situacao = @situacao WHERE id = @id;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@situacao", novaSituacao);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Atividade BuscarAtividadeEmAndamento()
        {
            using (var con = Database.GetConnection())
            {
                con.Open();
                string query = $"SELECT * FROM atividade WHERE situacao = {(int) Situacao.Realizando};";

                using (var cmd = new MySqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Atividade()
                            {
                                Id = reader.GetInt32("id"),
                                Titulo = reader.GetString("titulo"),
                                Situacao = (Situacao)reader.GetInt32("situacao")
                            };
                        }
                    }
                }

                return new Atividade();
            }
        }

        public List<Atividade> ListarAtividadesPendentes()
        {
            List<Atividade> atividades = [];

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = $"SELECT * FROM atividade WHERE situacao = {(int) Situacao.Pendente};";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            atividades.Add(new Atividade()
                            {
                                Id = reader.GetInt32("id"),
                                Titulo = reader.GetString("titulo"),
                                Situacao = (Situacao)reader.GetInt32("situacao")
                            });
                        }
                    }
                }
            }

            return atividades;
        }
    }
}
