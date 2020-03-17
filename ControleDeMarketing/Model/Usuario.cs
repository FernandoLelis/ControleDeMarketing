using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMarketing.Model
{
    class Usuario
    {
        private static int idUsuario;
        private static string nomeMarca;
        private static string departamentoUsuario;
        private static string emailUsuario;
        private static int senhaUsuario;

        public static int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public static string NomeMarca { get => nomeMarca; set => nomeMarca = value; }
        public static string DepartamentoUsuario { get => departamentoUsuario; set => departamentoUsuario = value; }
        public static string EmailUsuario { get => emailUsuario; set => emailUsuario = value; }
        public static int SenhaUsuario { get => senhaUsuario; set => senhaUsuario = value; }
    }
}
