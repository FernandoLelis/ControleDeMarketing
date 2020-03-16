namespace ControleDeMarketing.View
{
    partial class TelaAdicionarMarca
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
            this.labelNomeAddMarca = new System.Windows.Forms.Label();
            this.textBoxNomeAddMarca = new System.Windows.Forms.TextBox();
            this.labelCategoriaAddMarca = new System.Windows.Forms.Label();
            this.labelRelvanciaAddMarca = new System.Windows.Forms.Label();
            this.comboBoxRelavanciaAddMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoriaAddMarca = new System.Windows.Forms.ComboBox();
            this.labelLogoAddMarca = new System.Windows.Forms.Label();
            this.buttonLogoAddMarca = new System.Windows.Forms.Button();
            this.buttonSalvarAddMarca = new System.Windows.Forms.Button();
            this.pictureBoxLogoAddMarca = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelCaminhoLogoAddMarca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoAddMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomeAddMarca
            // 
            this.labelNomeAddMarca.AutoSize = true;
            this.labelNomeAddMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeAddMarca.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelNomeAddMarca.Location = new System.Drawing.Point(36, 48);
            this.labelNomeAddMarca.Name = "labelNomeAddMarca";
            this.labelNomeAddMarca.Size = new System.Drawing.Size(49, 17);
            this.labelNomeAddMarca.TabIndex = 1;
            this.labelNomeAddMarca.Text = "Nome:";
            // 
            // textBoxNomeAddMarca
            // 
            this.textBoxNomeAddMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeAddMarca.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxNomeAddMarca.Location = new System.Drawing.Point(159, 45);
            this.textBoxNomeAddMarca.Name = "textBoxNomeAddMarca";
            this.textBoxNomeAddMarca.Size = new System.Drawing.Size(156, 23);
            this.textBoxNomeAddMarca.TabIndex = 2;
            // 
            // labelCategoriaAddMarca
            // 
            this.labelCategoriaAddMarca.AutoSize = true;
            this.labelCategoriaAddMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoriaAddMarca.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelCategoriaAddMarca.Location = new System.Drawing.Point(36, 80);
            this.labelCategoriaAddMarca.Name = "labelCategoriaAddMarca";
            this.labelCategoriaAddMarca.Size = new System.Drawing.Size(73, 17);
            this.labelCategoriaAddMarca.TabIndex = 1;
            this.labelCategoriaAddMarca.Text = "Categoria:";
            // 
            // labelRelvanciaAddMarca
            // 
            this.labelRelvanciaAddMarca.AutoSize = true;
            this.labelRelvanciaAddMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRelvanciaAddMarca.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelRelvanciaAddMarca.Location = new System.Drawing.Point(36, 112);
            this.labelRelvanciaAddMarca.Name = "labelRelvanciaAddMarca";
            this.labelRelvanciaAddMarca.Size = new System.Drawing.Size(82, 17);
            this.labelRelvanciaAddMarca.TabIndex = 1;
            this.labelRelvanciaAddMarca.Text = "Relevância:";
            // 
            // comboBoxRelavanciaAddMarca
            // 
            this.comboBoxRelavanciaAddMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRelavanciaAddMarca.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBoxRelavanciaAddMarca.FormattingEnabled = true;
            this.comboBoxRelavanciaAddMarca.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxRelavanciaAddMarca.Location = new System.Drawing.Point(159, 110);
            this.comboBoxRelavanciaAddMarca.Name = "comboBoxRelavanciaAddMarca";
            this.comboBoxRelavanciaAddMarca.Size = new System.Drawing.Size(41, 24);
            this.comboBoxRelavanciaAddMarca.TabIndex = 3;
            // 
            // comboBoxCategoriaAddMarca
            // 
            this.comboBoxCategoriaAddMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoriaAddMarca.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBoxCategoriaAddMarca.FormattingEnabled = true;
            this.comboBoxCategoriaAddMarca.Items.AddRange(new object[] {
            "Áudio",
            "Iluminação",
            "Painiéis LED",
            "Diversos"});
            this.comboBoxCategoriaAddMarca.Location = new System.Drawing.Point(159, 76);
            this.comboBoxCategoriaAddMarca.Name = "comboBoxCategoriaAddMarca";
            this.comboBoxCategoriaAddMarca.Size = new System.Drawing.Size(156, 24);
            this.comboBoxCategoriaAddMarca.TabIndex = 3;
            // 
            // labelLogoAddMarca
            // 
            this.labelLogoAddMarca.AutoSize = true;
            this.labelLogoAddMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogoAddMarca.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelLogoAddMarca.Location = new System.Drawing.Point(36, 148);
            this.labelLogoAddMarca.Name = "labelLogoAddMarca";
            this.labelLogoAddMarca.Size = new System.Drawing.Size(44, 17);
            this.labelLogoAddMarca.TabIndex = 1;
            this.labelLogoAddMarca.Text = "Logo:";
            // 
            // buttonLogoAddMarca
            // 
            this.buttonLogoAddMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogoAddMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogoAddMarca.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonLogoAddMarca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLogoAddMarca.Location = new System.Drawing.Point(159, 148);
            this.buttonLogoAddMarca.Name = "buttonLogoAddMarca";
            this.buttonLogoAddMarca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonLogoAddMarca.Size = new System.Drawing.Size(75, 24);
            this.buttonLogoAddMarca.TabIndex = 0;
            this.buttonLogoAddMarca.Text = "Buscar";
            this.buttonLogoAddMarca.UseVisualStyleBackColor = true;
            this.buttonLogoAddMarca.Click += new System.EventHandler(this.buttonLogoAddMarca_Click);
            // 
            // buttonSalvarAddMarca
            // 
            this.buttonSalvarAddMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSalvarAddMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarAddMarca.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSalvarAddMarca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSalvarAddMarca.Location = new System.Drawing.Point(141, 219);
            this.buttonSalvarAddMarca.Name = "buttonSalvarAddMarca";
            this.buttonSalvarAddMarca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSalvarAddMarca.Size = new System.Drawing.Size(75, 24);
            this.buttonSalvarAddMarca.TabIndex = 0;
            this.buttonSalvarAddMarca.Text = "Salvar";
            this.buttonSalvarAddMarca.UseVisualStyleBackColor = true;
            this.buttonSalvarAddMarca.Click += new System.EventHandler(this.buttonSalvarAddMarca_Click);
            // 
            // pictureBoxLogoAddMarca
            // 
            this.pictureBoxLogoAddMarca.Location = new System.Drawing.Point(240, 135);
            this.pictureBoxLogoAddMarca.Name = "pictureBoxLogoAddMarca";
            this.pictureBoxLogoAddMarca.Size = new System.Drawing.Size(75, 50);
            this.pictureBoxLogoAddMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogoAddMarca.TabIndex = 4;
            this.pictureBoxLogoAddMarca.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelCaminhoLogoAddMarca
            // 
            this.labelCaminhoLogoAddMarca.AutoSize = true;
            this.labelCaminhoLogoAddMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelCaminhoLogoAddMarca.Location = new System.Drawing.Point(199, 185);
            this.labelCaminhoLogoAddMarca.Name = "labelCaminhoLogoAddMarca";
            this.labelCaminhoLogoAddMarca.Size = new System.Drawing.Size(0, 13);
            this.labelCaminhoLogoAddMarca.TabIndex = 5;
            this.labelCaminhoLogoAddMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TelaAdicionarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 281);
            this.Controls.Add(this.labelCaminhoLogoAddMarca);
            this.Controls.Add(this.pictureBoxLogoAddMarca);
            this.Controls.Add(this.labelNomeAddMarca);
            this.Controls.Add(this.comboBoxCategoriaAddMarca);
            this.Controls.Add(this.comboBoxRelavanciaAddMarca);
            this.Controls.Add(this.textBoxNomeAddMarca);
            this.Controls.Add(this.labelCategoriaAddMarca);
            this.Controls.Add(this.buttonSalvarAddMarca);
            this.Controls.Add(this.buttonLogoAddMarca);
            this.Controls.Add(this.labelLogoAddMarca);
            this.Controls.Add(this.labelRelvanciaAddMarca);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(374, 319);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(374, 319);
            this.Name = "TelaAdicionarMarca";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Marcas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoAddMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNomeAddMarca;
        private System.Windows.Forms.TextBox textBoxNomeAddMarca;
        private System.Windows.Forms.Label labelCategoriaAddMarca;
        private System.Windows.Forms.Label labelRelvanciaAddMarca;
        private System.Windows.Forms.ComboBox comboBoxRelavanciaAddMarca;
        private System.Windows.Forms.ComboBox comboBoxCategoriaAddMarca;
        private System.Windows.Forms.Label labelLogoAddMarca;
        private System.Windows.Forms.Button buttonLogoAddMarca;
        private System.Windows.Forms.Button buttonSalvarAddMarca;
        private System.Windows.Forms.PictureBox pictureBoxLogoAddMarca;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelCaminhoLogoAddMarca;
    }
}