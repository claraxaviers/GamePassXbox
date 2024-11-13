using System;
using System.Drawing;
using System.Windows.Forms;
using GamePassXbox.Data;

namespace GamePassXbox.Views
{
    public partial class LoginForms : Form
    {
        private readonly UsuarioService _usuarioService;
        public LoginForms()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
        }
        private void bntLogin_Click(object sender, EventArgs e)
        {
            string email = telaLoginLabelEmail.Text;
            string senha = telaLoginLabelSenha.Text;

            bool autenticado = _usuarioService.AutenticarUsuario(email, senha);
            if (autenticado)
            {
                // Extrair o nome de usuário (parte do e-mail antes do @)
                string nomeUsuario = email.Split('@')[0];

                // Armazenar o nome de usuário na classe de sessão
                UsuarioSessao.NomeUsuario = nomeUsuario;

                MessageBox.Show("Login bem-sucedido!");
                HomeScreenForm homeScreenForm = new HomeScreenForm();
                this.Hide();
                homeScreenForm.Show();
            }
            else
            {
                MessageBox.Show("Email ou senha inválidos..");
            }
        }

        private void bntCriarContaLinkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CriarContaForms criarContaForms = new CriarContaForms();
            criarContaForms.Show();
            this.Hide();
        }

        //mudança campos de email e senha
        private void telaLoginLabelEmail_Enter(object sender, EventArgs e)
        {
            if (telaLoginLabelEmail.Text == "Email")
            {
                telaLoginLabelEmail.Text = "";
                telaLoginLabelEmail.ForeColor = Color.Black;
            }
        }

        private void telaLoginLabelEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(telaLoginLabelEmail.Text))
            {
                telaLoginLabelEmail.Text = "Email";
                telaLoginLabelEmail.ForeColor = Color.Gray;
            }
        }

        // Evento para o campo de senha
        private void telaLoginLabelSenha_Enter(object sender, EventArgs e)
        {
            if (telaLoginLabelSenha.Text == "Senha")
            {
                telaLoginLabelSenha.Text = "";
                telaLoginLabelSenha.PasswordChar = '*';
                telaLoginLabelSenha.ForeColor = Color.Black;
            }
        }

        private void telaLoginLabelSenha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(telaLoginLabelSenha.Text))
            {
                telaLoginLabelSenha.Text = "Senha";
                telaLoginLabelSenha.PasswordChar = '\0';
                telaLoginLabelSenha.ForeColor = Color.Gray;
            }
        }

    }
}
