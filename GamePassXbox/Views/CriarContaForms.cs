using System;
using System.Drawing;
using System.Windows.Forms;
using GamePassXbox.Data;

namespace GamePassXbox.Views
{
    public partial class CriarContaForms : Form
    {
        private readonly UsuarioService _usuarioService;
        public CriarContaForms()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
            this.FormClosing += CriarContaForms_FormClosing;
        }
        private void CriarContaForms_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        private void telaCriarContaVoltarLogin_Click(object sender, EventArgs e)
        {
            LoginForms loginForms = new LoginForms();
            loginForms.Show();
            this.Close();
        }

        private void bntCriarConta_Click(object sender, EventArgs e)
        {
            string email = telaCriarLabelEmail.Text;
            string senha = telaCriarLabelSenha.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha ambos os campos de email e senha.");
                return;
            }
            if (!email.Contains("@"))
            {
                MessageBox.Show("Por favor, digite um email válido.");
                return;
            }
            if (senha.Length < 8)
            {
                MessageBox.Show("Por favor, digite no mínimo oito dígitos para sua senha.");
                return;
            }

            _usuarioService.AdicionarUsuario(email, senha);

            MessageBox.Show("Conta criada com sucesso!");

            this.Close();
            var loginForm = new LoginForms();
            loginForm.Show();

        }
        // Evento para o campo de email na tela de criação de conta
        private void criarContaLabelEmail_Enter(object sender, EventArgs e)
        {
            if (telaCriarLabelEmail.Text == "Email")
            {
                telaCriarLabelEmail.Text = ""; // Limpa o texto padrão
                telaCriarLabelEmail.ForeColor = Color.Black; // Altera a cor do texto para preto
            }
        }

        private void criarContaLabelEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(telaCriarLabelEmail.Text))
            {
                telaCriarLabelEmail.Text = "Email";
                telaCriarLabelEmail.ForeColor = Color.Gray; 
            }
        }

        // Evento para o campo de senha na tela de criação de conta
        private void criarContaLabelSenha_Enter(object sender, EventArgs e)
        {
            if (telaCriarLabelSenha.Text == "Senha")
            {
                telaCriarLabelSenha.Text = "";
                telaCriarLabelSenha.PasswordChar = '*'; 
                telaCriarLabelSenha.ForeColor = Color.Black;
            }
        }

        private void criarContaLabelSenha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(telaCriarLabelSenha.Text))
            {
                telaCriarLabelSenha.Text = "Senha";
                telaCriarLabelSenha.PasswordChar = '\0';
                telaCriarLabelSenha.ForeColor = Color.Gray;
            }
        }

    }
}
