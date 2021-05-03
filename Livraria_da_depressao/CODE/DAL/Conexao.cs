using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Livraria_da_depressao.CODE.DAL
{
    class Conexao
    {
        public static MySqlConnection con = new MySqlConnection(@"Server=localhost;Database=livraria_depressao2;User=root;Pwd=1234567");
    }
}
