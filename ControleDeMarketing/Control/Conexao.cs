﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMarketing.Control
{
    class Conexao
    {
        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arte1\Desktop\Controle_Marketing\C-Sharp\ControleDeMarketing\ControleDeMarketing\bdControleDeMarketing.mdf;Integrated Security=True";
        }
    }
}
