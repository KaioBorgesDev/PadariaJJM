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
            if (e.ColumnIndex == 1 && e.Value != null) // Altere 1 para o índice correto da coluna de preço
            {
                // Adicionar "R$" ao valor da célula
                e.Value = "R$" + e.Value.ToString();
                e.FormattingApplied = true; // Indicar que a formatação foi aplicada
            }


            if (e.ColumnIndex == 2 && e.Value != null) // Altere 2 para o índice correto da coluna de quantidade
            {
                bool val = bool.Parse(e.Value.ToString());
                if (val == true)
                    isPeso = true;
                return;
            }

            if (e.ColumnIndex == 3 && e.Value != null && isPeso)
            {
                // Adicionar " KG" ao valor da célula
                e.Value = e.Value.ToString() + " KG";
                isPeso = false;
                e.FormattingApplied = true; // Indicar que a formatação foi aplicada

            } else if(e.Value != null && e.ColumnIndex == 3)
            {
                
                decimal valorInteiro = decimal.Parse(e.Value.ToString());
                e.Value = Math.Round(valorInteiro);
            }
        } 
    }
}
