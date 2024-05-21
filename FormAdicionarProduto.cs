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
            

            Produto produto = new Produto(nome.Text, decimal.Parse(preco.Text), int.Parse(quantidade.Text));

           

            if (produto.IsValid())
            {              
                // Salvar o produto no banco de dados ou realizar outras operações
                MessageBox.Show("Salvando no Banco de Dados");
                
                

            }
            else
            {
                MessageBox.Show("Produto inválido. Verifique os valores.");
            }
        }

        

    }
}
