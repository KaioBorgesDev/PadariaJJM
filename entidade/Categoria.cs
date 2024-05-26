using MySql.Data.MySqlClient;
using PadariaJJM.log;

namespace PadariaJJM.entidade
{
    internal class Categoria
    {

        public string Name { get; set; }

        private SalvarLog salvar = new SalvarLog();
        //url casa da Senai
        //private string Url = "Server=ESN509VMYSQL;Database=PadariaJJM_1;Uid=aluno;Pwd=Senai1234";
        //url minha casa 
        //private string Url = "Server=127.0.0.1;Database=PadariaJJM;Uid=root;Pwd=270275";
        //url casa da julia
        private string Url = "Server=127.0.0.1;Database=PadariaJJM;Uid=root;Pwd=Senai1234";

        public Categoria(string name)
        {

            this.Name = name;
        }
        public Categoria()
        {
            Name = "";
        }

        public string inserir()
        {
            var mensagem = "Não foi salvo!";
            MySqlConnection conn = new MySqlConnection(Url);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir banco");
                salvar.SalvarEmArquivoLog(ex.ToString(), "500");
                return mensagem;
            }

            MySqlCommand comando = new MySqlCommand("Insert into categoria(nome) values(@nome)", conn);
            comando.Parameters.AddWithValue("@nome", Name);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar no banco");
                salvar.SalvarEmArquivoLog(ex.ToString(), "500");
            }
            return mensagem = "Salvo com sucesso";
        }

        public List<Categoria> PegarCategorias()
        {
            var mensagem = "não foi possivel pegar as categorias";

            List<Categoria> categorias = new List<Categoria>();

            MySqlConnection conn = new MySqlConnection(Url);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir banco");
                salvar.SalvarEmArquivoLog(ex.ToString(), "500");
                return null;
            }

            MySqlCommand comando = new MySqlCommand("Select * from categoria", conn);


            try
            {
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Categoria categoria = new Categoria(reader["nome"].ToString());
                    categorias.Add(categoria);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao procurar categoria no banco");
                salvar.SalvarEmArquivoLog(ex.ToString(), "500");
            }
            return categorias;
        }

        public Categoria BuscaCategoria()
        {

            var mensagem = "não foi possivel pegar a categoria";
            MySqlConnection conn = new MySqlConnection(Url);
            Categoria categoria = null;


            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir banco");
                salvar.SalvarEmArquivoLog(ex.ToString(), "500");
            }
            MySqlCommand comando = new MySqlCommand("Select * from categoria(nome) where idcategoria = @nome", conn);
            comando.Parameters.AddWithValue("@nome", Name);
            try
            {
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Categoria cat = new Categoria(reader["nome"].ToString());
                    return cat;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao procurar categoria no banco");
                salvar.SalvarEmArquivoLog(ex.ToString(), "500");
            }
            return categoria;
        }


    }
}
