using PadariaJJM.entidade;
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
        
        
        private List<Categoria> categorias;
        private List<Tributo> tributos;
        
        

        public FormAdicionarProduto()
        {
            InitializeComponent();
            
            Categoria categoria1 = new Categoria();
            Tributo tributo1 = new Tributo();

            categorias = categoria1.PegarCategorias();
            tributos = tributo1.SelecionarTodos();


            if (categorias != null)
            {
                if (categorias.Count != 0)
                {
                    foreach (var categoria in categorias)
                    {
                        comboBox1.Items.Add(categoria.Name);

                    }
                }

                foreach (var tributo in tributos)
                {
                    comboBox2.Items.Add(tributo.Nome);
                }
            }
              
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
            if (checkBox1.Checked)
            {
                if (!DateTime.TryParse(data.Text, out DateTime dataValidade) || dataValidade <= DateTime.Now)
                {
                    MessageBox.Show("Por favor, insira uma data de validade válida para o produto.", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
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

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, insira a categoria ", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isPeso = false;
            // verifico se e peso ou nao  
            if (checkBox3.Checked)
            {
                isPeso = true;
            }

            string categoriaSelecionada = (string) comboBox1.SelectedItem;

            Produto produto = new Produto(null, nome.Text, decimal.Parse(preco.Text), int.Parse(quantidade.Text),isPeso, categoriaSelecionada);



            if (produto.IsValid())
            {
                if (isPeso)
                {
                    produto.IsPeso = true;
                }
                if (!string.IsNullOrEmpty(barCode.Text))
                {
                    produto.CodigoBarras = barCode.Text;
                }

                if (!string.IsNullOrEmpty(fornecedor.Text))
                {
                    produto.Fornecedor = fornecedor.Text;
                }

                DateTime dataSelecionada = data.Value;

                
                // Verificar se a data selecionada é igual à data mínima permitida
                if (dataSelecionada != data.MinDate )
                {
                   produto.DataValidade = dataSelecionada;
                }
                
                
                if (comboBox2.SelectedItem != null)
                {
                    produto.Tributo = (string) comboBox2.SelectedItem;
                }

                //cadastro
               if(produto.inserir() == "Não foi salvo!")
                {
                    MessageBox.Show("Erro ao Cadastrar o Produto.");
                    return;
                }
                MessageBox.Show("Produto Cadastrado.");

            }
            else
            {
                MessageBox.Show("Produto inválido. Verifique os valores.");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
