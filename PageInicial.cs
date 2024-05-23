using PadariaJJM.entidade;

namespace PadariaJJM
{
    public partial class PageInicial : Form
    {
        public PageInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void adicionarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdicionarProduto formAdicionarProduto = new FormAdicionarProduto();
            formAdicionarProduto.Show();
        }

        private void nomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProcurarProduto formProcurarProduto = new FormProcurarProduto();
            formProcurarProduto.Show();
        }

        private void adicionarCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAddCategoria categoria = new FormAddCategoria();
            categoria.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAddTributo formTributo = new FormAddTributo();
            formTributo.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarProdutoForm prod = new AtualizarProdutoForm();
            prod.Show();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProdutoRemoverForm produto = new ProdutoRemoverForm(); 
            produto.Show();
        }
    }
}
