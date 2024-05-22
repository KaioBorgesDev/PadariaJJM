using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;
using PadariaJJM.log;
using System;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PadariaJJM
{
    public class Produto
    {
        // Propriedades obrigatórias
        public int? idProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public bool IsPeso { get; set; }
        public string Categoria { get; set; }
        
        SalvarLog salvar = new SalvarLog(); 


        // Construtor para as propriedades obrigatórias

        //url casa da julia
        //private string Url = "Server=127.0.0.1;Database=PadariaJJM;Uid=root;Pwd=Senai1234";
        //url minha casa 
        private string Url = "Server=127.0.0.1;Database=PadariaJJM;Uid=root;Pwd=270275";

        public Produto(int? idProduto, string nome, decimal preco, int quantidade, bool isPeso, string categoria)
        {
            this.idProduto = idProduto;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            IsPeso = isPeso;
            Categoria = categoria;
            
        }



        // Propriedades opcionais

        public DateTime? DataValidade { get; set; } // Data de Validade é opcional
        public string CodigoBarras { get; set; } // Código de Barras é opcional
        public string Fornecedor { get; set; } // Fornecedor é opcional
        public string Tributo { get; set; } // Fornecedor é opcional




        // Método para validar se o produto está pronto para ser salvo
        public bool IsValid()
        {
            // Verifica se o nome, preço e quantidade são obrigatórios e têm valores válidos
            if (string.IsNullOrWhiteSpace(Nome) || Preco <= 0 || Quantidade <= -5 || string.IsNullOrWhiteSpace(Categoria))
                return false;

            // Se a data de validade for especificada, verifica se é válida
            if (DataValidade < DateTime.Now)
                return false;

            return true;
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

            MySqlCommand comando = new MySqlCommand("INSERT INTO produtos(nome, preco, quantidade, validade, barCode, fornecedor, is_peso, categoria_nome, tributos_nome) VALUES (@nome, @preco, @quantidade, @validade, @barCode, @fornecedor, @is_peso, @categoria_nome, @tributos_nome);", conn);
            comando.Parameters.AddWithValue("@nome", Nome);
            comando.Parameters.AddWithValue("@preco", Preco);
            comando.Parameters.AddWithValue("@quantidade", Quantidade);

            // Verifica se a Data de Validade é nula
            if (DataValidade != null && !(DataValidade < DateTime.MinValue))
            {
                comando.Parameters.AddWithValue("@validade", DataValidade.Value.ToString("yyyy-MM-dd")); // Formata a data para o formato YYYY-MM-DD
            }
            else
            {
                comando.Parameters.AddWithValue("@validade", DataValidade);
            }

            comando.Parameters.AddWithValue("@barCode", CodigoBarras);
            comando.Parameters.AddWithValue("@fornecedor", Fornecedor);

            // Pega o valor booleano como inteiro (0 ou 1)
            int valorInteiro = IsPeso ? 1 : 0;
            comando.Parameters.AddWithValue("@is_peso", valorInteiro);

            comando.Parameters.AddWithValue("@categoria_nome", Categoria);
            comando.Parameters.AddWithValue("@tributos_nome", Tributo);


            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar para o banco.");
                salvar.SalvarEmArquivoLog(ex.ToString(), "500");
                return mensagem;
            }
            return mensagem = "Salvo com sucesso";
        }



    }
}