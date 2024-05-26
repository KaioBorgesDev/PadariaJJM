using MySql.Data.MySqlClient;

namespace PadariaJJM.conexao
{
    internal class FabricaConexao
    {
        MySqlConnection MySqlConnection;

        public MySqlConnection pegaConexao(string url)
        {

            return MySqlConnection = new MySqlConnection(url);
        }
    }

}
