using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMarketing.Model
{
    class Campanha
    {
        private static string marca;
        private static string midia;
        private static DateTime data;
        private static string descricao;

        public static string Marca { get => marca; set => marca = value; }
        public static string Midia { get => midia; set => midia = value; }
        public static DateTime Data { get => data; set => data = value; }
        public static string Descricao { get => descricao; set => descricao = value; }
    }
}
