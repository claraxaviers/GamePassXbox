using System;
using System.Drawing;
using System.Windows.Forms;

namespace GamePassXbox.Views
{
    public partial class MinhaBibliotecaCallOfDuty : Form
    {
        public MinhaBibliotecaCallOfDuty()
        {
            InitializeComponent();
            this.FormClosing += MinhaBibliotecaCallOfDuty_FormClosing;
        }
        private void MinhaBibliotecaCallOfDuty_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonVoltarHomeScreen_Click(object sender, EventArgs e)
        {
            HomeScreenForm homeScreenForm = new HomeScreenForm();
            this.Hide();
            homeScreenForm.Show();
        }

        private void Search_Enter(object sender, EventArgs e)
        {
            if (Search.Text == "pesquisar jogos, complementos e muito mais")
            {
                Search.Text = "";
                Search.ForeColor = Color.White;
            }
        }
        private void Search_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Search.Text))
            {
                Search.Text = "pesquisar jogos, complementos e muito mais";
                Search.ForeColor = Color.White;
            }
        }

    }
}
