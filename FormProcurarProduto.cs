using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PadariaJJM
{
    public partial class FormProcurarProduto : Form
    {
        bool isPeso = false;
        public FormProcurarProduto()
        {
            InitializeComponent();

            Produto produto = new Produto();
            List<Produto> listaProdutos = produto.PegarTodos();
            tabela.CellFormatting += dgvProdutos_CellFormatting;
            tabela.DataSource = listaProdutos;
            

        }
        private void dgvProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            
            // Verificar se a célula a ser formatada é a célula da coluna de preço (supondo que a coluna de preço seja a segunda coluna)
            if (e.ColumnIndex == 2 && e.Value != null) // Altere 1 para o índice correto da coluna de preço
            {
                // Adicionar "R$" ao valor da célula
                e.Value = "R$" + e.Value.ToString();
                e.FormattingApplied = true; // Indicar que a formatação foi aplicada
            }
            
            if (e.ColumnIndex == 3 && e.Value != null) // Altere 2 para o índice correto da coluna de quantidade
            {
                if((bool) e.Value == true)
                    isPeso = true;
            }

            if (e.ColumnIndex == 4 && e.Value != null && isPeso)
            {
                // Adicionar " KG" ao valor da célula
                e.Value = e.Value.ToString() + " KG";
                e.FormattingApplied = true; // Indicar que a formatação foi aplicada
                isPeso = false ;
            }
        }

        private void FormProcurarProduto_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
