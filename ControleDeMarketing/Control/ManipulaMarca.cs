using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ControleDeMarketing.Model;
using System.Windows.Forms;
using System.IO;
using ControleDeMarketing.View;

namespace ControleDeMarketing.Control
{
    class ManipulaMarca
    {
        public void adicionarMarca()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pAdicionarMarca", cn);
            cmd.CommandType = CommandType.StoredProcedure;


            try
            {
                cmd.Parameters.AddWithValue("@nomeMarca", Marca.NomeMarca);
                cmd.Parameters.AddWithValue("@categoriaMarca", Marca.CategoriaMarca);
                cmd.Parameters.AddWithValue("@relevanciaMarca", Marca.RelevanciaMarca);
               
                SqlParameter nv = cmd.Parameters.Add("@idMarca", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso");
            }
            catch (Exception)
            {

            }
        }

    }
}
