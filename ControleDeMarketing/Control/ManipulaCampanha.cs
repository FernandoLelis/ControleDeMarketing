using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ControleDeMarketing.Model;
using System.Windows.Forms;


namespace ControleDeMarketing.Control
{
    class ManipulaCampanha
    {
        public void adicionarCampanha()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pAdicionarCampanha", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            
            try
            {
                cmd.Parameters.AddWithValue("@nomeMarca", Campanha.Marca);
                cmd.Parameters.AddWithValue("@midiaCampanha", Campanha.Midia);
                cmd.Parameters.AddWithValue("@dataCampanha", Campanha.Data);
                cmd.Parameters.AddWithValue("@descricaoCampanha", Campanha.Descricao);
                 
                SqlParameter nv = cmd.Parameters.Add("@idCampanha", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Campanha adicionada com sucesso");
            }
            catch (Exception)
            {

            }
        }

    }
}
