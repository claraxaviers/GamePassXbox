using System;
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
    }
}
