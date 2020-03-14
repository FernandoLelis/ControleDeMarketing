using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMarketing.Model
{
    class Marca
    {
        private static string nomeMarca;
        private static string categoriaMarca;
        private static string imagemMarca;
        private static string relevanciaMarca;

        public static string NomeMarca { get => nomeMarca; set => nomeMarca = value; }
        public static string CategoriaMarca { get => categoriaMarca; set => categoriaMarca = value; }
        public static string ImagemMarca { get => imagemMarca; set => imagemMarca = value; }
        public static string RelevanciaMarca { get => relevanciaMarca; set => relevanciaMarca = value; }
    }
}
