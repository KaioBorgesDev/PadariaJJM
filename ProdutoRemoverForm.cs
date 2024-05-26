namespace PadariaJJM
{
    public partial class ProdutoRemoverForm : Form
    {
        public ProdutoRemoverForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Produto> produtos = new List<Produto>();
            Produto produto = new Produto();
            if (string.IsNullOrEmpty(barCode.Text))
            {
                MessageBox.Show("Digite no campo");
                return;
            }

            
        produto.CodigoBarras = barCode.Text;
        var p = produto.ProcurarProduto();

        if (p != null)
        {
            try
            {
                dataGridView1.Rows.Clear();
            }
            catch
            {

            }
            produtos.Add(p);
            dataGridView1.DataSource = produtos;
            return;
        }
        MessageBox.Show("Produto não foi achado!");
    }
        

        private void button2_Click_1(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            if (!string.IsNullOrEmpty(barCode.Text))
            {
                produto.CodigoBarras = barCode.Text;
            }
           

            if (produto.RemoverProduto() != "Não foi possivel remover")
            {
                MessageBox.Show("Produto Removido!");
                return;
            }
            MessageBox.Show("Produto Não Foi Removido!");


        }
    }
}
