using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleDeMarketing.Model;
using ControleDeMarketing.Control;

namespace ControleDeMarketing.View
{
    public partial class TelaAdicionarMarca : Form
    {
        public TelaAdicionarMarca()
        {
            InitializeComponent();
        }

        private void buttonLogoAddMarca_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxLogoAddMarca.ImageLocation = openFileDialog1.FileName;
                pictureBoxLogoAddMarca.Load();
            }
        }

        private void buttonSalvarAddMarca_Click(object sender, EventArgs e)
        {
            Marca.NomeMarca = textBoxNomeAddMarca.Text;
            Marca.CategoriaMarca = comboBoxCategoriaAddMarca.Text;
            Marca.RelevanciaMarca = comboBoxRelavanciaAddMarca.Text;
            Marca.ImagemMarca = pictureBoxLogoAddMarca.Image;
            
            
            ManipulaMarca manipulaMarca = new ManipulaMarca();
            manipulaMarca.adicionarMarca();
        }
    }
}
