using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (openFileDialogLocaLogoAddMarca.ShowDialog() == DialogResult.OK)
            {
               
            }
        }
    }
}
