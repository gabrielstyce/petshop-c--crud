using System.Data;
using MySql.Data.MySqlClient;

namespace PetShop.DAO
{
    class ConexaoBanco
    {
        public static MySqlConnection Conectar()
        {
            string stringConexao = "SERVER=localhost;DATABASE=petshop;UID=root;PASSWORD=;";
            MySqlConnection conexao = new MySqlConnection(stringConexao);
            conexao.Open();
            return conexao;
        }

        public static void CRUD(MySqlCommand comando)
        {
            MySqlConnection con = Conectar();
            comando.Connection = con;
            comando.ExecuteNonQuery();
            con.Close();
        }

        public static MySqlDataReader Selecionar(MySqlCommand comando)
        {
            MySqlConnection con = Conectar();
            comando.Connection = con;
            MySqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
    }
}
