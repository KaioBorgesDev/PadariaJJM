using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaJJM
{
    public partial class FormAdicionarProduto : Form
    {
        public FormAdicionarProduto()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                data.Enabled = true;
            }
            else
            {
                data.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                barCode.Enabled = true;
            }
            else
            {
                barCode.Enabled = false;
            }

        }

        private void checkboxPeso_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxPeso.Checked)
            {
                pesoPreco.Enabled = true;

            }
            else
            {
                pesoPreco.Enabled = false;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                fornecedor.Enabled = true;
            }
            else
            {
                fornecedor.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar campos obrigatórios
            if (string.IsNullOrWhiteSpace(nome.Text))
            {
                MessageBox.Show("Por favor, insira o nome do produto.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(preco.Text))
            {
                MessageBox.Show("Por favor, insira o preço do produto.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(preco.Text, out _))
            {
                MessageBox.Show("Por favor, insira um preço válido para o produto.", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(quantidade.Text))
            {
                MessageBox.Show("Por favor, insira a quantidade do produto.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(quantidade.Text, out _))
            {
                MessageBox.Show("Por favor, insira uma quantidade válida para o produto.", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar campo de data de validade, se habilitado
            if (checkBox1.Checked && !DateTime.TryParse(data.Text, out _))
            {
                MessageBox.Show("Por favor, insira uma data de validade válida para o produto.", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar campo de código de barras, se habilitado
            if (checkBox2.Checked && string.IsNullOrWhiteSpace(barCode.Text))
            {
                MessageBox.Show("Por favor, insira o código de barras do produto.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar campo de fornecedor, se habilitado
            if (checkBox3.Checked && string.IsNullOrWhiteSpace(fornecedor.Text))
            {
                MessageBox.Show("Por favor, insira o nome do fornecedor do produto.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkboxPeso.Checked && string.IsNullOrWhiteSpace(pesoPreco.Text))
            {
                MessageBox.Show("Por favor, insira o peso do produto.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Produto produto = new Produto("Pão Francês", 1.50m, 100);
            produto.PrecoPorPeso = 5.00m;
            produto.DataValidade = DateTime.Now.AddDays(43);
            produto.CodigoBarras = "1234567890123";
            produto.Fornecedor = "Fornecedor A";

            
            if (produto.IsValid())
            {
                
                // Salvar o produto no banco de dados ou realizar outras operações
                MessageBox.Show("Produto válido. Salvo no banco de dados...");
                string caminho = "C:\\Users\\Administrador\\Documents\\Importante\\PadariaJJM\\arquivos\\produtos.txt";
                produto.SalvarEmArquivo(caminho);

                List<Produto> produtos = Produto.CarregarDoArquivo(caminho);
                foreach(var pd in produtos)
                {
                    MessageBox.Show(pd.Nome.ToString());
                }

            }
            else
            {
                MessageBox.Show("Produto inválido. Verifique os valores.");
            }
        }

        

    }
}
