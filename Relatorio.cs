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
            data.CustomFormat = "MM/yyyy";

            DateTime dataInicial = data.Value;
            AtualizarVendasDataGridView(dataInicial.Month, dataInicial.Year);
        }

        private void data_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataSelecionada = data.Value;
            int mes = dataSelecionada.Month;
            int ano = dataSelecionada.Year;
            decimal totalMes = AtualizarVendasDataGridView(mes, ano);
            valorMes.Text = totalMes.ToString("C");

        }
        private decimal AtualizarVendasDataGridView(int mes, int ano)
        {
            List<Venda> vendasFiltradas = venda.ObterVendasPorMesAno(mes, ano);
            tbVendas.DataSource = vendasFiltradas;
            decimal total = 0;
            foreach (var venda in vendasFiltradas)
            {
                total += venda.Preco_total;
            }
            return total;
        }
    }
}
