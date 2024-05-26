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
        List<Produto> lista = new List<Produto>();
        decimal valorTotal;
        string metodo_pagamento;
        DateTime data_venda;
        decimal troco;

        public Lugao58(List<Produto> lista, decimal valorTotal, string metodo_pagamento, DateTime data_venda, decimal troco)
        {
            this.lista = lista;
            this.valorTotal = valorTotal;
            this.metodo_pagamento = metodo_pagamento;
            this.data_venda = data_venda;
            this.troco = troco;
        }

        public void imprimirCupom()
        {
            // Substitua "COM1" pela porta serial correta em que a sua impressora está conectada.
            string portaSerial = "COM1";
            int baudRate = 9600;
            string dadosParaImpressao = "";

            // Configuração da porta serial
            using (SerialPort serialPort = new SerialPort(portaSerial, baudRate))
            {
                try
                {
                    // Abre a porta serial
                    serialPort.Open();

                    if (serialPort.IsOpen)
                    {
                        dadosParaImpressao += "                     PADARIA JJM                   \n";
                        dadosParaImpressao += "          Rua Mato Grosso do Sul, Monte Mor, 401 A\n";
                        dadosParaImpressao += "          CNPJ: 1923819283989 013\n";
                        dadosParaImpressao += "---------------------------------------------------\n";
                        dadosParaImpressao += $"Data: {data_venda:dd/MM/yyyy} Hora: {data_venda:HH:mm:ss}\n";
                        dadosParaImpressao += "---------------------------------------------------\n";
                        dadosParaImpressao += $"                     Extrato nº {1}\n";
                        dadosParaImpressao += "             Cupom Fiscal Eletronico \n";
                        dadosParaImpressao += "---------------------------------------------------\n";
                        dadosParaImpressao += "NUM | CODIGO | PRODUTO       | QTD | PRECO UN R$ | PRECO TOTAL R$\n";
                        dadosParaImpressao += "---------------------------------------------------\n";

                        int i = 0;
                        foreach (Produto produto in lista)
                        {
                            i++;
                            string precoUnitario = (produto.Preco / produto.Quantidade).ToString("F2");
                            string precoTotal = produto.Preco.ToString("F2");
                            dadosParaImpressao += $"{i,3} | {produto.CodigoBarras,6} | {produto.Nome,-12} | {produto.Quantidade,3} | {precoUnitario,10} | {precoTotal,12}\n";
                        }

                        dadosParaImpressao += "---------------------------------------------------\n";
                        dadosParaImpressao += $"Total: {valorTotal,45:C2}\n";
                        dadosParaImpressao += $"Método de Pagamento: {metodo_pagamento}\n";
                        dadosParaImpressao += $"Troco: {troco:C2}\n";
                        dadosParaImpressao += "---------------------------------------------------\n";
                        dadosParaImpressao += "Obrigado pela compra!\n";

                        // Converte os dados em bytes e envia para a impressora
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
                    // Fecha a porta serial
                    if (serialPort.IsOpen)
                    {
                        serialPort.Close();
                    }
                }
            }
        }
    }
}
