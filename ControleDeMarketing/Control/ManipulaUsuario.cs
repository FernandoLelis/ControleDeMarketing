using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ControleDeMarketing.Model;
using System.Windows.Forms;
using ControleDeMarketing.View;

namespace ControleDeMarketing.Control
{
    class ManipulaUsuario
    {
        public void cadastraUsuario()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeUsuario",Usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@departamentoUsuario", Usuario.DepartamentoUsuario);
                cmd.Parameters.AddWithValue("@emailUsuario", Usuario.EmailUsuario);
                cmd.Parameters.AddWithValue("@senhaUsuario", Usuario.SenhaUsuario);

                SqlParameter nv = cmd.Parameters.Add("@idUsuario", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso.");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void loginUsuario()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pLoginUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;



            cmd.Parameters.AddWithValue("@nomeUsuario", Usuario.NomeUsuario);
            cmd.Parameters.AddWithValue("@senhaUsuario", Usuario.SenhaUsuario);

            cn.Open();
            int i = (int)cmd.ExecuteScalar();

            if (i > 0)
            {
                TelaPrincipal telaPrincipal = new TelaPrincipal();
                telaPrincipal.ShowDialog();

                Application.Exit();                
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Incorreto");
            }

        }
    }
}
