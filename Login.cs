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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            senha.UseSystemPasswordChar = true;
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            if(usuario.Text == "PadariaADM@1234" && senha.Text == "Juniormeira")
            {
                Relatorio relatorio = new ();
                relatorio.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Senha ou Usuario estão incorretos.");
            }
        }
    }
}
