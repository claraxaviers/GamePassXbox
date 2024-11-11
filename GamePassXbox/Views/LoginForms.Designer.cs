namespace GamePassXbox.Views
{
    partial class LoginForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForms));
            this.telaLoginBranco = new System.Windows.Forms.PictureBox();
            this.telaLoginGamePass = new System.Windows.Forms.Label();
            this.IconLoginGamePass = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.telaLoginMicrosoftTitle = new System.Windows.Forms.Label();
            this.telaLoginEntrar = new System.Windows.Forms.Label();
            this.telaLoginEntrarDescricao = new System.Windows.Forms.Label();
            this.telaLoginLabelEmail = new System.Windows.Forms.TextBox();
            this.telaLoginLabelSenha = new System.Windows.Forms.TextBox();
            this.telaLoginDescricaoCriarConta = new System.Windows.Forms.Label();
            this.bntCriarContaLinkLogin = new System.Windows.Forms.LinkLabel();
            this.bntLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.telaLoginBranco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconLoginGamePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // telaLoginGamePass
            // 
            this.telaLoginGamePass.AutoSize = true;
            this.telaLoginGamePass.BackColor = System.Drawing.Color.Transparent;
            this.telaLoginGamePass.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaLoginGamePass.ForeColor = System.Drawing.Color.White;
            this.telaLoginGamePass.Location = new System.Drawing.Point(124, 57);
            this.telaLoginGamePass.Name = "telaLoginGamePass";
            this.telaLoginGamePass.Size = new System.Drawing.Size(156, 29);
            this.telaLoginGamePass.TabIndex = 12;
            this.telaLoginGamePass.Text = "GAME PASS";
            // 
            // IconLoginGamePass
            // 
            this.IconLoginGamePass.BackColor = System.Drawing.Color.Transparent;
            this.IconLoginGamePass.Image = ((System.Drawing.Image)(resources.GetObject("IconLoginGamePass.Image")));
            this.IconLoginGamePass.Location = new System.Drawing.Point(97, 56);
            this.IconLoginGamePass.Name = "IconLoginGamePass";
            this.IconLoginGamePass.Size = new System.Drawing.Size(30, 30);
            this.IconLoginGamePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconLoginGamePass.TabIndex = 13;
            this.IconLoginGamePass.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
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
            this.telaLoginMicrosoftTitle.TabIndex = 15;
            this.telaLoginMicrosoftTitle.Text = "Microsoft";
            // 
            // telaLoginEntrar
            // 
            this.telaLoginEntrar.AutoSize = true;
            this.telaLoginEntrar.BackColor = System.Drawing.Color.White;
            this.telaLoginEntrar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaLoginEntrar.ForeColor = System.Drawing.Color.Black;
            this.telaLoginEntrar.Location = new System.Drawing.Point(59, 205);
            this.telaLoginEntrar.Name = "telaLoginEntrar";
            this.telaLoginEntrar.Size = new System.Drawing.Size(68, 22);
            this.telaLoginEntrar.TabIndex = 16;
            this.telaLoginEntrar.Text = "Entrar";
            // 
            // telaLoginEntrarDescricao
            // 
            this.telaLoginEntrarDescricao.AutoSize = true;
            this.telaLoginEntrarDescricao.BackColor = System.Drawing.Color.White;
            this.telaLoginEntrarDescricao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaLoginEntrarDescricao.ForeColor = System.Drawing.Color.Black;
            this.telaLoginEntrarDescricao.Location = new System.Drawing.Point(60, 227);
            this.telaLoginEntrarDescricao.Name = "telaLoginEntrarDescricao";
            this.telaLoginEntrarDescricao.Size = new System.Drawing.Size(178, 16);
            this.telaLoginEntrarDescricao.TabIndex = 17;
            this.telaLoginEntrarDescricao.Text = "Digite um Email e uma senha";
            // 
            // telaLoginLabelEmail
            // 
            this.telaLoginLabelEmail.BackColor = System.Drawing.Color.White;
            this.telaLoginLabelEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaLoginLabelEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.telaLoginLabelEmail.Location = new System.Drawing.Point(63, 264);
            this.telaLoginLabelEmail.Name = "telaLoginLabelEmail";
            this.telaLoginLabelEmail.Size = new System.Drawing.Size(265, 26);
            this.telaLoginLabelEmail.TabIndex = 18;
            this.telaLoginLabelEmail.Text = "Email";
            this.telaLoginLabelEmail.Enter += new System.EventHandler(this.telaLoginLabelEmail_Enter);
            this.telaLoginLabelEmail.Leave += new System.EventHandler(this.telaLoginLabelEmail_Leave);
            // 
            // telaLoginLabelSenha
            // 
            this.telaLoginLabelSenha.BackColor = System.Drawing.Color.White;
            this.telaLoginLabelSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaLoginLabelSenha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.telaLoginLabelSenha.Location = new System.Drawing.Point(63, 296);
            this.telaLoginLabelSenha.Name = "telaLoginLabelSenha";
            this.telaLoginLabelSenha.Size = new System.Drawing.Size(265, 26);
            this.telaLoginLabelSenha.TabIndex = 19;
            this.telaLoginLabelSenha.Text = "Senha";
            this.telaLoginLabelSenha.Enter += new System.EventHandler(this.telaLoginLabelSenha_Enter);
            this.telaLoginLabelSenha.Leave += new System.EventHandler(this.telaLoginLabelSenha_Leave);
            // 
            // telaLoginDescricaoCriarConta
            // 
            this.telaLoginDescricaoCriarConta.AutoSize = true;
            this.telaLoginDescricaoCriarConta.BackColor = System.Drawing.Color.White;
            this.telaLoginDescricaoCriarConta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaLoginDescricaoCriarConta.ForeColor = System.Drawing.Color.Black;
            this.telaLoginDescricaoCriarConta.Location = new System.Drawing.Point(63, 329);
            this.telaLoginDescricaoCriarConta.Name = "telaLoginDescricaoCriarConta";
            this.telaLoginDescricaoCriarConta.Size = new System.Drawing.Size(105, 14);
            this.telaLoginDescricaoCriarConta.TabIndex = 20;
            this.telaLoginDescricaoCriarConta.Text = "Não tem uma conta?";
            // 
            // bntCriarContaLinkLogin
            // 
            this.bntCriarContaLinkLogin.AutoSize = true;
            this.bntCriarContaLinkLogin.BackColor = System.Drawing.Color.White;
            this.bntCriarContaLinkLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCriarContaLinkLogin.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCriarContaLinkLogin.LinkColor = System.Drawing.SystemColors.Highlight;
            this.bntCriarContaLinkLogin.Location = new System.Drawing.Point(165, 329);
            this.bntCriarContaLinkLogin.Name = "bntCriarContaLinkLogin";
            this.bntCriarContaLinkLogin.Size = new System.Drawing.Size(51, 14);
            this.bntCriarContaLinkLogin.TabIndex = 21;
            this.bntCriarContaLinkLogin.TabStop = true;
            this.bntCriarContaLinkLogin.Text = "Crie uma!";
            this.bntCriarContaLinkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.bntCriarContaLinkLogin_LinkClicked);
            // 
            // bntLogin
            // 
            this.bntLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bntLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLogin.ForeColor = System.Drawing.Color.White;
            this.bntLogin.Location = new System.Drawing.Point(244, 364);
            this.bntLogin.Name = "bntLogin";
            this.bntLogin.Size = new System.Drawing.Size(84, 32);
            this.bntLogin.TabIndex = 22;
            this.bntLogin.Text = "Próximo";
            this.bntLogin.UseVisualStyleBackColor = false;
            this.bntLogin.Click += new System.EventHandler(this.bntLogin_Click);
            // 
            // LoginForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.Controls.Add(this.bntLogin);
            this.Controls.Add(this.bntCriarContaLinkLogin);
            this.Controls.Add(this.telaLoginDescricaoCriarConta);
            this.Controls.Add(this.telaLoginLabelSenha);
            this.Controls.Add(this.telaLoginLabelEmail);
            this.Controls.Add(this.telaLoginEntrarDescricao);
            this.Controls.Add(this.telaLoginEntrar);
            this.Controls.Add(this.telaLoginMicrosoftTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.IconLoginGamePass);
            this.Controls.Add(this.telaLoginGamePass);
            this.Controls.Add(this.telaLoginBranco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.telaLoginBranco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconLoginGamePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox telaLoginBranco;
        private System.Windows.Forms.Label telaLoginGamePass;
        private System.Windows.Forms.PictureBox IconLoginGamePass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label telaLoginMicrosoftTitle;
        private System.Windows.Forms.Label telaLoginEntrar;
        private System.Windows.Forms.Label telaLoginEntrarDescricao;
        private System.Windows.Forms.TextBox telaLoginLabelEmail;
        private System.Windows.Forms.TextBox telaLoginLabelSenha;
        private System.Windows.Forms.Label telaLoginDescricaoCriarConta;
        private System.Windows.Forms.LinkLabel bntCriarContaLinkLogin;
        private System.Windows.Forms.Button bntLogin;
    }
}