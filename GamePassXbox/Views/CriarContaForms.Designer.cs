namespace GamePassXbox.Views
{
    partial class CriarContaForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarContaForms));
            this.telaLoginBranco = new System.Windows.Forms.PictureBox();
            this.bntCriarConta = new System.Windows.Forms.Button();
            this.telaCriarContaVoltarLogin = new System.Windows.Forms.Button();
            this.telaCriarLabelSenha = new System.Windows.Forms.TextBox();
            this.telaCriarLabelEmail = new System.Windows.Forms.TextBox();
            this.telaCriarContaDescricao = new System.Windows.Forms.Label();
            this.telaCriarContaTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.telaLoginMicrosoftTitle = new System.Windows.Forms.Label();
            this.IconCriarContaGamePass = new System.Windows.Forms.PictureBox();
            this.telaCriarContaGamePass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.telaLoginBranco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCriarContaGamePass)).BeginInit();
            this.SuspendLayout();
            // 
            // telaLoginBranco
            // 
            this.telaLoginBranco.BackColor = System.Drawing.Color.White;
            this.telaLoginBranco.Location = new System.Drawing.Point(35, 105);
            this.telaLoginBranco.Name = "telaLoginBranco";
            this.telaLoginBranco.Size = new System.Drawing.Size(314, 300);
            this.telaLoginBranco.TabIndex = 2;
            this.telaLoginBranco.TabStop = false;
            // 
            // bntCriarConta
            // 
            this.bntCriarConta.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bntCriarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCriarConta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCriarConta.ForeColor = System.Drawing.Color.White;
            this.bntCriarConta.Location = new System.Drawing.Point(244, 364);
            this.bntCriarConta.Name = "bntCriarConta";
            this.bntCriarConta.Size = new System.Drawing.Size(84, 32);
            this.bntCriarConta.TabIndex = 37;
            this.bntCriarConta.Text = "Próximo";
            this.bntCriarConta.UseVisualStyleBackColor = false;
            this.bntCriarConta.Click += new System.EventHandler(this.bntCriarConta_Click);
            // 
            // telaCriarContaVoltarLogin
            // 
            this.telaCriarContaVoltarLogin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.telaCriarContaVoltarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.telaCriarContaVoltarLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaCriarContaVoltarLogin.ForeColor = System.Drawing.Color.Black;
            this.telaCriarContaVoltarLogin.Location = new System.Drawing.Point(154, 364);
            this.telaCriarContaVoltarLogin.Name = "telaCriarContaVoltarLogin";
            this.telaCriarContaVoltarLogin.Size = new System.Drawing.Size(84, 32);
            this.telaCriarContaVoltarLogin.TabIndex = 36;
            this.telaCriarContaVoltarLogin.Text = "Voltar";
            this.telaCriarContaVoltarLogin.UseVisualStyleBackColor = false;
            this.telaCriarContaVoltarLogin.Click += new System.EventHandler(this.telaCriarContaVoltarLogin_Click);
            // 
            // telaCriarLabelSenha
            // 
            this.telaCriarLabelSenha.BackColor = System.Drawing.Color.White;
            this.telaCriarLabelSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaCriarLabelSenha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.telaCriarLabelSenha.Location = new System.Drawing.Point(63, 296);
            this.telaCriarLabelSenha.Name = "telaCriarLabelSenha";
            this.telaCriarLabelSenha.Size = new System.Drawing.Size(265, 26);
            this.telaCriarLabelSenha.TabIndex = 35;
            this.telaCriarLabelSenha.Text = "Senha";
            this.telaCriarLabelSenha.Enter += new System.EventHandler(this.criarContaLabelSenha_Enter);
            this.telaCriarLabelSenha.Leave += new System.EventHandler(this.criarContaLabelSenha_Leave);
            // 
            // telaCriarLabelEmail
            // 
            this.telaCriarLabelEmail.BackColor = System.Drawing.Color.White;
            this.telaCriarLabelEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaCriarLabelEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.telaCriarLabelEmail.Location = new System.Drawing.Point(63, 264);
            this.telaCriarLabelEmail.Name = "telaCriarLabelEmail";
            this.telaCriarLabelEmail.Size = new System.Drawing.Size(265, 26);
            this.telaCriarLabelEmail.TabIndex = 34;
            this.telaCriarLabelEmail.Text = "Email";
            this.telaCriarLabelEmail.Enter += new System.EventHandler(this.criarContaLabelEmail_Enter);
            this.telaCriarLabelEmail.Leave += new System.EventHandler(this.criarContaLabelEmail_Leave);
            // 
            // telaCriarContaDescricao
            // 
            this.telaCriarContaDescricao.AutoSize = true;
            this.telaCriarContaDescricao.BackColor = System.Drawing.Color.White;
            this.telaCriarContaDescricao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaCriarContaDescricao.ForeColor = System.Drawing.Color.Black;
            this.telaCriarContaDescricao.Location = new System.Drawing.Point(60, 227);
            this.telaCriarContaDescricao.Name = "telaCriarContaDescricao";
            this.telaCriarContaDescricao.Size = new System.Drawing.Size(188, 16);
            this.telaCriarContaDescricao.TabIndex = 33;
            this.telaCriarContaDescricao.Text = "Crie uma conta Xbox para jogar";
            // 
            // telaCriarContaTitulo
            // 
            this.telaCriarContaTitulo.AutoSize = true;
            this.telaCriarContaTitulo.BackColor = System.Drawing.Color.White;
            this.telaCriarContaTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaCriarContaTitulo.ForeColor = System.Drawing.Color.Black;
            this.telaCriarContaTitulo.Location = new System.Drawing.Point(59, 205);
            this.telaCriarContaTitulo.Name = "telaCriarContaTitulo";
            this.telaCriarContaTitulo.Size = new System.Drawing.Size(113, 22);
            this.telaCriarContaTitulo.TabIndex = 32;
            this.telaCriarContaTitulo.Text = "Criar conta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // telaLoginMicrosoftTitle
            // 
            this.telaLoginMicrosoftTitle.AutoSize = true;
            this.telaLoginMicrosoftTitle.BackColor = System.Drawing.Color.White;
            this.telaLoginMicrosoftTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaLoginMicrosoftTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.telaLoginMicrosoftTitle.Location = new System.Drawing.Point(109, 158);
            this.telaLoginMicrosoftTitle.Name = "telaLoginMicrosoftTitle";
            this.telaLoginMicrosoftTitle.Size = new System.Drawing.Size(80, 19);
            this.telaLoginMicrosoftTitle.TabIndex = 30;
            this.telaLoginMicrosoftTitle.Text = "Microsoft";
            // 
            // IconCriarContaGamePass
            // 
            this.IconCriarContaGamePass.BackColor = System.Drawing.Color.Transparent;
            this.IconCriarContaGamePass.Image = ((System.Drawing.Image)(resources.GetObject("IconCriarContaGamePass.Image")));
            this.IconCriarContaGamePass.Location = new System.Drawing.Point(97, 56);
            this.IconCriarContaGamePass.Name = "IconCriarContaGamePass";
            this.IconCriarContaGamePass.Size = new System.Drawing.Size(30, 30);
            this.IconCriarContaGamePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconCriarContaGamePass.TabIndex = 29;
            this.IconCriarContaGamePass.TabStop = false;
            // 
            // telaCriarContaGamePass
            // 
            this.telaCriarContaGamePass.AutoSize = true;
            this.telaCriarContaGamePass.BackColor = System.Drawing.Color.Transparent;
            this.telaCriarContaGamePass.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaCriarContaGamePass.ForeColor = System.Drawing.Color.White;
            this.telaCriarContaGamePass.Location = new System.Drawing.Point(124, 57);
            this.telaCriarContaGamePass.Name = "telaCriarContaGamePass";
            this.telaCriarContaGamePass.Size = new System.Drawing.Size(156, 29);
            this.telaCriarContaGamePass.TabIndex = 28;
            this.telaCriarContaGamePass.Text = "GAME PASS";
            // 
            // CriarContaForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.Controls.Add(this.bntCriarConta);
            this.Controls.Add(this.telaCriarContaVoltarLogin);
            this.Controls.Add(this.telaCriarLabelSenha);
            this.Controls.Add(this.telaCriarLabelEmail);
            this.Controls.Add(this.telaCriarContaDescricao);
            this.Controls.Add(this.telaCriarContaTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.telaLoginMicrosoftTitle);
            this.Controls.Add(this.IconCriarContaGamePass);
            this.Controls.Add(this.telaCriarContaGamePass);
            this.Controls.Add(this.telaLoginBranco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CriarContaForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.telaLoginBranco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCriarContaGamePass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox telaLoginBranco;
        private System.Windows.Forms.Button bntCriarConta;
        private System.Windows.Forms.Button telaCriarContaVoltarLogin;
        private System.Windows.Forms.TextBox telaCriarLabelSenha;
        private System.Windows.Forms.TextBox telaCriarLabelEmail;
        private System.Windows.Forms.Label telaCriarContaDescricao;
        private System.Windows.Forms.Label telaCriarContaTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label telaLoginMicrosoftTitle;
        private System.Windows.Forms.PictureBox IconCriarContaGamePass;
        private System.Windows.Forms.Label telaCriarContaGamePass;
    }
}