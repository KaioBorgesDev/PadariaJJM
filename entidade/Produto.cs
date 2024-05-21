using Microsoft.VisualBasic;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PadariaJJM
{
    public class Produto
    {
        // Propriedades obrigatórias
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        // Propriedades opcionais
        public decimal? PrecoPorPeso { get; set; } // Peso Preço é opcional
        public DateTime? DataValidade { get; set; } // Data de Validade é opcional
        public string CodigoBarras { get; set; } // Código de Barras é opcional
        public string Fornecedor { get; set; } // Fornecedor é opcional

        // Construtor para as propriedades obrigatórias
        public Produto(string nome, decimal preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Método para validar se o produto está pronto para ser salvo
        public bool IsValid()
        {
            // Verifica se o nome, preço e quantidade são obrigatórios e têm valores válidos
            if (string.IsNullOrWhiteSpace(Nome) || Preco <= 0 || Quantidade <= 0)
                return false;

            // Se o preço por peso for especificado, verifica se é válido
            if (PrecoPorPeso.HasValue && PrecoPorPeso <= 0)
                return false;

            // Se a data de validade for especificada, verifica se é válida
            if (DataValidade.HasValue && DataValidade < DateTime.Now)
                return false;

            return true;
        }
        public static List<Produto> CarregarDoArquivo(string caminho)
        {
            List<Produto> produtos = new List<Produto>();

            try
            {
                using (StreamReader reader = new StreamReader(caminho))
                {
                    string linha;
                    Produto produto = null;

                    while ((linha = reader.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(linha))
                        {
                            // Adiciona o produto à lista se não for nulo e válido
                            if (produto != null && produto.IsValid())
                                produtos.Add(produto);

                            // Reinicia o produto para o próximo ciclo
                            produto = null;
                        }
                        else
                        {
                            // Processa cada linha para criar um produto
                            string[] partes = linha.Split(':');
                            string chave = partes[0].Trim();
                            string valor = partes[1].Trim();

                            switch (chave)
                            {
                                case "Nome":
                                    produto = new Produto(valor, 0, 0); // Cria um novo produto com o nome especificado
                                    break;
                                case "Preço":
                                    produto.Preco = decimal.Parse(valor.Replace("R$", "").Trim()); // Remove o símbolo de moeda e converte para decimal
                                    break;
                                case "Quantidade":
                                    produto.Quantidade = int.Parse(valor);
                                    break;
                                case "Preço por Peso":
                                    produto.PrecoPorPeso = decimal.Parse(valor.Replace("R$", "").Trim());
                                    break;
                                case "Data de Validade":
                                    produto.DataValidade = DateTime.Parse(valor);
                                    break;
                                case "Código de Barras":
                                    produto.CodigoBarras = valor;
                                    break;
                                case "Fornecedor":
                                    produto.Fornecedor = valor;
                                    break;
                            }
                        }
                    }

                    // Adiciona o último produto à lista se não for nulo e válido
                    if (produto != null && produto.IsValid())
                        produtos.Add(produto);
                }

                Console.WriteLine("Produtos carregados com sucesso do arquivo.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao carregar os produtos do arquivo: {ex.Message}");
            }

            return produtos;
        }

        public void SalvarEmArquivo(string caminho)
        {
            // Verifica se o produto é válido antes de salvar
            if (!IsValid())
            {
                Console.WriteLine("Produto inválido. Não é possível salvar.");
                return;
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(caminho, true))
                {
                    // Escreve os detalhes do produto no arquivo
                    writer.WriteLine($"Nome: {Nome}");
                    writer.WriteLine($"Preço: {Preco}");
                    writer.WriteLine($"Quantidade: {Quantidade}");

                    if (PrecoPorPeso.HasValue)
                        writer.WriteLine($"Preço por Peso: {PrecoPorPeso}");

                    if (DataValidade.HasValue)
                    {
                        
                        writer.WriteLine($"Data de Validade: {DataValidade.Value.ToString("dd MM yyyy")}");
                    }
                    
                   

                    if (!string.IsNullOrEmpty(CodigoBarras))
                        writer.WriteLine($"Código de Barras: {CodigoBarras}");

                    if (!string.IsNullOrEmpty(Fornecedor))
                        writer.WriteLine($"Fornecedor: {Fornecedor}");

                    writer.WriteLine(); // Adiciona uma linha em branco para separar os produtos no arquivo
                }

                Console.WriteLine("Produto salvo com sucesso no arquivo.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao salvar o produto no arquivo: {ex.Message}");
            }
        }
       

    }
}