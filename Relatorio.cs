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
    public partial class Relatorio : Form
    {
        Venda venda = new Venda();
        public Relatorio()
        {
            InitializeComponent();
            tbVendas.DataSource = venda.ObterTodasAsVendas();
            vendaTotal.Text = venda.ObterTotalValorVendas().ToString("C");
           

        }

        private void mes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
