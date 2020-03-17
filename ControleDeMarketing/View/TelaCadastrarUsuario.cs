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
    public partial class TelaCadastrarUsuario : Form
    {
        public TelaCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void buttonCadastrarCadastro_Click(object sender, EventArgs e)
        {

            Usuario.NomeUsuario = textBoxNomeCadastro.Text;
            Usuario.DepartamentoUsuario = comboBoxDepartamentoCadastro.Text;
            Usuario.EmailUsuario = textBoxEmailCadastro.Text;
            Usuario.SenhaUsuario = Convert.ToInt32(textBoxSenhaCadastro.Text);

            ManipulaUsuario manipulaUsuario = new ManipulaUsuario();
            manipulaUsuario.cadastraUsuario();

            textBoxNomeCadastro.Text = "";
            comboBoxDepartamentoCadastro.Text = "";
            textBoxEmailCadastro.Text = "";
            textBoxSenhaCadastro.Text = "";            
        }
    }
}
