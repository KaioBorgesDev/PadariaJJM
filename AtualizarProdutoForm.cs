using PadariaJJM.entidade;
using PadariaJJM.log;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PadariaJJM
{
    public partial class AtualizarProdutoForm : Form
    {
        public AtualizarProdutoForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //btn Procurar
        private void button2_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(textBox1.Text, out int val))
            {
                MessageBox.Show("Você digitou um valor um numero.");
                return;
            }
            int id_procurado = int.Parse(textBox1.Text);
            Produto produto = new Produto();
            Categoria categoria = new Categoria();
            Tributo tributo = new Tributo();


            var categorias = categoria.PegarCategorias();
            var tributos = tributo.SelecionarTodos();

            if (categorias.Count != 0)
            {
                comboBox1_att.Items.Clear();
                comboBox2_att.Items.Clear();
                comboBox1_att.Text = "";
                comboBox2_att.Text = "";
                foreach (var c in categorias)
                {
                    comboBox1_att.Items.Add(c.Name);

                }
            }

            foreach (var t in tributos)
            {
                comboBox2_att.Items.Add(t.Nome);
            }

            Produto produto1;

            produto.idProduto = id_procurado;

            produto1 = produto.ProcurarProduto();
            if (produto1 != null)
            {
                nome_att.Text = produto1.Nome;
                preco_att.Text = produto1.Preco.ToString();
                checkboxPeso_att.Checked = produto1.IsPeso;
                comboBox1_att.SelectedText = produto1.Categoria;
                quantidade_att.Text = produto1.Quantidade.ToString();
                barCode_att.Text = produto1.CodigoBarras;
                dateTimePicker1_att.Text = produto1.DataValidade.ToString();
                fornecedor_att.Text = produto1.Fornecedor;
                comboBox2_att.Text = produto1.Tributo;
            }
            else
            {
                MessageBox.Show("Produto não encontrado!");
            }
        }

        //btn Update
        private void button1_Click(object sender, EventArgs e)
        {
            // Validar campos obrigatórios
            if (string.IsNullOrWhiteSpace(nome_att.Text))
            {
                MessageBox.Show("Por favor, insira o nome do produto.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(preco_att.Text))
            {
                MessageBox.Show("Por favor, insira o preço do produto.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(preco_att.Text, out _))
            {
                MessageBox.Show("Por favor, insira um preço válido para o produto.", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(quantidade_att.Text))
            {
                MessageBox.Show("Por favor, insira a quantidade do produto.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(quantidade_att.Text, out _))
            {
                MessageBox.Show("Por favor, insira uma quantidade válida para o produto.", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar campo de data de validade, se habilitado
            if (checkBoxValidade_att.Checked)
            {
                if (!DateTime.TryParse(dateTimePicker1_att.Text, out DateTime dataValidade) || dataValidade <= DateTime.Now)
                {
                    MessageBox.Show("Por favor, insira uma data de validade válida para o produto.", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Validar campo de código de barras, se habilitado
            if (checkBoxCodigoBar_Att.Checked && string.IsNullOrWhiteSpace(barCode_att.Text))
            {
                MessageBox.Show("Por favor, insira o código de barras do produto.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar campo de fornecedor, se habilitado
            if (checkBoxFornec_Att.Checked && string.IsNullOrWhiteSpace(fornecedor_att.Text))
            {
                MessageBox.Show("Por favor, insira o nome do fornecedor do produto.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1_att.SelectedItem == null)
            {
                MessageBox.Show("Por favor, insira a categoria ", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = 0;
            try
            {
                id = int.Parse(textBox1.Text);
            } catch(Exception ex) { MessageBox.Show("Coloque o Nº em Pesquisar");
                return;
            }
            
            string nome = nome_att.Text;
            decimal preco = decimal.Parse(preco_att.Text);
            bool isPeso = checkboxPeso_att.Checked;
            string categoria = comboBox1_att.Text;
            decimal quantidade = decimal.Parse(quantidade_att.Text.ToString());
            string codigoBarra = barCode_att.Text;
            DateTime data = DateTime.Parse(dateTimePicker1_att.Text) ;
            string fornecedor = fornecedor_att.Text;
            string imposto = comboBox2_att.Text;


            var produtoAtualizado = new Produto(id, nome, preco, quantidade, isPeso, categoria);
            produtoAtualizado.DataValidade = data;
            produtoAtualizado.Fornecedor = fornecedor;
            produtoAtualizado.CodigoBarras = codigoBarra;
            produtoAtualizado.Tributo = imposto;


            try
            {
                produtoAtualizado.AtualizarProduto();
                MessageBox.Show("Produto Alterado com Sucesso.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Não foi possivel alterar o produto.");
                SalvarLog salvar = new SalvarLog();
                salvar.SalvarEmArquivoLog(ex.ToString() , categoria);
            }
            

        }
    }
}
