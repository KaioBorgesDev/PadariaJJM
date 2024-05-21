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

            // Se a data de validade for especificada, verifica se é válida
            if (DataValidade < DateTime.Now)
                return false;

            return true;
        }
       
       

    }
}