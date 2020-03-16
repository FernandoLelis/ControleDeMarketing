using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleDeMarketing.Control;
using ControleDeMarketing.Model;

namespace ControleDeMarketing.View
{
    public partial class TelaAdicionarCampanha : Form
    {
        public TelaAdicionarCampanha()
        {
            InitializeComponent();
        }

        private void buttonSalvarAddCampanha_Click(object sender, EventArgs e)
        {
            Campanha.Marca = comboBoxMarcaAddCampanha.Text;
            Campanha.Midia = textBoxMidiaAddCampanha.Text;
            Campanha.Data = Convert.ToDateTime(dateTimePickerDataAddCampanha.Text);
            Campanha.Descricao = textBoxDescricaoAddCampanha.Text;

            ManipulaCampanha manipulaCampanha = new ManipulaCampanha();
            manipulaCampanha.adicionarCampanha();

            comboBoxMarcaAddCampanha.Text = "";
            textBoxMidiaAddCampanha.Text = "";
            dateTimePickerDataAddCampanha.Text = "";
            textBoxDescricaoAddCampanha.Text = "";
        }
    }
}
