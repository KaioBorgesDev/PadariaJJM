using MySql.Data.MySqlClient;
using PadariaJJM.log;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PadariaJJM.entidade
{
    internal class Tributo
    {
        public string Nome { get; set; }
        public int Porcentagem { get; set; }
        SalvarLog salvar = new SalvarLog();

        //url casa da Senai
        //private string Url = "Server=ESN509VMYSQL;Database=PadariaJJM_1;Uid=aluno;Pwd=Senai1234";
        //url casa da julia
        // private string Url = "Server=127.0.0.1;Database=PadariaJJM;Uid=root;Pwd=Senai1234";
        //url minha casa 
        private string Url = "Server=127.0.0.1;Database=PadariaJJM;Uid=root;Pwd=270275";
        private string caminho = @"arquivos\log.txt";

        public Tributo()
        {
        }

        public Tributo(string nome, int porcentagem)
        {
            Nome = nome;
            Porcentagem = porcentagem;
        }

        public string Inserir()
        {
            var mensagem = "Não foi possível salvar";
            MySqlConnection conn = new MySqlConnection(Url);

            try
            {
                salvar.SalvarEmArquivoLog("Tentando abrir conexão com o banco de dados.", "200");
                conn.Open();
                salvar.SalvarEmArquivoLog("Conexão aberta com sucesso.", "200");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir banco");
                salvar.SalvarEmArquivoLog("Erro ao abrir conexão: " + ex.ToString(), "500");
                return mensagem;
            }

            MySqlCommand comando = new MySqlCommand("INSERT INTO tributos(nome, valor_porcentagem) VALUES(@nome, @porcentagem)", conn);
            comando.Parameters.AddWithValue("@nome", Nome);
            comando.Parameters.AddWithValue("@porcentagem", Porcentagem);

            try
            {
                salvar.SalvarEmArquivoLog("Executando comando para inserir tributo.", "200");
                comando.ExecuteNonQuery();
                salvar.SalvarEmArquivoLog("Tributo inserido com sucesso.", "200");
                mensagem = "Salvo com sucesso";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar no banco");
                salvar.SalvarEmArquivoLog("Erro ao tentar inserir tributo: " + ex.ToString(), "500");
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

        public List<Tributo> SelecionarTodos()
        {
            List<Tributo> tributos = new List<Tributo>();
            MySqlConnection conn = new MySqlConnection(Url);

            try
            {
                salvar.SalvarEmArquivoLog("Tentando abrir conexão com o banco de dados para selecionar todos os tributos.", "200");
                conn.Open();
                salvar.SalvarEmArquivoLog("Conexão aberta com sucesso.", "200");

                MySqlCommand comando = new MySqlCommand("SELECT * FROM tributos", conn);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Tributo tributo = new Tributo(reader["nome"].ToString(), int.Parse(reader["valor_porcentagem"].ToString()));
                    tributos.Add(tributo);
                }

                reader.Close();
                salvar.SalvarEmArquivoLog("Tributos selecionados com sucesso.", "200");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar tributos do banco");
                salvar.SalvarEmArquivoLog("Erro ao selecionar tributos: " + ex.ToString(), "500");
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    salvar.SalvarEmArquivoLog("Conexão fechada.", "200");
                }
            }

            return tributos;
        }
    }
}
