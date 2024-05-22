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
        public int? ID { get; set; }
        public string Nome { get; set;}
        public int Porcentagem { get; set;}
        SalvarLog salvar = new SalvarLog();
        private string Url = "Server=127.0.0.1;Database=PadariaJJM;Uid=root;Pwd=Senai1234";
        private string caminho = @"arquivos\log.txt";


        public Tributo(int? iD, string nome, int porcentagem)
        {
            ID = iD;
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
                salvar.SalvarEmArquivoLog(caminho, ex.ToString(), "500");
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
                salvar.SalvarEmArquivoLog(caminho, ex.ToString(), "500");
            }
            return mensagem = "Salvo com sucesso";
        }
    }
}
