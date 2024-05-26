using MySql.Data.MySqlClient;
using PadariaJJM.log;

namespace PadariaJJM.entidade
{
    internal class Venda
    {
        private int? idVenda;
        private decimal preco_total;
        private string cpf;
        private decimal troco;
        private string metodo_pagamento;
        private DateTime data_venda;


        SalvarLog log = new SalvarLog();
        //url casa da Senai
        //private string Url = "Server=ESN509VMYSQL;Database=PadariaJJM_1;Uid=aluno;Pwd=Senai1234";
        //url casa da julia
        private string Url = "Server=127.0.0.1;Database=PadariaJJM;Uid=root;Pwd=Senai1234";
        //url minha casa 
        // private string Url = "Server=127.0.0.1;Database=PadariaJJM;Uid=root;Pwd=270275";
        private string caminho = @"arquivos\log.txt";

        public Venda(int? idVenda, decimal preco_total, string metodo_pagamento, DateTime data_venda)
        {
            this.idVenda = idVenda;
            this.preco_total = preco_total;
            this.metodo_pagamento = metodo_pagamento;
            this.data_venda = data_venda;
        }
        
        public Venda()
        {

        }

        public int? IdVenda { get => idVenda; set => idVenda = value; }
        public decimal Preco_total { get => preco_total; set => preco_total = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public decimal Troco { get => troco; set => troco = value; }
        public string Metodo_pagamento { get => metodo_pagamento; set => metodo_pagamento = value; }
        public DateTime Data_venda { get => data_venda; set => data_venda = value; }

        public string inserirVenda()
        {
            string mensagem = "Inserido com Sucesso!";
            MySqlConnection conn = new MySqlConnection(Url);

            try
            {
                conn.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(
                        "INSERT INTO vendas (idvenda, preco_total, cpf, troco, metodo_pagamento, data_venda) " +
                        "VALUES (@idvenda, @preco_total, @cpf, @troco, @metodo_pagamento, @data_venda)", conn);

                    comando.Parameters.AddWithValue("@idvenda", IdVenda);
                    comando.Parameters.AddWithValue("@preco_total", Preco_total);
                    comando.Parameters.AddWithValue("@cpf", Cpf);
                    comando.Parameters.AddWithValue("@troco", Troco);
                    comando.Parameters.AddWithValue("@metodo_pagamento", Metodo_pagamento);
                    comando.Parameters.AddWithValue("@data_venda", Data_venda.ToString("yyy-MM-dd HH-mm-ss"));

                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    mensagem = "Não foi possível salvar.";
                    log.SalvarEmArquivoLog(ex.ToString(), "500");
                }
            }
            catch (Exception ex)
            {
                mensagem = "Não foi possível abrir conexão.";
                log.SalvarEmArquivoLog(ex.ToString(), "500");
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return mensagem;
        }



    }
}
