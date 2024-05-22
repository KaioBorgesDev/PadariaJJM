using PadariaJJM.entidade;

namespace PadariaJJM
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
