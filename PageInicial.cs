using PadariaJJM.entidade;
using System.ComponentModel;
using System.Media;

namespace PadariaJJM
{
    public partial class PageInicial : Form
    {
        SoundPlayer player = new SoundPlayer();
        BindingList<Produto> produtosVenda = new BindingList<Produto>();

        public PageInicial()
        {
            InitializeComponent();

            player.SoundLocation = @"arquivos\sounds\sound.wav";
            var listMetodos = new string[] { "Dinheiro", "Cartão Debito", "Cartão Credito", "Á prazo" };

            foreach (var mtd in listMetodos)
            {
                mtd_Pagamento.Items.Add(mtd);
            }
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



        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            painelVendas.Visible = true;
            label1.Visible = true;
            textBox1.Text = "1";
            dataGridView1.DataSource = produtosVenda;

        }

        private void fecharCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            painelVendas.Visible = false;
            label1.Visible = false;

            // Desvincula o DataGridView da fonte de dados antes de limpar a lista
            dataGridView1.DataSource = null;

            valor_Troco.Text = "";
            valorTotallb.Text = "";

            // Limpa a lista de produtos
            produtosVenda.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Remove o evento para evitar recursão durante a modificação do texto
            
        }

        private void valorTotallb_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString();
        }

        private void mtd_Pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTroco.Visible = false;
            valor_Troco.Visible = false;
            valor_Troco.Text = "0";
            troco_caixa.Visible = false;
            if (mtd_Pagamento.Text == "Dinheiro")
            {
                lbTroco.Visible = true;
                valor_Troco.Visible = true;
                troco_caixa.Visible = true;
                return;
            }

        }

        private void troco_caixa_TextChanged(object sender, EventArgs e)
        {

            troco_caixa.TextChanged -= troco_caixa_TextChanged;
            valor_Troco.Text = "0";
            if (troco_caixa.Text != string.Empty)
            {
                try
                {
                    decimal troco_resultado = (decimal.Parse(troco_caixa.Text) - (decimal.Parse(valorTotallb.Text)));

                    valor_Troco.Text = troco_resultado.ToString();
                }
                catch (Exception) { }

            }


            troco_caixa.TextChanged += troco_caixa_TextChanged;

        }

        private void vender_Click(object sender, EventArgs e)
        {


            if (mtd_Pagamento.Text == "Dinheiro")
            {
                Venda v = new Venda(null, decimal.Parse(valorTotallb.Text), "Dinheiro", DateTime.Now, decimal.Parse(valor_Troco.Text));
                if (v.inserirVenda() == "Inserido com Sucesso!")
                    produtosVenda.Clear();

                return;
            }
            var metodo = mtd_Pagamento.Text;

            Venda venda = new Venda(null, decimal.Parse(valorTotallb.Text), metodo, DateTime.Now);
            venda.inserirVenda();
            produtosVenda.Clear();
        }

        private void cpf_check_CheckedChanged(object sender, EventArgs e)
        {
            if (cpf.Enabled == true)
                cpf.Enabled = false;
            else
                cpf.Enabled = true;
        }

        private void textbox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                
                try
                {
                    Produto produto = new Produto();
                    //aqui eu crio um produto, e busco pela textbox2 (codigo de barras)
                    produto = produto.ProcurarProduto(textBox2.Text);

                    if (produto != null)
                    {
                        if (decimal.TryParse(textBox1.Text, out decimal quantidade))
                        {
                            produto.Quantidade = quantidade;
                            produto.ValorTotal = Math.Round(produto.Quantidade * produto.Preco, 2);
                            produtosVenda.Add(produto);
                            player.Play();
                            decimal valorTotal = decimal.Parse(valorTotallb.Text);
                            valorTotal += produto.ValorTotal;
                            valorTotallb.Text = valorTotal.ToString();
                            // Atualiza a exibição do DataGridView
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = produtosVenda;
                        }
                        else
                        {
                            MessageBox.Show("Quantidade não aceitada (Verifique se há algum ponto ou letras)");
                        }
                    }

                    // Limpa a caixa de texto após a operação
                    textBox2.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                e.Handled = true; // Evita o beep padrão do Enter
                e.SuppressKeyPress = true; // Evita a inserção da nova linha
            }
        }

    }
}

