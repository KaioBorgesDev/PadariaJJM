using MySql.Data.MySqlClient;
using PadariaJJM.log;
using System;
using System.Collections.Generic;

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

        private string Url = "Server=127.0.0.1;Database=PadariaJJM;Uid=root;Pwd=270275";
        // private string Url = "Server=127.0.0.1;Database=PadariaJJM;Uid=root;Pwd=Senai1234";

        public Venda(int? idVenda, decimal preco_total, string metodo_pagamento, DateTime data_venda, string cpf = null, decimal troco = 0)
        {
            this.idVenda = idVenda;
            this.preco_total = preco_total;
            this.metodo_pagamento = metodo_pagamento;
            this.data_venda = data_venda;
            this.cpf = cpf;
            this.troco = troco;
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

        public string InserirVenda()
        {
            string mensagem = "Inserido com Sucesso!";
            MySqlConnection conn = new MySqlConnection(Url);

            try
            {
                log.SalvarEmArquivoLog("Tentando abrir conexão com o banco de dados.", "200");
                conn.Open();
                log.SalvarEmArquivoLog("Conexão aberta com sucesso.", "200");

                try
                {
                    log.SalvarEmArquivoLog("Preparando comando para inserir venda.", "200");
                    MySqlCommand comando = new MySqlCommand(
                        "INSERT INTO vendas (idvenda, preco_total, cpf, troco, metodo_pagamento, data_venda) " +
                        "VALUES (@idvenda, @preco_total, @cpf, @troco, @metodo_pagamento, @data_venda)", conn);

                    comando.Parameters.AddWithValue("@idvenda", IdVenda);
                    comando.Parameters.AddWithValue("@preco_total", Preco_total);
                    comando.Parameters.AddWithValue("@cpf", Cpf);
                    comando.Parameters.AddWithValue("@troco", Troco);
                    comando.Parameters.AddWithValue("@metodo_pagamento", Metodo_pagamento);
                    comando.Parameters.AddWithValue("@data_venda", Data_venda.ToString("yyyy-MM-dd HH:mm:ss"));

                    comando.ExecuteNonQuery();
                    log.SalvarEmArquivoLog("Venda inserida com sucesso.", "200");
                }
                catch (Exception ex)
                {
                    mensagem = "Não foi possível salvar.";
                    log.SalvarEmArquivoLog("Erro ao tentar inserir venda: " + ex.ToString(), "500");
                }
            }
            catch (Exception ex)
            {
                mensagem = "Não foi possível abrir conexão.";
                log.SalvarEmArquivoLog("Erro ao abrir conexão: " + ex.ToString(), "500");
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    log.SalvarEmArquivoLog("Conexão fechada.", "200");
                }
            }

            return mensagem;
        }

        public List<Venda> ObterTodasAsVendas()
        {
            List<Venda> vendas = new List<Venda>();
            MySqlConnection conn = new MySqlConnection(Url);

            try
            {
                log.SalvarEmArquivoLog("Tentando abrir conexão com o banco de dados para obter todas as vendas.", "200");
                conn.Open();
                log.SalvarEmArquivoLog("Conexão aberta com sucesso.", "200");

                MySqlCommand comando = new MySqlCommand("SELECT * FROM vendas", conn);
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Venda venda = new Venda
                        (
                            IdVenda = reader.IsDBNull(reader.GetOrdinal("idvenda")) ? (int?)null : reader.GetInt32("idvenda"),
                            Preco_total = reader.GetDecimal("preco_total"),
                            Metodo_pagamento = reader.GetString("metodo_pagamento"),
                            Data_venda = reader.GetDateTime("data_venda"),
                            Cpf = reader.IsDBNull(reader.GetOrdinal("cpf")) ? null : reader.GetString("cpf"),
                            Troco = reader.IsDBNull(reader.GetOrdinal("troco")) ? 0 : reader.GetDecimal("troco")
                        );

                        vendas.Add(venda);
                    }
                }
                log.SalvarEmArquivoLog("Todas as vendas foram obtidas com sucesso.", "200");
            }
            catch (Exception ex)
            {
                log.SalvarEmArquivoLog("Erro ao obter todas as vendas: " + ex.ToString(), "500");
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    log.SalvarEmArquivoLog("Conexão fechada.", "200");
                }
            }

            return vendas;
        }

        public List<Venda> ObterVendasPorMesAno(int mes, int ano)
        {
            List<Venda> vendas = new List<Venda>();
            MySqlConnection conn = new MySqlConnection(Url);

            try
            {
                log.SalvarEmArquivoLog("Tentando abrir conexão com o banco de dados para obter vendas por mês e ano.", "200");
                conn.Open();
                log.SalvarEmArquivoLog("Conexão aberta com sucesso.", "200");

                DateTime primeiroDiaDoMes = new DateTime(ano, mes, 1);
                DateTime ultimoDiaDoMes = primeiroDiaDoMes.AddMonths(1).AddDays(-1);

                log.SalvarEmArquivoLog($"Obtendo vendas de {primeiroDiaDoMes} a {ultimoDiaDoMes}.", "200");
                string sql = "SELECT * FROM vendas WHERE data_venda >= @primeiroDiaDoMes AND data_venda <= @ultimoDiaDoMes";
                MySqlCommand comando = new MySqlCommand(sql, conn);
                comando.Parameters.AddWithValue("@primeiroDiaDoMes", primeiroDiaDoMes);
                comando.Parameters.AddWithValue("@ultimoDiaDoMes", ultimoDiaDoMes);

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Venda venda = new Venda
                        {
                            IdVenda = reader.IsDBNull(reader.GetOrdinal("idvenda")) ? (int?)null : reader.GetInt32("idvenda"),
                            Preco_total = reader.GetDecimal("preco_total"),
                            Metodo_pagamento = reader.GetString("metodo_pagamento"),
                            Data_venda = reader.GetDateTime("data_venda"),
                            Cpf = reader.IsDBNull(reader.GetOrdinal("cpf")) ? null : reader.GetString("cpf"),
                            Troco = reader.IsDBNull(reader.GetOrdinal("troco")) ? 0 : reader.GetDecimal("troco")
                        };

                        vendas.Add(venda);
                    }
                }
                log.SalvarEmArquivoLog("Vendas por mês e ano obtidas com sucesso.", "200");
            }
            catch (Exception ex)
            {
                log.SalvarEmArquivoLog("Erro ao obter vendas por mês e ano: " + ex.ToString(), "500");
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    log.SalvarEmArquivoLog("Conexão fechada.", "200");
                }
            }

            return vendas;
        }

        public decimal ObterTotalValorVendas()
        {
            decimal total = 0;
            MySqlConnection conn = new MySqlConnection(Url);

            try
            {
                log.SalvarEmArquivoLog("Tentando abrir conexão com o banco de dados para obter o total de vendas.", "200");
                conn.Open();
                log.SalvarEmArquivoLog("Conexão aberta com sucesso.", "200");

                MySqlCommand comando = new MySqlCommand("SELECT preco_total FROM vendas", conn);
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        total += reader.GetDecimal("preco_total");
                    }
                }
                log.SalvarEmArquivoLog("Total de vendas obtido com sucesso.", "200");
            }
            catch (Exception ex)
            {
                log.SalvarEmArquivoLog("Erro ao obter total de vendas: " + ex.ToString(), "500");
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    log.SalvarEmArquivoLog("Conexão fechada.", "200");
                }
            }

            return total;
        }
    }
}
