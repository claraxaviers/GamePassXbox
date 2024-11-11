using System;
using System.Drawing;
using System.Windows.Forms;

namespace GamePassXbox.Views
{
    public partial class HomeScreenForm : Form
    {
        public HomeScreenForm(string email)
        {
            InitializeComponent();
            string nomeUsuario = email.Split('@')[0];
            labelEntrar.Text = nomeUsuario;
        }

        private void HomeScreenForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            LoginForms loginForms = new LoginForms();
            loginForms.Show();
            this.Close();

        }

        private void textBoxPesquisar_Enter(object sender, EventArgs e)
        {
            if (textBoxPesquisar.Text == "pesquisar jogos, complementos e muito mais")
            {
                textBoxPesquisar.Text = "";
                textBoxPesquisar.ForeColor = Color.White;
            }
        }
        private void textBoxPesquisar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPesquisar.Text))
            {
                textBoxPesquisar.Text = "pesquisar jogos, complementos e muito mais";
                textBoxPesquisar.ForeColor = Color.Silver;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MinhaBibliotecaForms minhaBibliotecaForms = new MinhaBibliotecaForms();
            minhaBibliotecaForms.Show();
        }
    }
}
