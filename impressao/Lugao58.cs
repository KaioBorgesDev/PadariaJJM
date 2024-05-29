using PadariaJJM;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace PadariaJJM.impressao
{
    internal class Lugao58
    {
        private readonly List<Produto> lista;
        private readonly decimal valorTotal;
        private readonly string metodo_pagamento;
        private readonly DateTime data_venda;
        private readonly decimal troco;

        public Lugao58(List<Produto> lista, decimal valorTotal, string metodo_pagamento, DateTime data_venda, decimal troco)
        {
            this.lista = lista ?? throw new ArgumentNullException(nameof(lista));
            this.valorTotal = valorTotal;
            this.metodo_pagamento = metodo_pagamento ?? throw new ArgumentNullException(nameof(metodo_pagamento));
            this.data_venda = data_venda;
            this.troco = troco;
        }

        public void ImprimirCupom()
        {
            string portaSerial = "COM1";
            int baudRate = 9600;
            string dadosParaImpressao = GerarDadosParaImpressao();

            using (SerialPort serialPort = new SerialPort(portaSerial, baudRate))
            {
                try
                {
                    serialPort.Open();

                    if (serialPort.IsOpen)
                    {
                        byte[] buffer = Encoding.ASCII.GetBytes(dadosParaImpressao);
                        serialPort.Write(buffer, 0, buffer.Length);

                        // Comando de corte de papel (ESC/POS)
                        byte[] corte = { 0x1B, 0x69 }; // ESC i
                        serialPort.Write(corte, 0, corte.Length);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao imprimir: {ex.Message}");
                }
                finally
                {
                    if (serialPort.IsOpen)
                    {
                        serialPort.Close();
                    }
                }
            }
        }

        private string GerarDadosParaImpressao()
        {
            StringBuilder dadosParaImpressao = new StringBuilder();

            dadosParaImpressao.AppendLine("                     PADARIA JJM                   ");
            dadosParaImpressao.AppendLine("          Rua Mato Grosso do Sul, Monte Mor, 401 A");
            dadosParaImpressao.AppendLine("          CNPJ: 1923819283989 013");
            dadosParaImpressao.AppendLine("---------------------------------------------------");
            dadosParaImpressao.AppendLine($"Data: {data_venda:dd/MM/yyyy} Hora: {data_venda:HH:mm:ss}");
            dadosParaImpressao.AppendLine("---------------------------------------------------");
            dadosParaImpressao.AppendLine($"                     Extrato nº {1}");
            dadosParaImpressao.AppendLine("             Cupom Fiscal Eletronico ");
            dadosParaImpressao.AppendLine("---------------------------------------------------");
            dadosParaImpressao.AppendLine("NUM | CODIGO | PRODUTO       | QTD | PRECO UN R$ | PRECO TOTAL R$");
            dadosParaImpressao.AppendLine("---------------------------------------------------");

            int i = 0;
            foreach (Produto produto in lista)
            {
                i++;
                string precoUnitario = (produto.Preco / produto.Quantidade).ToString("F2");
                string precoTotal = produto.Preco.ToString("F2");
                dadosParaImpressao.AppendLine($"{i,3} | {produto.CodigoBarras,6} | {produto.Nome,-12} | {produto.Quantidade,3} | {precoUnitario,10} | {precoTotal,12}");
            }

            dadosParaImpressao.AppendLine("---------------------------------------------------");
            dadosParaImpressao.AppendLine($"Total: {valorTotal,45:C2}");
            dadosParaImpressao.AppendLine($"Método de Pagamento: {metodo_pagamento}");
            dadosParaImpressao.AppendLine($"Troco: {troco:C2}");
            dadosParaImpressao.AppendLine("---------------------------------------------------");
            dadosParaImpressao.AppendLine("Obrigado pela compra!");

            return dadosParaImpressao.ToString();
        }
    }
}
