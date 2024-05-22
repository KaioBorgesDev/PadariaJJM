using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadariaJJM.log
{
    internal class SalvarLog
    {
        
        public void SalvarEmArquivoLog(string mensagem, string categoria)
        {
            string caminho = @"arquivos\log.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(caminho, true))
                {
                    // Escreve os detalhes do log no arquivo
                    writer.WriteLine($"Data: {DateTime.Now}");
                    writer.WriteLine($"Categoria: {categoria}");
                    writer.WriteLine($"Mensagem: {mensagem}");

                    writer.WriteLine(); // Adiciona uma linha em branco para separar os produtos no arquivo
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao salvar o log no arquivo: {ex.Message}");
            }
        }
    }
}
