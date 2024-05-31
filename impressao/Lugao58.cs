using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace PadariaJJM.impressao
{
    internal class Lugao58
    {
        private readonly BindingList<Produto> lista;
        private readonly decimal valorTotal;
        private readonly string metodo_pagamento;
        private readonly DateTime data_venda;
        private readonly decimal troco;

        public Lugao58(BindingList<Produto> lista, decimal valorTotal, string metodo_pagamento, DateTime data_venda, decimal troco)
        {
            this.lista = lista ?? throw new ArgumentNullException(nameof(lista));
            this.valorTotal = valorTotal;
            this.metodo_pagamento = metodo_pagamento ?? throw new ArgumentNullException(nameof(metodo_pagamento));
            this.data_venda = data_venda;
            this.troco = troco;
        }

        public void ImprimirCupom()
        {
            string nomeDaImpressora = "POS-58"; // Substitua pelo nome correto da impressora
            string dadosParaImpressao = GerarDadosParaImpressao();

            try
            {
                RawPrinter.SendStringToPrinter(nomeDaImpressora, dadosParaImpressao);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao imprimir: {ex.Message}");
            }
        }

        private string GerarDadosParaImpressao()
        {
            StringBuilder dadosParaImpressao = new StringBuilder();

            dadosParaImpressao.AppendLine("          PADARIA JJM          ");
            dadosParaImpressao.AppendLine("     Comunidade Santa Rita");
            dadosParaImpressao.AppendLine("      Monte Mor, SP           ");
            dadosParaImpressao.AppendLine("    CNPJ: 49927885/000168    ");
            dadosParaImpressao.AppendLine("--------------------------------");
            dadosParaImpressao.AppendLine($"Data: {data_venda:dd/MM/yyyy} Hora: {data_venda:HH:mm:ss}");
            dadosParaImpressao.AppendLine("--------------------------------");
            dadosParaImpressao.AppendLine("       Cupom Fiscal Eletronico");
            dadosParaImpressao.AppendLine("--------------------------------");
            dadosParaImpressao.AppendLine("NUM | CODIGO | PRODUTO      | QTD | PRECO UN R$ | PRECO TOTAL R$");
            dadosParaImpressao.AppendLine("--------------------------------");

            int i = 0;
            foreach (Produto produto in lista)
            {
                i++;
                string precoUnitario = (produto.Preco / produto.Quantidade).ToString("F2");
                string precoTotal = produto.Preco.ToString("F2");
                dadosParaImpressao.AppendLine($"{i} | {produto.CodigoBarras,6} | {produto.Nome} | {produto.Quantidade} | {precoUnitario} | {precoTotal}");
            }

            dadosParaImpressao.AppendLine("--------------------------------");
            dadosParaImpressao.AppendLine($"Total: {valorTotal,45:C2}");
            dadosParaImpressao.AppendLine($"Método de Pagamento: {metodo_pagamento}");
            dadosParaImpressao.AppendLine($"Troco:{troco:C2}");
            dadosParaImpressao.AppendLine("--------------------------------");
            dadosParaImpressao.AppendLine("    Obrigado pela compra!     ");

            // Comando de corte de papel (ESC/POS)
            dadosParaImpressao.AppendLine("\x1B\x69"); // ESC i

            return dadosParaImpressao.ToString();
        }
    }
}