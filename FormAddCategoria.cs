using MySql.Data.MySqlClient;
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
    public partial class FormAddCategoria : Form
    {
        public FormAddCategoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resposta = "Não foi salvo!";
            if (string.IsNullOrEmpty(nome_categoria.Text))
            {
                MessageBox.Show("Coloque um nome por favor!");
                return;
            }
            Categoria categoria = new Categoria( nome_categoria.Text);

            if (categoria != null )
            {
                resposta = categoria.inserir();
            }

            if(resposta != "Não foi salvo!") {
                MessageBox.Show("Salvo com sucesso!"); 
                return;
            }
            MessageBox.Show(resposta);
        }
    }
}
