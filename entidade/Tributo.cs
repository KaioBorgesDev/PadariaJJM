using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;
using PadariaJJM.log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PadariaJJM.entidade
{
    internal class Tributo
    {
        
        public string Nome { get; set;}
        public int Porcentagem { get; set;}
        SalvarLog salvar = new SalvarLog();
        //url casa da Senai
        private string Url = "Server=ESN509VMYSQL;Database=PadariaJJM_1;Uid=aluno;Pwd=Senai1234";
        //url casa da julia
        //private string Url = "Server=127.0.0.1;Database=PadariaJJM;Uid=root;Pwd=Senai1234";
        //url minha casa 
       // private string Url = "Server=127.0.0.1;Database=PadariaJJM;Uid=root;Pwd=270275";
        private string caminho = @"arquivos\log.txt";

        public Tributo()
        {
        }

        public Tributo(string nome, int porcentagem)
        {
            Nome = nome;
            Porcentagem = porcentagem;
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
                salvar.SalvarEmArquivoLog(ex.ToString(), "500");
                return mensagem;
            }

            MySqlCommand comando = new MySqlCommand("Insert into tributos(nome, valor_porcentagem) values(@nome, @porcentagem)", conn);
            comando.Parameters.AddWithValue("@nome", Nome);
            comando.Parameters.AddWithValue("@porcentagem", Porcentagem);

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

        public List<Tributo> SelecionarTodos()
        {
            List<Tributo> tributos = new List<Tributo>();

            MySqlConnection conn = new MySqlConnection(Url);

            try
            {
                conn.Open();

                MySqlCommand comando = new MySqlCommand("SELECT * FROM tributos", conn);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Tributo tributo = new Tributo(reader["nome"].ToString(), int.Parse(reader["valor_porcentagem"].ToString()));
                    tributos.Add(tributo);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar tributos do banco");
                salvar.SalvarEmArquivoLog(ex.ToString(), "500");
            }
            finally
            {
                conn.Close();
            }

            return tributos;
        }
    }
}
