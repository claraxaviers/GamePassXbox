using GamePassXbox.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GamePassXbox.Views
{
    public partial class HomeScreenForm : Form
    {
        public HomeScreenForm()
        {
            InitializeComponent();
            this.FormClosing += HomeScreenForm_FormClosing;
            
        }
        private void HomeScreenForm_Load(object sender, EventArgs e)
        {
            labelNomeUsuario.Text = UsuarioSessao.NomeUsuario;
        }
        private void HomeScreenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForms loginForms = new LoginForms();
            loginForms.ShowDialog();                     
        }

        private void textBoxPesquisar_Enter(object sender, EventArgs e)
        {
            if (textBoxPesquisar.Text == "pesquisar jogos, complementos e muito mais")
            {
                textBoxPesquisar.Text = "";
                textBoxPesquisar.ForeColor = Color.White;
            }
        }

        private void buttonMinhaBiblioteca_Click(object sender, EventArgs e)
        {
            MinhaBibliotecaJogos minhaBibliotecaJogos = new MinhaBibliotecaJogos();
            this.Hide();
            minhaBibliotecaJogos.Show();

        }

        private void pictureBlackOps6_Click(object sender, EventArgs e)
        {
            MinhaBibliotecaCallOfDuty minhaBibliotecaCallOfDuty = new MinhaBibliotecaCallOfDuty();
            this.Hide();
            minhaBibliotecaCallOfDuty.Show();

        }       
    }
}
