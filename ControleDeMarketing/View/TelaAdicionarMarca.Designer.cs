﻿namespace ControleDeMarketing.View
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
            this.textBoxCategoriaAddMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelNomeAddMarca
            // 
            this.labelNomeAddMarca.AutoSize = true;
            this.labelNomeAddMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeAddMarca.Location = new System.Drawing.Point(73, 114);
            this.labelNomeAddMarca.Name = "labelNomeAddMarca";
            this.labelNomeAddMarca.Size = new System.Drawing.Size(48, 16);
            this.labelNomeAddMarca.TabIndex = 1;
            this.labelNomeAddMarca.Text = "Nome:";
            // 
            // textBoxNomeAddMarca
            // 
            this.textBoxNomeAddMarca.Location = new System.Drawing.Point(159, 114);
            this.textBoxNomeAddMarca.Name = "textBoxNomeAddMarca";
            this.textBoxNomeAddMarca.Size = new System.Drawing.Size(130, 20);
            this.textBoxNomeAddMarca.TabIndex = 2;
            // 
            // labelCategoriaAddMarca
            // 
            this.labelCategoriaAddMarca.AutoSize = true;
            this.labelCategoriaAddMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoriaAddMarca.Location = new System.Drawing.Point(73, 146);
            this.labelCategoriaAddMarca.Name = "labelCategoriaAddMarca";
            this.labelCategoriaAddMarca.Size = new System.Drawing.Size(70, 16);
            this.labelCategoriaAddMarca.TabIndex = 1;
            this.labelCategoriaAddMarca.Text = "Categoria:";
            // 
            // textBoxCategoriaAddMarca
            // 
            this.textBoxCategoriaAddMarca.Location = new System.Drawing.Point(159, 144);
            this.textBoxCategoriaAddMarca.Name = "textBoxCategoriaAddMarca";
            this.textBoxCategoriaAddMarca.Size = new System.Drawing.Size(130, 20);
            this.textBoxCategoriaAddMarca.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relevância:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(159, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(41, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // TelaAdicionarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(433, 369);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxCategoriaAddMarca);
            this.Controls.Add(this.textBoxNomeAddMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCategoriaAddMarca);
            this.Controls.Add(this.labelNomeAddMarca);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(449, 407);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(449, 407);
            this.Name = "TelaAdicionarMarca";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelNomeAddMarca;
        private System.Windows.Forms.TextBox textBoxNomeAddMarca;
        private System.Windows.Forms.Label labelCategoriaAddMarca;
        private System.Windows.Forms.TextBox textBoxCategoriaAddMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}