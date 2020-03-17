using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;


namespace ControleDeMarketing.Model
{
    class Marca
    {
        private static int idMarca;
        private static string nomeMarca;
        private static string categoriaMarca;
        private static string relevanciaMarca;

        public static int IdMarca { get => idMarca; set => idMarca = value; }
        public static string NomeMarca { get => nomeMarca; set => nomeMarca = value; }
        public static string CategoriaMarca { get => categoriaMarca; set => categoriaMarca = value; }
        public static string RelevanciaMarca { get => relevanciaMarca; set => relevanciaMarca = value; }
    }
}
