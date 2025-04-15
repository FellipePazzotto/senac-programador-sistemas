using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades.banco_de_dados
{
    internal class Database
    {
        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=db_senac;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
