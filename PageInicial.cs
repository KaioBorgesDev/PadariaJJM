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
            var listMetodos = new string[] { "Dinheiro", "Cart�o Debito", "Cart�o Credito", "� prazo" };

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
            qtdTB.Text = "1";
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
            if (mtd_Pagamento.Text == "")
            {
                MessageBox.Show("Selecione um metodo de pagamento.");
                return;

            }
            if (decimal.Parse(valor_Troco.Text) < 0)
            {
                MessageBox.Show("Est� faltando dinheiro. Verifique o troco.");
                return;
            }
            if (produtosVenda.Count == 0)
            {
                MessageBox.Show("N�o tem nenhuma venda sendo realizada!");
                return;
            }


            Venda v = new Venda(null, decimal.Parse(valorTotallb.Text), mtd_Pagamento.Text, DateTime.Now);

            if (cpf_check.Checked)
            {
                v.Cpf = cpf.Text;
            }
            if (mtd_Pagamento.Text == "Dinheiro")
            {
                v.Troco = decimal.Parse(valor_Troco.Text);
            }

            if (v.inserirVenda() == "Inserido com Sucesso!")
            {
                //metodo aonde retiro o produto vendido do estoque

                foreach (var product in produtosVenda)
                {
                    var quantidadeRetirada = product.Quantidade;
                    Produto produto = product.ProcurarProduto(product.CodigoBarras);
                    produto.Quantidade -= quantidadeRetirada;
                    produto.AtualizarProduto();
                }
                produtosVenda.Clear();

                DialogResult resultado = new DialogResult();
                resultado = MessageBox.Show("Imprimir a via?", "Venda Finalizada.", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    //implementar a logica de imprimir a via
                    try
                    {
                        MessageBox.Show("Imprimindo sua via");
                    }
                    catch (Exception)
                    {


                    }
                }
                valorTotallb.Text = "0";
                valor_Troco.Text = "0";
                cpf.Text = "";
                troco_caixa.Text = "0";
                mtd_Pagamento.Text = "";
                return;
            }

            MessageBox.Show("N�o foi possivel terminar a venda. \n Erro ao inserir.");
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
                var texto = qtdTB.Text;
                bool havePointer = texto.Contains('.');
                if(havePointer )
                {
                    MessageBox.Show("Por Favor use virgula no lugar de '.'");
                    return;
                }
                try
                {
                    Produto produto = new Produto();
                    // aqui eu crio um produto, e busco pela textbox2 (codigo de barras)
                    produto = produto.ProcurarProduto(textBox2.Text);

                    if (produto != null)
                    {
                        if (decimal.TryParse(qtdTB.Text, out decimal quantidade))
                        {
                            bool isQuantidadeValida = false;

                            // Verifica se o produto � vendido por peso
                            if (produto.IsPeso)
                            {
                                isQuantidadeValida = true; // Permite quantidades fracion�rias e inteiras
                            }
                            else
                            {
                                // Verifica se a quantidade � um n�mero inteiro para produtos vendidos por unidade
                                if (quantidade % 1 == 0)
                                {
                                    isQuantidadeValida = true; // Apenas inteiros s�o v�lidos
                                }
                            }

                            if (isQuantidadeValida)
                            {
                                if (!produto.IsPeso)
                                    produto.Quantidade = Math.Round(quantidade);
                                else
                                    produto.Quantidade = quantidade;

                                
                                produto.ValorTotal = Math.Round(produto.Quantidade * produto.Preco, 2);
                                produtosVenda.Add(produto);

                                // ao adicionar eu solto um som de bip
                                player.Play();
                                decimal valorTotal = decimal.Parse(valorTotallb.Text);
                                valorTotal += produto.ValorTotal;
                                valorTotallb.Text = valorTotal.ToString();

                                // Atualiza a exibi��o do DataGridView
                                dataGridView1.DataSource = null;
                                dataGridView1.DataSource = produtosVenda;

                                // Limpa a caixa de texto ap�s a opera��o
                                textBox2.Text = "";
                                qtdTB.Text = "1"; // Reseta a quantidade para 1
                            }
                            else
                            {
                                MessageBox.Show($"A quantidade de {produto.Nome} deve ser um n�mero inteiro.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Quantidade inv�lida. Verifique se n�o h� caracteres n�o num�ricos.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Produto n�o encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                e.Handled = true; // Evita o beep padr�o do Enter
                e.SuppressKeyPress = true; // Evita a inser��o da nova linha
            }
        }


    }
}

