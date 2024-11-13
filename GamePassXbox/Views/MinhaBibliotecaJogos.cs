using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamePassXbox.Views
{
    public partial class MinhaBibliotecaJogos : Form
    {
        public MinhaBibliotecaJogos()
        {
            InitializeComponent();
            this.FormClosing += MinhaBibliotecaJogos_FormClosing;
        }
        private void MinhaBibliotecaJogos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonVoltarHomeScreen_Click(object sender, EventArgs e)
        {
            HomeScreenForm homeScreenForm = new HomeScreenForm();
            this.Hide();
            homeScreenForm.Show();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MinhaBibliotecaCallOfDuty minhaBibliotecaCallOfDuty = new MinhaBibliotecaCallOfDuty();
            this.Hide();
            minhaBibliotecaCallOfDuty.Show();
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
                textBoxPesquisar.ForeColor = Color.White;
            }
        }
    }
}
