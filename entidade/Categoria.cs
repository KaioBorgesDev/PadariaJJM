using MySql.Data.MySqlClient;
using PadariaJJM.log;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PadariaJJM.entidade
{
    internal class Categoria
    {
        public string Name { get; set; }
        private SalvarLog salvar = new SalvarLog();
        private string Url = "Server=127.0.0.1;Database=PadariaJJM;Uid=root;Pwd=Juniormeira";

        public Categoria(string name)
        {
            this.Name = name;
        }

        public Categoria()
        {
            Name = "";
        }

        public string Inserir()
        {
            var mensagem = "Não foi salvo!";
            MySqlConnection conn = new MySqlConnection(Url);

            try
            {
                salvar.SalvarEmArquivoLog("Tentando abrir conexão com o banco de dados.", "200");
                conn.Open();
                salvar.SalvarEmArquivoLog("Conexão aberta com sucesso.", "200");

                MySqlCommand comando = new MySqlCommand("INSERT INTO categoria(nome) VALUES(@nome)", conn);
                comando.Parameters.AddWithValue("@nome", Name);

                try
                {
                    salvar.SalvarEmArquivoLog("Executando comando para inserir categoria.", "200");
                    comando.ExecuteNonQuery();
                    salvar.SalvarEmArquivoLog("Categoria inserida com sucesso.", "200");
                    mensagem = "Salvo com sucesso";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar no banco");
                    salvar.SalvarEmArquivoLog("Erro ao tentar inserir categoria: " + ex.ToString(), "500");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir banco");
                salvar.SalvarEmArquivoLog("Erro ao abrir conexão: " + ex.ToString(), "500");
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    salvar.SalvarEmArquivoLog("Conexão fechada.", "200");
                }
            }

            return mensagem;
        }

        public List<Categoria> PegarCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            MySqlConnection conn = new MySqlConnection(Url);

            try
            {
                salvar.SalvarEmArquivoLog("Tentando abrir conexão com o banco de dados para pegar todas as categorias.", "200");
                conn.Open();
                salvar.SalvarEmArquivoLog("Conexão aberta com sucesso.", "200");

                MySqlCommand comando = new MySqlCommand("SELECT * FROM categoria", conn);

                try
                {
                    var reader = comando.ExecuteReader();
                    salvar.SalvarEmArquivoLog("Lendo categorias do banco de dados.", "200");

                    while (reader.Read())
                    {
                        Categoria categoria = new Categoria(reader["nome"].ToString());
                        categorias.Add(categoria);
                    }

                    salvar.SalvarEmArquivoLog("Categorias lidas com sucesso.", "200");
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao procurar categoria no banco");
                    salvar.SalvarEmArquivoLog("Erro ao ler categorias: " + ex.ToString(), "500");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir banco");
                salvar.SalvarEmArquivoLog("Erro ao abrir conexão: " + ex.ToString(), "500");
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    salvar.SalvarEmArquivoLog("Conexão fechada.", "200");
                }
            }

            return categorias;
        }

        public Categoria BuscaCategoria()
        {
            MySqlConnection conn = new MySqlConnection(Url);
            Categoria categoria = null;

            try
            {
                salvar.SalvarEmArquivoLog("Tentando abrir conexão com o banco de dados para buscar categoria.", "200");
                conn.Open();
                salvar.SalvarEmArquivoLog("Conexão aberta com sucesso.", "200");

                MySqlCommand comando = new MySqlCommand("SELECT * FROM categoria WHERE nome = @nome", conn);
                comando.Parameters.AddWithValue("@nome", Name);

                try
                {
                    var reader = comando.ExecuteReader();
                    salvar.SalvarEmArquivoLog("Lendo categoria do banco de dados.", "200");

                    if (reader.Read())
                    {
                        categoria = new Categoria(reader["nome"].ToString());
                        salvar.SalvarEmArquivoLog("Categoria encontrada: " + categoria.Name, "200");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao procurar categoria no banco");
                    salvar.SalvarEmArquivoLog("Erro ao ler categoria: " + ex.ToString(), "500");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir banco");
                salvar.SalvarEmArquivoLog("Erro ao abrir conexão: " + ex.ToString(), "500");
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    salvar.SalvarEmArquivoLog("Conexão fechada.", "200");
                }
            }

            return categoria;
        }
    }
}
