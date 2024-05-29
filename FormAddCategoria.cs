using PadariaJJM.entidade;

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
            Categoria categoria = new Categoria(nome_categoria.Text);

            if (categoria != null)
            {
                resposta = categoria.Inserir();
            }

            if (resposta != "Não foi salvo!")
            {
                MessageBox.Show("Salvo com sucesso!");
                return;
            }
            MessageBox.Show(resposta);
        }
    }
}
