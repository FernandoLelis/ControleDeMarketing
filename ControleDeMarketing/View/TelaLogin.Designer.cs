namespace ControleDeMarketing.View
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.pictureBoxTelaLogin = new System.Windows.Forms.PictureBox();
            this.labelNomeLogin = new System.Windows.Forms.Label();
            this.textBoxNomeLogin = new System.Windows.Forms.TextBox();
            this.textBoxSenhaLogin = new System.Windows.Forms.TextBox();
            this.labelLoginSenha = new System.Windows.Forms.Label();
            this.buttonEntrarLogin = new System.Windows.Forms.Button();
            this.labelCadastraLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTelaLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTelaLogin
            // 
            this.pictureBoxTelaLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTelaLogin.Image")));
            this.pictureBoxTelaLogin.Location = new System.Drawing.Point(14, 67);
            this.pictureBoxTelaLogin.Name = "pictureBoxTelaLogin";
            this.pictureBoxTelaLogin.Size = new System.Drawing.Size(112, 101);
            this.pictureBoxTelaLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTelaLogin.TabIndex = 1;
            this.pictureBoxTelaLogin.TabStop = false;
            // 
            // labelNomeLogin
            // 
            this.labelNomeLogin.AutoSize = true;
            this.labelNomeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelNomeLogin.Location = new System.Drawing.Point(132, 90);
            this.labelNomeLogin.Name = "labelNomeLogin";
            this.labelNomeLogin.Size = new System.Drawing.Size(49, 17);
            this.labelNomeLogin.TabIndex = 3;
            this.labelNomeLogin.Text = "Nome:";
            // 
            // textBoxNomeLogin
            // 
            this.textBoxNomeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxNomeLogin.Location = new System.Drawing.Point(191, 87);
            this.textBoxNomeLogin.Name = "textBoxNomeLogin";
            this.textBoxNomeLogin.Size = new System.Drawing.Size(143, 23);
            this.textBoxNomeLogin.TabIndex = 4;
            // 
            // textBoxSenhaLogin
            // 
            this.textBoxSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenhaLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxSenhaLogin.Location = new System.Drawing.Point(191, 127);
            this.textBoxSenhaLogin.Name = "textBoxSenhaLogin";
            this.textBoxSenhaLogin.PasswordChar = '*';
            this.textBoxSenhaLogin.Size = new System.Drawing.Size(143, 23);
            this.textBoxSenhaLogin.TabIndex = 4;
            // 
            // labelLoginSenha
            // 
            this.labelLoginSenha.AutoSize = true;
            this.labelLoginSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginSenha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelLoginSenha.Location = new System.Drawing.Point(132, 130);
            this.labelLoginSenha.Name = "labelLoginSenha";
            this.labelLoginSenha.Size = new System.Drawing.Size(53, 17);
            this.labelLoginSenha.TabIndex = 3;
            this.labelLoginSenha.Text = "Senha:";
            // 
            // buttonEntrarLogin
            // 
            this.buttonEntrarLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEntrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEntrarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrarLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEntrarLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEntrarLogin.Location = new System.Drawing.Point(142, 208);
            this.buttonEntrarLogin.Name = "buttonEntrarLogin";
            this.buttonEntrarLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEntrarLogin.Size = new System.Drawing.Size(75, 24);
            this.buttonEntrarLogin.TabIndex = 5;
            this.buttonEntrarLogin.Text = "Entrar";
            this.buttonEntrarLogin.UseVisualStyleBackColor = true;
            this.buttonEntrarLogin.Click += new System.EventHandler(this.buttonEntrarLogin_Click);
            // 
            // labelCadastraLogin
            // 
            this.labelCadastraLogin.AutoSize = true;
            this.labelCadastraLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCadastraLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastraLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelCadastraLogin.Location = new System.Drawing.Point(261, 255);
            this.labelCadastraLogin.Name = "labelCadastraLogin";
            this.labelCadastraLogin.Size = new System.Drawing.Size(85, 17);
            this.labelCadastraLogin.TabIndex = 3;
            this.labelCadastraLogin.Text = "Cadastre-se";
            this.labelCadastraLogin.Click += new System.EventHandler(this.labelCadastraLogin_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 281);
            this.Controls.Add(this.buttonEntrarLogin);
            this.Controls.Add(this.labelLoginSenha);
            this.Controls.Add(this.labelCadastraLogin);
            this.Controls.Add(this.labelNomeLogin);
            this.Controls.Add(this.textBoxSenhaLogin);
            this.Controls.Add(this.textBoxNomeLogin);
            this.Controls.Add(this.pictureBoxTelaLogin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(374, 319);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(374, 319);
            this.Name = "TelaLogin";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTelaLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTelaLogin;
        private System.Windows.Forms.Label labelNomeLogin;
        private System.Windows.Forms.TextBox textBoxNomeLogin;
        private System.Windows.Forms.TextBox textBoxSenhaLogin;
        private System.Windows.Forms.Label labelLoginSenha;
        private System.Windows.Forms.Button buttonEntrarLogin;
        private System.Windows.Forms.Label labelCadastraLogin;
    }
}