using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
