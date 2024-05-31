using MySql.Data.MySqlClient;
using PadariaJJM.log;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PadariaJJM
{
    public class Produto
    {
        // Propriedades obrigatórias
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public decimal Quantidade { get; set; }
        public bool IsPeso { get; set; }
        public string Categoria { get; set; }
        public string CodigoBarras { get; set; } // Código de Barras é opcional

    

        SalvarLog salvar = new();

        public decimal ValorTotal { get; set; } // Fornecedor é opcional

        // URL da conexão com o banco de dados
        private string Url = "Server=127.0.0.1;Database=PadariaJJM;Uid=root;Pwd=Juniormeira";

        // Construtor para as propriedades obrigatórias
        public Produto(string nome, decimal preco, decimal quantidade, bool isPeso, string categoria, string codigodebarras)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            IsPeso = isPeso;
            Categoria = categoria;
            CodigoBarras = codigodebarras;
        }

        public Produto()
        {
        }

        // Propriedades opcionais
        public DateTime? DataValidade { get; set; } // Data de Validade é opcional
        public string Fornecedor { get; set; } // Fornecedor é opcional
        public string Tributo { get; set; } // Fornecedor é opcional

        // Método para validar se o produto está pronto para ser salvo
        public bool IsValid()
        {
            // Verifica se o nome, preço e quantidade são obrigatórios e têm valores válidos
            if (string.IsNullOrWhiteSpace(Nome) || Preco <= 0 || Quantidade <= -20 || string.IsNullOrWhiteSpace(Categoria))
                return false;

            // Se a data de validade for especificada, verifica se é válida
            if (DataValidade < DateTime.Now)
                return false;

            return true;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir banco");
                salvar.SalvarEmArquivoLog("Erro ao abrir conexão: " + ex.ToString(), "500");
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
                comando.Parameters.AddWithValue("@validade", DBNull.Value);
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
                salvar.SalvarEmArquivoLog("Executando comando para inserir produto.", "200");
                comando.ExecuteNonQuery();
                salvar.SalvarEmArquivoLog("Produto inserido com sucesso.", "200");
                mensagem = "Salvo com sucesso";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar para o banco.");
                salvar.SalvarEmArquivoLog("Erro ao tentar inserir produto: " + ex.ToString(), "500");
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

        public List<Produto> PegarTodos()
        {
            List<Produto> produtos = new List<Produto>();

            MySqlConnection conn = new MySqlConnection(Url);

            try
            {
                salvar.SalvarEmArquivoLog("Tentando abrir conexão com o banco de dados para pegar todos os produtos.", "200");
                conn.Open();
                salvar.SalvarEmArquivoLog("Conexão aberta com sucesso.", "200");

                MySqlCommand comando = new MySqlCommand("SELECT * FROM produtos", conn);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Produto produto = new Produto(
                        reader["nome"].ToString(),
                        decimal.Parse(reader["preco"].ToString()),
                        decimal.Parse(reader["quantidade"].ToString()),
                        bool.Parse(reader["is_peso"].ToString()),
                        reader["categoria_nome"].ToString(),
                        reader["barCode"].ToString()
                    )
                    {
                        Tributo = reader["tributos_nome"].ToString(),
                        Fornecedor = reader["fornecedor"].ToString(),
                        DataValidade = reader["validade"] == DBNull.Value ? (DateTime?)null : DateTime.Parse(reader["validade"].ToString())
                    };

                    produtos.Add(produto);
                }

                reader.Close();
                salvar.SalvarEmArquivoLog("Produtos selecionados com sucesso.", "200");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar produtos do banco");
                salvar.SalvarEmArquivoLog("Erro ao selecionar produtos: " + ex.ToString(), "500");
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    salvar.SalvarEmArquivoLog("Conexão fechada.", "200");
                }
            }

            return produtos;
        }

        public string RemoverProduto()
        {
            if (ProcurarProduto() == null)
            {
                return "Não foi possivel remover";
            }

            var mensagem = "Não foi possivel remover";
            if (string.IsNullOrEmpty(CodigoBarras))
                return mensagem;

            using (MySqlConnection conn = new MySqlConnection(Url))
            {
                try
                {
                    salvar.SalvarEmArquivoLog("Tentando abrir conexão com o banco de dados para remover produto.", "200");
                    conn.Open();
                    salvar.SalvarEmArquivoLog("Conexão aberta com sucesso.", "200");

                    string query = "DELETE FROM produtos WHERE barCode = @id";
                    MySqlCommand comando = new MySqlCommand(query, conn);
                    comando.Parameters.AddWithValue("@id", CodigoBarras);

                    comando.ExecuteNonQuery();
                    mensagem = "Produto Removido";
                    salvar.SalvarEmArquivoLog("Produto removido com sucesso.", "200");
                }
                catch (Exception ex)
                {
                    salvar.SalvarEmArquivoLog("Erro ao remover produto: " + ex.ToString(), "500");
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
        }

        public void AtualizarProduto()
        {
            using (MySqlConnection conn = new MySqlConnection(Url))
            {
                try
                {
                    salvar.SalvarEmArquivoLog("Tentando abrir conexão com o banco de dados para atualizar produto.", "200");
                    conn.Open();
                    salvar.SalvarEmArquivoLog("Conexão aberta com sucesso.", "200");

                    string query = @"
                        UPDATE produtos 
                        SET 
                            nome = @nome,
                            preco = @preco,
                            quantidade = @quantidade,
                            is_peso = @isPeso,
                            categoria_nome = @categoria,
                            validade = @validade,
                            fornecedor = @fornecedor,
                            tributos_nome = @tributo
                        WHERE 
                            barCode = @barcode";

                    MySqlCommand comando = new MySqlCommand(query, conn);
                    comando.Parameters.AddWithValue("@barCode", CodigoBarras);
                    comando.Parameters.AddWithValue("@nome", Nome);
                    comando.Parameters.AddWithValue("@preco", Preco);
                    comando.Parameters.AddWithValue("@quantidade", Quantidade);
                    comando.Parameters.AddWithValue("@isPeso", IsPeso ? 1 : 0);
                    comando.Parameters.AddWithValue("@categoria", Categoria);
                    comando.Parameters.AddWithValue("@validade", DataValidade);
                    comando.Parameters.AddWithValue("@fornecedor", Fornecedor);
                    comando.Parameters.AddWithValue("@tributo", Tributo);

                    comando.ExecuteNonQuery();
                    salvar.SalvarEmArquivoLog("Produto atualizado com sucesso.", "200");
                }
                catch (Exception ex)
                {
                    salvar.SalvarEmArquivoLog("Erro ao atualizar produto: " + ex.ToString(), "500");
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                        salvar.SalvarEmArquivoLog("Conexão fechada.", "200");
                    }
                }
            }
        }

        public Produto ProcurarProduto()
        {
            MySqlConnection conn = new MySqlConnection(Url);
            if (string.IsNullOrEmpty(CodigoBarras))
                return null;

            try
            {
                salvar.SalvarEmArquivoLog("Tentando abrir conexão com o banco de dados para procurar produto.", "200");
                conn.Open();
                salvar.SalvarEmArquivoLog("Conexão aberta com sucesso.", "200");

                MySqlCommand comando = new MySqlCommand("SELECT * FROM produtos where barCode = @id", conn);
                comando.Parameters.AddWithValue("@id", CodigoBarras);

                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Produto produto = new Produto(
                        reader["nome"].ToString(),
                        decimal.Parse(reader["preco"].ToString()),
                        decimal.Parse(reader["quantidade"].ToString()),
                        bool.Parse(reader["is_peso"].ToString()),
                        reader["categoria_nome"].ToString(),
                        reader["barCode"].ToString()
                    )
                    {
                        Tributo = reader["tributos_nome"].ToString(),
                        Fornecedor = reader["fornecedor"].ToString(),
                        DataValidade = reader["validade"] == DBNull.Value ? (DateTime?)null : DateTime.Parse(reader["validade"].ToString())
                    };

                    return produto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar produtos do banco");
                salvar.SalvarEmArquivoLog("Erro ao selecionar produto: " + ex.ToString(), "500");
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    salvar.SalvarEmArquivoLog("Conexão fechada.", "200");
                }
            }

            return null;
        }

        public Produto ProcurarProduto(string codigoDeBarras)
        {
            MySqlConnection conn = new MySqlConnection(Url);
            if (string.IsNullOrEmpty(codigoDeBarras))
                return null;

            try
            {
                salvar.SalvarEmArquivoLog("Tentando abrir conexão com o banco de dados para procurar produto pelo código de barras.", "200");
                conn.Open();
                salvar.SalvarEmArquivoLog("Conexão aberta com sucesso.", "200");

                MySqlCommand comando = new MySqlCommand("SELECT * FROM produtos where barCode = @id", conn);
                comando.Parameters.AddWithValue("@id", codigoDeBarras);

                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Produto produto = new Produto(
                        reader["nome"].ToString(),
                        decimal.Parse(reader["preco"].ToString()),
                        decimal.Parse(reader["quantidade"].ToString()),
                        bool.Parse(reader["is_peso"].ToString()),
                        reader["categoria_nome"].ToString(),
                        reader["barCode"].ToString()
                    )
                    {
                        Tributo = reader["tributos_nome"].ToString(),
                        Fornecedor = reader["fornecedor"].ToString(),
                        DataValidade = reader["validade"] == DBNull.Value ? (DateTime?)null : DateTime.Parse(reader["validade"].ToString())
                    };

                    return produto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar produto do banco");
                salvar.SalvarEmArquivoLog("Erro ao selecionar produto: " + ex.ToString(), "500");
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    salvar.SalvarEmArquivoLog("Conexão fechada.", "200");
                }
            }

            return null;
        }
    }
}
