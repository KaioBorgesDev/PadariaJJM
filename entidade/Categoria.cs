using MySql.Data.MySqlClient;
using PadariaJJM.conexao;
using PadariaJJM.log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadariaJJM.entidade
{
    internal class Categoria
    {
        private int? Id { get; set; }
        private string Name { get; set; }
        private SalvarLog salvar = new SalvarLog();
        private string Url = "Server=127.0.0.1;Database=PadariaJJM;Uid=root;Pwd=Senai1234";
        private string caminho = @"arquivos\log.txt";
        public Categoria(int? id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public string inserir()
        {
            var mensagem = "não foi possivel salvar";
            MySqlConnection conn = new MySqlConnection(Url);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir banco");
                salvar.SalvarEmArquivoLog(caminho, ex.ToString(), "500");
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
                salvar.SalvarEmArquivoLog(caminho, ex.ToString(), "500");
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
                salvar.SalvarEmArquivoLog(caminho, ex.ToString(), "500");
            }

            MySqlCommand comando = new MySqlCommand("Select * from categoria(nome)", conn);


            try
            {
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Categoria categoria = new Categoria(int.Parse(reader["id"].ToString()), reader["nome"].ToString());
                    categorias.Add(categoria);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao procurar categoria no banco");
                salvar.SalvarEmArquivoLog(caminho, ex.ToString(), "500");
            }
            return categorias;
        }

        public Categoria BuscaCategoria()
        {

            var mensagem = "não foi possivel pegar a categoria";
            MySqlConnection conn = new MySqlConnection(Url);
            Categoria categoria = null;

            if (Id == null)
            {
                salvar.SalvarEmArquivoLog(caminho, mensagem, "500");
                return null;
            }

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir banco");
                salvar.SalvarEmArquivoLog(caminho, ex.ToString(), "500");
            }
            MySqlCommand comando = new MySqlCommand("Select * from categoria(nome) where idcategoria = @id", conn);
            comando.Parameters.AddWithValue("@id", Id);
            try
            {
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Categoria cat = new Categoria(int.Parse(reader["id"].ToString()), reader["nome"].ToString());
                    return cat;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao procurar categoria no banco");
                salvar.SalvarEmArquivoLog(caminho, ex.ToString(), "500");
            }
            return categoria;
        }
    }
}
