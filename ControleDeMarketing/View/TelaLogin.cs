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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void labelCadastraLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCadastrarUsuario telaCadastrarUsuario = new TelaCadastrarUsuario();
            telaCadastrarUsuario.Closed += (s, args) => this.Close();
            telaCadastrarUsuario.ShowDialog();
          
        }

        private void buttonEntrarLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuario.NomeUsuario = textBoxNomeLogin.Text;
            Usuario.SenhaUsuario = Convert.ToString(textBoxSenhaLogin.Text);

            ManipulaUsuario manipulaUsuario = new ManipulaUsuario();
            manipulaUsuario.loginUsuario();

                     
        }
    }
}
