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
            if (!string.IsNullOrEmpty(nome.Text) && !string.IsNullOrEmpty(valorImposto.Text))
            {
                //colocar o try parse
                int valorImp;

                if (!int.TryParse(valorImposto.Text, out valorImp))
                {
                    MessageBox.Show("Valor do imposto incorreto!");
                    return;
                }
                Tributo tributo = new Tributo(nome.Text, valorImp);
                MessageBox.Show(tributo.Inserir());
                return;
            }
            MessageBox.Show("Verifique as Informaçoes");

        }
    }
}
