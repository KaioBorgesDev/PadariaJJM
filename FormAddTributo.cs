using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaJJM.entidade
{
    public partial class FormAddTributo : Form
    {
        public FormAddTributo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nome.Text) && !string.IsNullOrEmpty(valorImposto.Text)) {
                //colocar o try parse
                
                Tributo tributo = new Tributo(null,nome.Text,int.Parse(valorImposto.Text));
                MessageBox.Show(tributo.inserir());
                return;
            }
            MessageBox.Show("Verifique as Informaçoes");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
