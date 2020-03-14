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
            this.button1 = new System.Windows.Forms.Button();
            this.labelNomeAddMarca = new System.Windows.Forms.Label();
            this.textBoxNomeAddMarca = new System.Windows.Forms.TextBox();
            this.labelCategoriaAddMarca = new System.Windows.Forms.Label();
            this.labelRelvanciaAddMarca = new System.Windows.Forms.Label();
            this.comboBoxRelavanciaAddMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoriaAddMarca = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(39, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Logo";
            this.button1.UseVisualStyleBackColor = true;
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
            this.textBoxNomeAddMarca.Size = new System.Drawing.Size(130, 23);
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
            this.comboBoxCategoriaAddMarca.Size = new System.Drawing.Size(130, 24);
            this.comboBoxCategoriaAddMarca.TabIndex = 3;
            // 
            // TelaAdicionarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(362, 368);
            this.Controls.Add(this.labelNomeAddMarca);
            this.Controls.Add(this.comboBoxCategoriaAddMarca);
            this.Controls.Add(this.comboBoxRelavanciaAddMarca);
            this.Controls.Add(this.textBoxNomeAddMarca);
            this.Controls.Add(this.labelCategoriaAddMarca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelRelvanciaAddMarca);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(378, 407);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(378, 407);
            this.Name = "TelaAdicionarMarca";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Marcas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelNomeAddMarca;
        private System.Windows.Forms.TextBox textBoxNomeAddMarca;
        private System.Windows.Forms.Label labelCategoriaAddMarca;
        private System.Windows.Forms.Label labelRelvanciaAddMarca;
        private System.Windows.Forms.ComboBox comboBoxRelavanciaAddMarca;
        private System.Windows.Forms.ComboBox comboBoxCategoriaAddMarca;
    }
}