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


namespace ControleDeMarketing.View
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();

            labelNomeUsuario.Text = Usuario.NomeUsuario;
            labelDepartamentoUsuario.Text = Usuario.DepartamentoUsuario;
        }

        
        private void labelSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adicionarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaAdicionarMarca telaAdicionarMarca = new TelaAdicionarMarca();
            telaAdicionarMarca.ShowDialog();
        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaAdicionarCampanha telaAdicionarCampanha = new TelaAdicionarCampanha();
            telaAdicionarCampanha.ShowDialog();
        }
    }
}
