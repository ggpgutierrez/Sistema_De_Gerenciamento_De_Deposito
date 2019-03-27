using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MODERN_GUI_2.Auxiliar
{
    class Connection
    {

        public MySqlConnection Conectar()
        {
            var connString = "Server=localhost;Database=deposito_bd;Uid=root;Pwd=1234567";
            var connection = new MySqlConnection(connString);
            return connection;
        }
    }

   
}
